using HomeFood._588286;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFood
{
    public partial class AdminRezeptEditor : Form
    {
        BindingSource rezeptenbindingsource = new BindingSource();
        private List<Rezepten> allRecipes;
        private List<Rezepten> filteredRecipes;
        Rezepten rezepOnEdit;

        public AdminRezeptEditor()
        {
            InitializeComponent();
        }

        private void loadBtnRecipes_Click(object sender, EventArgs e)
        {
            loadAllRecipes2();
        }

        private void loadAllRecipes2()
        {
            RezeptenDAO rezeptenDAO = new RezeptenDAO();
            allRecipes = filteredRecipes = rezeptenDAO.getAllRezept();
            rezeptenbindingsource.DataSource = allRecipes;
            dishesdataGridView.DataSource = rezeptenbindingsource;

            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dishesdataGridView.AutoGenerateColumns = false;
            dishesdataGridView.Columns.Clear();

            AddColumn("Rezept_ID", "ID");
            AddColumn("RezeptName", "Recipe Name");
            AddColumn("Portionen", "Portions");
            AddColumn("Naehrwerte", "Nutritional Values");
            AddColumn("RezeptType", "Recipe Type");
            AddColumn("Dietarypreferences", "Dietary Preferences");
            AddColumn("Anweisungen", "Instructions");
            AddColumn("Image_Description", "Image Description");

            //// Optionally add an image column if required
            //DataGridViewImageColumn imgColumn = new DataGridViewImageColumn
            //{
            //    Name = "Image",
            //    HeaderText = "Image",
            //    ImageLayout = DataGridViewImageCellLayout.Zoom
            //};
            //dishesdataGridView.Columns.Add(imgColumn);
        }

        private void AddColumn(string propertyName, string headerText)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = propertyName,
                HeaderText = headerText,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dishesdataGridView.Columns.Add(column);
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            RezeptenDAO rezeptenDAO = new RezeptenDAO();
            allRecipes = filteredRecipes = rezeptenDAO.searchRezept(textBox1.Text );
            rezeptenbindingsource.DataSource = allRecipes;
            dishesdataGridView.DataSource = rezeptenbindingsource;

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            int rowclicked=dishesdataGridView.CurrentRow.Index;
            //MessageBox.Show("you clicked row " + rowclicked);
            int rezeptid=(int)dishesdataGridView.Rows[rowclicked].Cells[0].Value;
            //MessageBox.Show("you rezepid  " + rezeptid);
            RezeptenDAO rezeptenDAO=new RezeptenDAO();
            int result = rezeptenDAO.deleteRezept(rezeptid);
            MessageBox.Show("Result" +  result);

        }

        private void dishesdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dishesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dishesdataGridView.Rows[e.RowIndex];
            rezepOnEdit = row.DataBoundItem as Rezepten;
            List<ChangeLog> changes = checkForUpdate();
            MessageBox.Show(FormatChanges(changes), "Changes Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dishesDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

            DataGridViewRow row = dishesdataGridView.Rows[e.RowIndex];
            rezepOnEdit = row.DataBoundItem as Rezepten;

        }

        public string FormatChanges(List<ChangeLog> changes)
        {
            if (changes == null || changes.Count == 0)
            {
                return "No changes detected.";
            }

            var changeMessages = changes.Select(change =>
                $"Property: {change.PropertyName}\nOld Value: {change.OldValue}\nNew Value: {change.NewValue}\n");

            return string.Join("\n", changeMessages);
        }

        private List<ChangeLog> checkForUpdate()
        {

            if (rezepOnEdit == null)
                return new List<ChangeLog>();

            Rezepten oldObj = allRecipes.Find(r => r.Rezept_ID == rezepOnEdit.Rezept_ID);

            var changes = new List<ChangeLog>();
            var properties = typeof(Rezepten).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var property in properties)
            {
                var oldValue = property.GetValue(oldObj);
                var newValue = property.GetValue(rezepOnEdit);

                if (oldValue.ToString() != newValue.ToString())
                {
                    changes.Add(new ChangeLog
                    {
                        PropertyName = property.Name,
                        OldValue = oldValue,
                        NewValue = newValue
                    });
                }
            }


            return changes;
        }
        private void Update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Iterate through all the rows to find edited ones
                foreach (DataGridViewRow row in dishesdataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    Rezepten updatedRecipe = row.DataBoundItem as Rezepten;
                    if (updatedRecipe != null)
                    {
                        RezeptenDAO rezeptenDAO = new RezeptenDAO();
                        int result = rezeptenDAO.updateRezept(updatedRecipe);

                        if (result > 0)
                        {
                            MessageBox.Show($"Recipe '{updatedRecipe.RezeptName}' updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Failed to update recipe '{updatedRecipe.RezeptName}'.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void inbox_btn_Click(object sender, EventArgs e)
        {
            

           
            {
                // Retrieve messages from the communication form
                List<HomeFood._588286.Message> messages = HomeFood._588286.communication.GetMessages();

                // Pass the messages to the message form and display it
                HomeFood._588286.message messageForm = new HomeFood._588286.message(messages);
                messageForm.ShowDialog();
            }
        }


    }
}
