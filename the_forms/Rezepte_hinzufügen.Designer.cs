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
            this.button1 = new System.Windows.Forms.Button();
            this.zutatenDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_combobox = new System.Windows.Forms.ComboBox();
            this.Rezepttype_comboBox = new System.Windows.Forms.ComboBox();
            this.image_url_txt = new System.Windows.Forms.TextBox();
            this.anweisungen_txt = new System.Windows.Forms.TextBox();
            this.Naehrwerte_txt = new System.Windows.Forms.TextBox();
            this.Portionen_txt = new System.Windows.Forms.TextBox();
            this.Rezept_name_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Zutat_name_Txt = new System.Windows.Forms.TextBox();
            this.Kalorien_pro_100g_Txt = new System.Windows.Forms.TextBox();
            this.Kohlenhydrate_Txt = new System.Windows.Forms.TextBox();
            this.Proteine_Txt = new System.Windows.Forms.TextBox();
            this.Zutat_name = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Fette_Txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zutatenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 24);
            this.button1.TabIndex = 35;
            this.button1.Text = "Insert_Everything";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // zutatenDataGridView
            // 
            this.zutatenDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.zutatenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zutatenDataGridView.Location = new System.Drawing.Point(880, 97);
            this.zutatenDataGridView.Name = "zutatenDataGridView";
            this.zutatenDataGridView.RowHeadersWidth = 62;
            this.zutatenDataGridView.Size = new System.Drawing.Size(540, 114);
            this.zutatenDataGridView.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(618, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Zutaten to be inserted in the order Zutat_name Kalorien_pro_100g Kohlenhydrate pr" +
    "oteine fette ";
            // 
            // dtp_combobox
            // 
            this.dtp_combobox.FormattingEnabled = true;
            this.dtp_combobox.Location = new System.Drawing.Point(202, 256);
            this.dtp_combobox.Name = "dtp_combobox";
            this.dtp_combobox.Size = new System.Drawing.Size(114, 24);
            this.dtp_combobox.TabIndex = 32;
            // 
            // Rezepttype_comboBox
            // 
            this.Rezepttype_comboBox.FormattingEnabled = true;
            this.Rezepttype_comboBox.Location = new System.Drawing.Point(202, 207);
            this.Rezepttype_comboBox.Name = "Rezepttype_comboBox";
            this.Rezepttype_comboBox.Size = new System.Drawing.Size(114, 24);
            this.Rezepttype_comboBox.TabIndex = 31;
            // 
            // image_url_txt
            // 
            this.image_url_txt.Location = new System.Drawing.Point(202, 354);
            this.image_url_txt.Name = "image_url_txt";
            this.image_url_txt.Size = new System.Drawing.Size(114, 22);
            this.image_url_txt.TabIndex = 30;
            // 
            // anweisungen_txt
            // 
            this.anweisungen_txt.Location = new System.Drawing.Point(202, 305);
            this.anweisungen_txt.Multiline = true;
            this.anweisungen_txt.Name = "anweisungen_txt";
            this.anweisungen_txt.Size = new System.Drawing.Size(114, 24);
            this.anweisungen_txt.TabIndex = 29;
            // 
            // Naehrwerte_txt
            // 
            this.Naehrwerte_txt.Location = new System.Drawing.Point(202, 158);
            this.Naehrwerte_txt.Name = "Naehrwerte_txt";
            this.Naehrwerte_txt.Size = new System.Drawing.Size(114, 22);
            this.Naehrwerte_txt.TabIndex = 28;
            // 
            // Portionen_txt
            // 
            this.Portionen_txt.Location = new System.Drawing.Point(202, 109);
            this.Portionen_txt.Name = "Portionen_txt";
            this.Portionen_txt.Size = new System.Drawing.Size(114, 22);
            this.Portionen_txt.TabIndex = 27;
            // 
            // Rezept_name_txt
            // 
            this.Rezept_name_txt.Location = new System.Drawing.Point(202, 60);
            this.Rezept_name_txt.Name = "Rezept_name_txt";
            this.Rezept_name_txt.Size = new System.Drawing.Size(114, 22);
            this.Rezept_name_txt.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "image_url";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Anweisungen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Dietarypreferences";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Rezepttype";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Naerhwerte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Portionen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Rezept_name";
            // 
            // Zutat_name_Txt
            // 
            this.Zutat_name_Txt.Location = new System.Drawing.Point(746, 102);
            this.Zutat_name_Txt.Name = "Zutat_name_Txt";
            this.Zutat_name_Txt.Size = new System.Drawing.Size(114, 22);
            this.Zutat_name_Txt.TabIndex = 36;
            // 
            // Kalorien_pro_100g_Txt
            // 
            this.Kalorien_pro_100g_Txt.Location = new System.Drawing.Point(746, 152);
            this.Kalorien_pro_100g_Txt.Name = "Kalorien_pro_100g_Txt";
            this.Kalorien_pro_100g_Txt.Size = new System.Drawing.Size(114, 22);
            this.Kalorien_pro_100g_Txt.TabIndex = 37;
            // 
            // Kohlenhydrate_Txt
            // 
            this.Kohlenhydrate_Txt.Location = new System.Drawing.Point(746, 200);
            this.Kohlenhydrate_Txt.Name = "Kohlenhydrate_Txt";
            this.Kohlenhydrate_Txt.Size = new System.Drawing.Size(114, 22);
            this.Kohlenhydrate_Txt.TabIndex = 38;
            // 
            // Proteine_Txt
            // 
            this.Proteine_Txt.Location = new System.Drawing.Point(746, 250);
            this.Proteine_Txt.Name = "Proteine_Txt";
            this.Proteine_Txt.Size = new System.Drawing.Size(114, 22);
            this.Proteine_Txt.TabIndex = 39;
            // 
            // Zutat_name
            // 
            this.Zutat_name.AutoSize = true;
            this.Zutat_name.Location = new System.Drawing.Point(608, 107);
            this.Zutat_name.Name = "Zutat_name";
            this.Zutat_name.Size = new System.Drawing.Size(84, 17);
            this.Zutat_name.TabIndex = 40;
            this.Zutat_name.Text = "Zutat_name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(608, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Kalorien_pro_100g";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(608, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 42;
            this.label11.Text = "Kohlenhydrate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(608, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 43;
            this.label12.Text = "Proteine";
            // 
            // Fette_Txt
            // 
            this.Fette_Txt.Location = new System.Drawing.Point(746, 294);
            this.Fette_Txt.Name = "Fette_Txt";
            this.Fette_Txt.Size = new System.Drawing.Size(114, 22);
            this.Fette_Txt.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(608, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 45;
            this.label9.Text = "Fette";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(825, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 24);
            this.button2.TabIndex = 46;
            this.button2.Text = "Insert_zutaten";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Rezepte_hinzufügen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 677);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Fette_Txt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Zutat_name);
            this.Controls.Add(this.Proteine_Txt);
            this.Controls.Add(this.Kohlenhydrate_Txt);
            this.Controls.Add(this.Kalorien_pro_100g_Txt);
            this.Controls.Add(this.Zutat_name_Txt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zutatenDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_combobox);
            this.Controls.Add(this.Rezepttype_comboBox);
            this.Controls.Add(this.image_url_txt);
            this.Controls.Add(this.anweisungen_txt);
            this.Controls.Add(this.Naehrwerte_txt);
            this.Controls.Add(this.Portionen_txt);
            this.Controls.Add(this.Rezept_name_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Rezepte_hinzufügen";
            this.Text = "Rezepte_hinzufügen";
            this.Load += new System.EventHandler(this.Rezepte_hinzufügen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zutatenDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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