using System.Drawing;
using System.Windows.Forms;

namespace HomeFood
{
    partial class Rezepte_hinzufügen
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            zutatenDataGridView = new DataGridView();
            label2 = new Label();
            dtp_combobox = new ComboBox();
            Rezepttype_comboBox = new ComboBox();
            image_url_txt = new TextBox();
            anweisungen_txt = new TextBox();
            Naehrwerte_txt = new TextBox();
            Portionen_txt = new TextBox();
            Rezept_name_txt = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            Zutat_name_Txt = new TextBox();
            Kalorien_pro_100g_Txt = new TextBox();
            Kohlenhydrate_Txt = new TextBox();
            Proteine_Txt = new TextBox();
            Zutat_name = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            Fette_Txt = new TextBox();
            label9 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)zutatenDataGridView).BeginInit();
            SuspendLayout();

            // 
            // button1
            // 
            button1.Location = new Point(476, 700);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(296, 38);
            button1.TabIndex = 35;
            button1.Text = "Insert_Everything";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // zutatenDataGridView
            // 
            zutatenDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            zutatenDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            zutatenDataGridView.Location = new Point(1100, 152);
            zutatenDataGridView.Margin = new Padding(4, 5, 4, 5);
            zutatenDataGridView.Name = "zutatenDataGridView";
            zutatenDataGridView.RowHeadersWidth = 62;
            zutatenDataGridView.Size = new Size(791, 178);
            zutatenDataGridView.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(817, 100);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(768, 25);
            label2.TabIndex = 33;
            label2.Text = "Zutaten to be inserted in the order Zutat_name Kalorien_pro_100g Kohlenhydrate proteine fette ";
            // 
            // dtp_combobox
            // 
            dtp_combobox.FormattingEnabled = true;
            dtp_combobox.Location = new Point(253, 400);
            dtp_combobox.Margin = new Padding(4, 5, 4, 5);
            dtp_combobox.Name = "dtp_combobox";
            dtp_combobox.Size = new Size(141, 33);
            dtp_combobox.TabIndex = 32;
            // 
            // Rezepttype_comboBox
            // 
            Rezepttype_comboBox.FormattingEnabled = true;
            Rezepttype_comboBox.Location = new Point(253, 323);
            Rezepttype_comboBox.Margin = new Padding(4, 5, 4, 5);
            Rezepttype_comboBox.Name = "Rezepttype_comboBox";
            Rezepttype_comboBox.Size = new Size(141, 33);
            Rezepttype_comboBox.TabIndex = 31;
            // 
            // image_url_txt
            // 
            image_url_txt.Location = new Point(253, 553);
            image_url_txt.Margin = new Padding(4, 5, 4, 5);
            image_url_txt.Name = "image_url_txt";
            image_url_txt.Size = new Size(141, 31);
            image_url_txt.TabIndex = 30;
            // 
            // anweisungen_txt
            // 
            anweisungen_txt.Location = new Point(253, 477);
            anweisungen_txt.Margin = new Padding(4, 5, 4, 5);
            anweisungen_txt.Multiline = true;
            anweisungen_txt.Name = "anweisungen_txt";
            anweisungen_txt.Size = new Size(141, 36);
            anweisungen_txt.TabIndex = 29;
            // 
            // Naehrwerte_txt
            // 
            Naehrwerte_txt.Location = new Point(253, 247);
            Naehrwerte_txt.Margin = new Padding(4, 5, 4, 5);
            Naehrwerte_txt.Name = "Naehrwerte_txt";
            Naehrwerte_txt.Size = new Size(141, 31);
            Naehrwerte_txt.TabIndex = 28;
            // 
            // Portionen_txt
            // 
            Portionen_txt.Location = new Point(253, 170);
            Portionen_txt.Margin = new Padding(4, 5, 4, 5);
            Portionen_txt.Name = "Portionen_txt";
            Portionen_txt.Size = new Size(141, 31);
            Portionen_txt.TabIndex = 27;
            // 
            // Rezept_name_txt
            // 
            Rezept_name_txt.Location = new Point(253, 93);
            Rezept_name_txt.Margin = new Padding(4, 5, 4, 5);
            Rezept_name_txt.Name = "Rezept_name_txt";
            Rezept_name_txt.Size = new Size(141, 31);
            Rezept_name_txt.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 560);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 25;
            label8.Text = "image_url";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 483);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(118, 25);
            label7.TabIndex = 24;
            label7.Text = "Anweisungen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 407);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(166, 25);
            label6.TabIndex = 23;
            label6.Text = "Dietarypreferences";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 330);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 22;
            label5.Text = "Rezepttype";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 253);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 21;
            label4.Text = "Naerhwerte";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 177);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 20;
            label3.Text = "Portionen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 100);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 19;
            label1.Text = "Rezept_name";
            // 
            // Zutat_name_Txt
            // 
            Zutat_name_Txt.Location = new Point(933, 160);
            Zutat_name_Txt.Margin = new Padding(4, 5, 4, 5);
            Zutat_name_Txt.Name = "Zutat_name_Txt";
            Zutat_name_Txt.Size = new Size(141, 31);
            Zutat_name_Txt.TabIndex = 36;
            // 
            // Kalorien_pro_100g_Txt
            // 
            Kalorien_pro_100g_Txt.Location = new Point(933, 237);
            Kalorien_pro_100g_Txt.Margin = new Padding(4, 5, 4, 5);
            Kalorien_pro_100g_Txt.Name = "Kalorien_pro_100g_Txt";
            Kalorien_pro_100g_Txt.Size = new Size(141, 31);
            Kalorien_pro_100g_Txt.TabIndex = 37;
            // 
            // Kohlenhydrate_Txt
            // 
            Kohlenhydrate_Txt.Location = new Point(933, 313);
            Kohlenhydrate_Txt.Margin = new Padding(4, 5, 4, 5);
            Kohlenhydrate_Txt.Name = "Kohlenhydrate_Txt";
            Kohlenhydrate_Txt.Size = new Size(141, 31);
            Kohlenhydrate_Txt.TabIndex = 38;
            // 
            // Proteine_Txt
            // 
            Proteine_Txt.Location = new Point(933, 390);
            Proteine_Txt.Margin = new Padding(4, 5, 4, 5);
            Proteine_Txt.Name = "Proteine_Txt";
            Proteine_Txt.Size = new Size(141, 31);
            Proteine_Txt.TabIndex = 39;
            // 
            // Zutat_name
            // 
            Zutat_name.AutoSize = true;
            Zutat_name.Location = new Point(760, 167);
            Zutat_name.Margin = new Padding(4, 0, 4, 0);
            Zutat_name.Name = "Zutat_name";
            Zutat_name.Size = new Size(104, 25);
            Zutat_name.TabIndex = 40;
            Zutat_name.Text = "Zutat_name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(760, 243);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(158, 25);
            label10.TabIndex = 41;
            label10.Text = "Kalorien_pro_100g";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(760, 320);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(126, 25);
            label11.TabIndex = 42;
            label11.Text = "Kohlenhydrate";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(760, 397);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(77, 25);
            label12.TabIndex = 43;
            label12.Text = "Proteine";
            // 
            // Fette_Txt
            // 
            Fette_Txt.Location = new Point(933, 460);
            Fette_Txt.Margin = new Padding(4, 5, 4, 5);
            Fette_Txt.Name = "Fette_Txt";
            Fette_Txt.Size = new Size(141, 31);
            Fette_Txt.TabIndex = 44;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(760, 473);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(51, 25);
            label9.TabIndex = 45;
            label9.Text = "Fette";
            // 
            // button2
            // 
            button2.Location = new Point(1031, 560);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(239, 38);
            button2.TabIndex = 46;
            button2.Text = "Insert_zutaten";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Rezepte_hinzufügen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1986, 988);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(Fette_Txt);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(Zutat_name);
            Controls.Add(Proteine_Txt);
            Controls.Add(Kohlenhydrate_Txt);
            Controls.Add(Kalorien_pro_100g_Txt);
            Controls.Add(Zutat_name_Txt);
            Controls.Add(button1);
            Controls.Add(zutatenDataGridView);
            Controls.Add(label2);
            Controls.Add(dtp_combobox);
            Controls.Add(Rezepttype_comboBox);
            Controls.Add(image_url_txt);
            Controls.Add(anweisungen_txt);
            Controls.Add(Naehrwerte_txt);
            Controls.Add(Portionen_txt);
            Controls.Add(Rezept_name_txt);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Rezepte_hinzufügen";
            Text = "Rezepte_hinzufügen";
            this.Load += new System.EventHandler(this.Rezepte_hinzufügen_Load);


            ((System.ComponentModel.ISupportInitialize)zutatenDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView zutatenDataGridView;
        private Label label2;
        private ComboBox dtp_combobox;
        private ComboBox Rezepttype_comboBox;
        private TextBox image_url_txt;
        private TextBox anweisungen_txt;
        private TextBox Naehrwerte_txt;
        private TextBox Portionen_txt;
        private TextBox Rezept_name_txt;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox Zutat_name_Txt;
        private TextBox Kalorien_pro_100g_Txt;
        private TextBox Kohlenhydrate_Txt;
        private TextBox Proteine_Txt;
        private Label Zutat_name;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox Fette_Txt;
        private Label label9;
        private Button button2;
    }

        
    
}