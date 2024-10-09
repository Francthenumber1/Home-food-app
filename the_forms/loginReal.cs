using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeFood
{
    public partial class loginReal : Form
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=Aubin1234.;database=food_for_home;";

        public loginReal()
        {
            InitializeComponent();
        }
         public List<Benutzer> searchRezept(string searchTerm)
        {
            List<Benutzer> returnThese = new List<Benutzer>();
            string searchWildPhrase = "%" + searchTerm + "%"; // Wildcard search phrase for SQL LIKE.

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand("select * from benutzer where Benutzer_name='" + txtUsername.Text + "'and Passwort='" + txtpasswort + "'and titel='" +titelCombobox+"'"))
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) // Loop through search results.
                        {
                            Benutzer benutzer = new Benutzer
                            {
                                Benutzer_name = reader.GetString("BENUTZER_NAME"),
                                password = reader.GetString("Passwort"),
                                titel = reader.GetString("Titel"),
                                
                            };
                            returnThese.Add(benutzer); 
                        }
                    }
                }
            }
            return returnThese; // Return the list of recipes matching the search term.
        }
        public void Showusername (string user)
        {
            txtUsername.Text= user ;
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "datasource=localhost;port=3306;username=root;password=Aubin1234.;database=food_for_home;";

            // Create MySQL command and associate it with the connection
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con; // You need to assign the connection here

            // Set the SQL query with parameters (use placeholders to prevent SQL injection)
            cmd.CommandText = "SELECT * FROM benutzer WHERE Benutzer_Name=@Benutzer_Name AND Passwort=@Passwort AND Titel=@Titel";

            // Add parameters to the SQL command
            cmd.Parameters.AddWithValue("@Benutzer_Name", txtUsername.Text);  // Assuming 'txtBenutName' is a TextBox
            cmd.Parameters.AddWithValue("@Passwort", txtpasswort.Text);    // Assuming 'txtPasswort' is a TextBox
            cmd.Parameters.AddWithValue("@Titel", titelCombobox.SelectedItem.ToString()); // Assuming 'titelCombobox' is the ComboBox

            // Open the connection
            con.Open();

            // Create DataAdapter and DataSet
            MySqlDataAdapter da = new MySqlDataAdapter(cmd); // Now cmd has the connection assigned
            DataSet ds = new DataSet();

            // Fill the DataSet with the result of the query
            da.Fill(ds);

            // You can now use the DataSet 'ds' to process the data (e.g., show it in a UI component)

            // Close the connection
            con.Close();

            if (ds.Tables[0].Rows.Count != 0 && titelCombobox.SelectedItem=="user")
            {
                string username = txtUsername.Text;
                New_mainpage new_Mainpage = new New_mainpage(username);
                this.Hide();
                new_Mainpage.ShowDialog();
            }
            else if(ds.Tables[0].Rows.Count != 0 && titelCombobox.SelectedItem == "Admin")
            {
                AdminRezeptEditor adminRezeptEditor = new AdminRezeptEditor();
                adminRezeptEditor.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close() ;
        }

        private void loginReal_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            { txtUsername.Clear(); }
        }

        private void txtpasswort_MouseEnter(object sender, EventArgs e)
        {

            if (txtpasswort.Text == "Password")
            { txtpasswort.Clear(); }
        }
    }

}
