using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFood
{
    public partial class Rezepte_hinzufügen : Form
    {
        BindingSource rezeptenbindingsource = new BindingSource();
        DataTable table = new DataTable("table");
        public Rezepte_hinzufügen()
        {
            InitializeComponent();
            PopulateComboBox();

        }
        private void PopulateComboBox()
        {
            dtp_combobox.Items.Add("Vegan");
            dtp_combobox.Items.Add("Vegetarian");
            dtp_combobox.Items.Add("Meals with meat");
            Rezepttype_comboBox.Items.Add("Drink");
            Rezepttype_comboBox.Items.Add("food");
        }

        private void Rezepte_hinzufügen_Load(object sender, EventArgs e)
        {
            // Ensure DataTable is defined only once
            table.Columns.Add("Zutat_name", typeof(string));
            table.Columns.Add("Kalorien_pro_100g", typeof(int));
            table.Columns.Add("Kohlenhydrate", typeof(int));
            table.Columns.Add("Proteine", typeof(int));
            table.Columns.Add("Fette", typeof(int));

            // Bind DataGridView to DataTable
            zutatenDataGridView.DataSource = table;
        }





        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(Rezept_name_txt.Text) ||
                    string.IsNullOrWhiteSpace(Portionen_txt.Text) ||
                    string.IsNullOrWhiteSpace(Naehrwerte_txt.Text) ||
                    Rezepttype_comboBox.SelectedItem == null ||
                    dtp_combobox.SelectedItem == null ||
                    string.IsNullOrWhiteSpace(anweisungen_txt.Text) ||
                    string.IsNullOrWhiteSpace(image_url_txt.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Capture Rezepten data
                Rezepten rezepten = new Rezepten
                {
                    RezeptName = Rezept_name_txt.Text,
                    Portionen = int.Parse(Portionen_txt.Text),
                    Naehrwerte = Naehrwerte_txt.Text,
                    RezeptType = Rezepttype_comboBox.SelectedItem.ToString(),
                    Dietarypreferences = dtp_combobox.SelectedItem.ToString(),
                    Anweisungen = anweisungen_txt.Text,
                    Image_Description = image_url_txt.Text
                };

                RezeptenDAO rezeptenDAO = new RezeptenDAO();

                // Insert Rezepten data
                int result = rezeptenDAO.addonerezept(rezepten);
                if (result == 0)
                {
                    MessageBox.Show("Failed to insert Rezept");
                    return;
                }

                // Get the last inserted Rezept ID
                int rezeptId = rezeptenDAO.GetLastInsertedRezeptId();

                // Capture Zutaten data from DataGridView and insert them
                foreach (DataGridViewRow row in zutatenDataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    Zutat zutat = new Zutat
                    {
                        Zutat_Name = row.Cells["Zutat_name"].Value?.ToString(),
                        Kalorien_pro_100g = int.Parse(row.Cells["Kalorien_pro_100g"].Value?.ToString() ?? "0"),
                        Kohlenhydrate = int.Parse(row.Cells["Kohlenhydrate"].Value?.ToString() ?? "0"),
                        Proteine = int.Parse(row.Cells["Proteine"].Value?.ToString() ?? "0"),
                        Fette = int.Parse(row.Cells["Fette"].Value?.ToString() ?? "0")
                    };

                    int zutatId = rezeptenDAO.AddZutat(zutat);

                    // Link the Rezept with Zutat in REZEPT_ZUTAT table
                    rezeptenDAO.LinkRezeptZutat(rezeptId, zutatId);
                }

                MessageBox.Show("Rezept and Zutaten inserted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Add values to DataTable
            table.Rows.Add(
                Zutat_name_Txt.Text,
                int.Parse(Kalorien_pro_100g_Txt.Text),
                int.Parse(Kohlenhydrate_Txt.Text),
                int.Parse(Proteine_Txt.Text),
                int.Parse(Fette_Txt.Text)
            );
        }




    }
}