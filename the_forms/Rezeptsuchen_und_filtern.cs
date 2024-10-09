using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using System.IO;
using HomeFood.extensions;
using System.Reflection;

namespace HomeFood
{
    public partial class Rezeptsuchen_und_filtern : Form
    {
        BindingSource rezeptenbindingsource = new BindingSource();
        private List<Rezepten> allRecipes;
        private List<Rezepten> filteredRecipes;
        Rezepten rezepOnEdit;

        const string ALLE_KEY = "Alle";
        public Rezeptsuchen_und_filtern()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            loadAllRecipes();
        }

        private void loadAllRecipes()
        {
            // creating an instance of rezeptenDAO class rezeptenDAO RezeptenDAO declares the variable new rezeptenDAO();this part creates the instance
            RezeptenDAO rezeptenDAO = new RezeptenDAO();

            allRecipes = filteredRecipes = rezeptenDAO.getAllRezept();

        }


        private void updateDataGridView()
        {
            rezeptenbindingsource.DataSource = filteredRecipes;
            dishesDataGridView.DataSource = rezeptenbindingsource;

            // Ensure columns are set up correctly
            dishesDataGridView.Columns["Rezept_ID"].Visible = false;
            dishesDataGridView.Columns["Image_Description"].Visible = false;

            //// Add image column if not already added
            //if (dishesDataGridView.Columns["RecipeImage"] == null)
            //{
            //    DataGridViewImageColumn imgColumn = new DataGridViewImageColumn
            //    {
            //        Name = "RecipeImage",
            //        HeaderText = "Image",
            //        ImageLayout = DataGridViewImageCellLayout.Zoom
            //    };
            //    dishesDataGridView.Columns.Insert(0, imgColumn);
            //}

            //// Load images into the new image column
            //foreach (DataGridViewRow row in dishesDataGridView.Rows)
            //{
            //    Rezepten rezepOnEdit = row.DataBoundItem as Rezepten;
            //    if (rezepOnEdit != null)
            //    {
            //        row.Cells["RecipeImage"].Value = rezepOnEdit.Image;
            //    }
            //}
        }




        private void updateRecipeTypes()
        {
            if (allRecipes == null) return;
            List<String> recipesTypes = new List<string>
          {
             ALLE_KEY
          };
            recipesTypes.AddRange(allRecipes.Select(recipe => recipe.RezeptType));


            recipesTypeCombBox.Items.Clear();
            recipesTypeCombBox.Items.AddRange(recipesTypes.Distinct().ToArray());
            if (recipesTypeCombBox.Items.Count > 0)
            {
                recipesTypeCombBox.SelectedIndex = 0;
            }
        }


        private void updateDiateryPreferences()
        {
            if (allRecipes == null) return;
            List<String> diateryPreferences = new List<string>
          {
             ALLE_KEY
          };
            diateryPreferences.AddRange(allRecipes.Select(recipe => recipe.Dietarypreferences));


            diateryPrefCombBox.Items.Clear();
            diateryPrefCombBox.Items.AddRange(diateryPreferences.Distinct().ToArray());
            if (diateryPrefCombBox.Items.Count > 0)
            {
                diateryPrefCombBox.SelectedIndex = 0;
            }
        }



        private void applySearchBtn_Click(object sender, EventArgs e)
        {
            applyFiltersOnLocalData();

            //TODO : filter directly from database

        }

        void applyFiltersOnLocalData()
        {
            filteredRecipes = allRecipes;
            string searchKey = keywordTextBox.Text;
            string diateryPref = diateryPrefCombBox.SelectedItem.ToString();
            string disheType = recipesTypeCombBox.SelectedItem.ToString();


            int min = minCaloryTrackbar.Value;
            int max = maxCaloryTrackbar.Value;

            filteredRecipes = filteredRecipes.Where(recipe => recipe.Naehrwerte.extractCaloryValue() >= min && recipe.Naehrwerte.extractCaloryValue() <= max).ToList();

            if (!string.IsNullOrEmpty(searchKey))
            {

                filteredRecipes = filteredRecipes.Where(recipe => recipe.RezeptName.Contains(searchKey) || recipe.Anweisungen.Contains(searchKey)).ToList();
            }
            if (!string.IsNullOrEmpty(diateryPref) && diateryPref != ALLE_KEY)
            {
                filteredRecipes = filteredRecipes.Where(recipe => recipe.Dietarypreferences == diateryPref).ToList();

            }
            if (!string.IsNullOrEmpty(disheType) && disheType != ALLE_KEY)
            {
                filteredRecipes = filteredRecipes.Where(recipe => recipe.RezeptType == disheType).ToList();

            }



            updateDataGridView();


        }




