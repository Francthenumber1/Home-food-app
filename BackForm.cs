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
    
    public partial class BackForm : Form
    {
        
        
        
        public BackForm()
        {
            InitializeComponent();
        }

        private void BackForm_Load(object sender, EventArgs e)
        {

        }
        public void DisplayRecipe(string recipe)
        {
            
            richTextBox1.Text = recipe; // Assuming richTextBox1 is present in BackForm
            
        }
        public void SetRecipeName(string recipeName) //to updatethe label Text
        {
            lblRecipeName.Text = recipeName;
            
        }
        public void SetRecipeImage(Image image)
        {
            pictureBoxRecipe.Image = image;
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
          
            
            MainRezeptForm mainForm = new MainRezeptForm();
            this.Hide(); // Hide the BackForm

            // Assuming you have a reference to the original MainRezeptForm, reuse it instead of creating a new instance
            mainForm.WindowState = FormWindowState.Normal; // Ensure the form is not minimized
            mainForm.Location = this.Location; // Set the location to be the same as the BackForm
            mainForm.Show(); // Show the MainRezeptForm
            mainForm.BringToFront(); // Bring MainRezeptForm to the front
            mainForm.Activate(); // Activate MainRezeptForm

            this.Close(); // Close the BackForm

        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
