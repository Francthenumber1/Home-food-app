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


            


        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void lblHomeFood_Click(object sender, EventArgs e)
        {

        }
    }
}