        private void Form1_Load(object sender, EventArgs e)
        {
            loadAllRecipes();
            updateDataGridView();
            updateRecipeTypes();
            updateDiateryPreferences();
            updateCaloryRanges();


        }

        private void updateCaloryRanges()
        {
            IEnumerable<int> caloryValues = filteredRecipes.Select(recipe => recipe.Naehrwerte.extractCaloryValue());

            minCaloryTrackbar.Minimum = caloryValues.Min();
            minCaloryTrackbar.Maximum = caloryValues.Max();
            minCaloryTrackbar.Value = caloryValues.Min();


            maxCaloryTrackbar.Minimum = caloryValues.Min();
            maxCaloryTrackbar.Maximum = caloryValues.Max();
            maxCaloryTrackbar.Value = caloryValues.Max();
        }

        private void resetFiltersBtn_Click(object sender, EventArgs e)
        {
            diateryPrefCombBox.SelectedIndex = 0;
            recipesTypeCombBox.SelectedIndex = 0;
            keywordTextBox.Text = string.Empty;

            filteredRecipes = allRecipes;

            updateCaloryRanges();

            updateDataGridView();
        }

        private void minCaloryTrackbar_ValueChanged(object sender, EventArgs e)
        {
            minTrackBarValueTextBox.Text = minCaloryTrackbar.Value.ToString() + " KJ";
        }

        private void maxCaloryTrackbar_ValueChanged(object sender, EventArgs e)
        {
            maxTrackBarValueTextBox.Text = maxCaloryTrackbar.Value.ToString() + " KJ";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void dishesDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                var rezept = (Rezepten)dishesDataGridView.Rows[e.RowIndex].DataBoundItem;
                if (rezept != null)
                {
                    try
                    {
                        using (var webClient = new System.Net.WebClient())
                        {
                            byte[] imageBytes = webClient.DownloadData(rezept.Image_Description);
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                Image img = Image.FromStream(ms);
                                e.Value = new Bitmap(img, new Size(70, 70));
                            }
                        }
                    }
                    catch (Exception)
                    {
                        // Create an image with an 'X'
                        Bitmap errorImage = new Bitmap(70, 70);
                        using (Graphics g = Graphics.FromImage(errorImage))
                        {
                            g.Clear(Color.White);
                            Pen pen = new Pen(Color.Red, 5);
                            g.DrawLine(pen, new Point(0, 0), new Point(70, 70));
                            g.DrawLine(pen, new Point(70, 0), new Point(0, 70));
                        }
                        e.Value = errorImage;
                    }
                }
            }
        }


        private void dishesDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the click is on a valid row and not on the header
                if (e.RowIndex >= 0 && e.RowIndex < dishesDataGridView.Rows.Count)
                {
                    DataGridViewRow row = dishesDataGridView.Rows[e.RowIndex];
                    Rezepten rezept = row.DataBoundItem as Rezepten;

                    if (rezept != null)
                    {
                        // Display image
                        if (rezept.Image != null)
                        {
                            pictureBox1.Image = rezept.Image;
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }

                        // Build and display recipe details
                        StringBuilder details = new StringBuilder();
                        details.AppendLine($"Recipe Name: {rezept.RezeptName}");
                        details.AppendLine($"Portionen: {rezept.Portionen}");
                        details.AppendLine($"Naehrwerte: {rezept.Naehrwerte}");
                        details.AppendLine($"Type: {rezept.RezeptType}");
                        details.AppendLine($"Dietary Preferences: {rezept.Dietarypreferences}");
                        details.AppendLine();

                        foreach (var zutat in rezept.Zutaten)
                        {
                            details.AppendLine($"{zutat.Zutat_Name}: {zutat.Kalorien_pro_100g}kcal, {zutat.Kohlenhydrate}g Carbs, {zutat.Proteine}g Protein, {zutat.Fette}g Fat");
                        }

                        details.AppendLine();
                        details.AppendLine("Instructions:");
                        details.AppendLine(rezept.Anweisungen);

                        display_textBox1.Text = details.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No details found for the selected recipe.", "No Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dishesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dishesDataGridView.Rows[e.RowIndex];
             rezepOnEdit = row.DataBoundItem as Rezepten;
            List<ChangeLog> changes = checkForUpdate();
            MessageBox.Show(FormatChanges(changes), "Changes Detected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dishesDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

            DataGridViewRow row = dishesDataGridView.Rows[e.RowIndex];
            rezepOnEdit = row.DataBoundItem as Rezepten;
    
        }

        public  string FormatChanges(List<ChangeLog> changes)
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

                if (oldValue.ToString() !=newValue.ToString())
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

    }
}
