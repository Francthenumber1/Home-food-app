using System.Drawing;
using System.Windows.Forms;

namespace HomeFood
{
    partial class Rezeptsuchen_und_filtern
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.filtersGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.keywordTextBox = new System.Windows.Forms.TextBox();
            this.recipesTypeCombBox = new System.Windows.Forms.ComboBox();
            this.diateryPrefCombBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.applySearchBtn = new System.Windows.Forms.Button();
            this.resetFiltersBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.minCaloryTrackbar = new System.Windows.Forms.TrackBar();
            this.minTrackBarValueTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.maxCaloryTrackbar = new System.Windows.Forms.TrackBar();
            this.maxTrackBarValueTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dishesDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.display_textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.filtersGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minCaloryTrackbar)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCaloryTrackbar)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.filtersGroupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.05967F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.0358F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1294, 791);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // filtersGroupBox
            // 
            this.filtersGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.filtersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filtersGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtersGroupBox.Location = new System.Drawing.Point(3, 82);
            this.filtersGroupBox.Name = "filtersGroupBox";
            this.filtersGroupBox.Size = new System.Drawing.Size(1288, 192);
            this.filtersGroupBox.TabIndex = 0;
            this.filtersGroupBox.TabStop = false;
            this.filtersGroupBox.Text = "Filters";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.keywordTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.recipesTypeCombBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.diateryPrefCombBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1282, 162);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(644, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(635, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Typ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keyword";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(635, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kalorienwerte";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(644, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(635, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Diätetische Präferenz";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // keywordTextBox
            // 
            this.keywordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keywordTextBox.Location = new System.Drawing.Point(3, 27);
            this.keywordTextBox.Name = "keywordTextBox";
            this.keywordTextBox.Size = new System.Drawing.Size(635, 31);
            this.keywordTextBox.TabIndex = 4;
            // 
            // recipesTypeCombBox
            // 
            this.recipesTypeCombBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recipesTypeCombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recipesTypeCombBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipesTypeCombBox.FormattingEnabled = true;
            this.recipesTypeCombBox.Location = new System.Drawing.Point(644, 27);
            this.recipesTypeCombBox.Name = "recipesTypeCombBox";
            this.recipesTypeCombBox.Size = new System.Drawing.Size(635, 26);
            this.recipesTypeCombBox.TabIndex = 5;
            // 
            // diateryPrefCombBox
            // 
            this.diateryPrefCombBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.diateryPrefCombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.diateryPrefCombBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diateryPrefCombBox.FormattingEnabled = true;
            this.diateryPrefCombBox.Location = new System.Drawing.Point(644, 91);
            this.diateryPrefCombBox.Name = "diateryPrefCombBox";
            this.diateryPrefCombBox.Size = new System.Drawing.Size(635, 26);
            this.diateryPrefCombBox.TabIndex = 6;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.applySearchBtn, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.resetFiltersBtn, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(644, 131);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(635, 28);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // applySearchBtn
            // 
            this.applySearchBtn.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.applySearchBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.applySearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.applySearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applySearchBtn.Location = new System.Drawing.Point(3, 3);
            this.applySearchBtn.Name = "applySearchBtn";
            this.applySearchBtn.Size = new System.Drawing.Size(311, 22);
            this.applySearchBtn.TabIndex = 8;
            this.applySearchBtn.Text = "Suchen";
            this.applySearchBtn.UseVisualStyleBackColor = false;
            this.applySearchBtn.Click += new System.EventHandler(this.applySearchBtn_Click);
            // 
            // resetFiltersBtn
            // 
            this.resetFiltersBtn.BackColor = System.Drawing.Color.Crimson;
            this.resetFiltersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetFiltersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetFiltersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetFiltersBtn.Location = new System.Drawing.Point(320, 3);
            this.resetFiltersBtn.Name = "resetFiltersBtn";
            this.resetFiltersBtn.Size = new System.Drawing.Size(312, 22);
            this.resetFiltersBtn.TabIndex = 9;
            this.resetFiltersBtn.Text = "Reset";
            this.resetFiltersBtn.UseVisualStyleBackColor = false;
            this.resetFiltersBtn.Click += new System.EventHandler(this.resetFiltersBtn_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Controls.Add(this.minCaloryTrackbar, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.minTrackBarValueTextBox, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 91);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(635, 34);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // minCaloryTrackbar
            // 
            this.minCaloryTrackbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minCaloryTrackbar.Location = new System.Drawing.Point(3, 3);
            this.minCaloryTrackbar.Maximum = 2500;
            this.minCaloryTrackbar.Minimum = 1;
            this.minCaloryTrackbar.Name = "minCaloryTrackbar";
            this.minCaloryTrackbar.Size = new System.Drawing.Size(565, 28);
            this.minCaloryTrackbar.TabIndex = 7;
            this.minCaloryTrackbar.Value = 1;
            this.minCaloryTrackbar.ValueChanged += new System.EventHandler(this.minCaloryTrackbar_ValueChanged);
            // 
            // minTrackBarValueTextBox
            // 
            this.minTrackBarValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minTrackBarValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minTrackBarValueTextBox.Location = new System.Drawing.Point(574, 3);
            this.minTrackBarValueTextBox.Name = "minTrackBarValueTextBox";
            this.minTrackBarValueTextBox.ReadOnly = true;
            this.minTrackBarValueTextBox.Size = new System.Drawing.Size(58, 24);
            this.minTrackBarValueTextBox.TabIndex = 8;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.Controls.Add(this.maxCaloryTrackbar, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.maxTrackBarValueTextBox, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 131);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(635, 28);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // maxCaloryTrackbar
            // 
            this.maxCaloryTrackbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxCaloryTrackbar.Location = new System.Drawing.Point(3, 3);
            this.maxCaloryTrackbar.Name = "maxCaloryTrackbar";
            this.maxCaloryTrackbar.Size = new System.Drawing.Size(565, 22);
            this.maxCaloryTrackbar.TabIndex = 0;
            this.maxCaloryTrackbar.ValueChanged += new System.EventHandler(this.maxCaloryTrackbar_ValueChanged);
            // 
            // maxTrackBarValueTextBox
            // 
            this.maxTrackBarValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxTrackBarValueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxTrackBarValueTextBox.Location = new System.Drawing.Point(574, 3);
            this.maxTrackBarValueTextBox.Name = "maxTrackBarValueTextBox";
            this.maxTrackBarValueTextBox.ReadOnly = true;
            this.maxTrackBarValueTextBox.Size = new System.Drawing.Size(58, 22);
            this.maxTrackBarValueTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1288, 79);
            this.label5.TabIndex = 1;
            this.label5.Text = "Übersicht aller Gerichte";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.dishesDataGridView, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 280);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1288, 508);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // dishesDataGridView
            // 
            this.dishesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dishesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dishesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dishesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dishesDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dishesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.dishesDataGridView.Name = "dishesDataGridView";
            this.dishesDataGridView.Size = new System.Drawing.Size(960, 502);
            this.dishesDataGridView.TabIndex = 0;
            this.dishesDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dishesDataGridView_CellBeginEdit);
            this.dishesDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dishesDataGridView_CellEndEdit);
            this.dishesDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dishesDataGridView_CellEnter);
            this.dishesDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dishesDataGridView_CellFormatting);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.display_textBox1, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(969, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(316, 502);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // display_textBox1
            // 
            this.display_textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display_textBox1.Location = new System.Drawing.Point(3, 203);
            this.display_textBox1.Multiline = true;
            this.display_textBox1.Name = "display_textBox1";
            this.display_textBox1.Size = new System.Drawing.Size(310, 296);
            this.display_textBox1.TabIndex = 1;
            // 
            // Rezeptsuchen_und_filtern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1294, 791);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1294, 791);
            this.Name = "Rezeptsuchen_und_filtern";
            this.RightToLeftLayout = true;
            this.Text = "Übersicht aller Gerichte";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.filtersGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minCaloryTrackbar)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCaloryTrackbar)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox filtersGroupBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox keywordTextBox;
        private ComboBox recipesTypeCombBox;
        private ComboBox diateryPrefCombBox;
        private TrackBar minCaloryTrackbar;
        private Button applySearchBtn;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView dishesDataGridView;
        private TableLayoutPanel tableLayoutPanel4;
        private Button resetFiltersBtn;
        private TableLayoutPanel tableLayoutPanel5;
        private TextBox minTrackBarValueTextBox;
        private TableLayoutPanel tableLayoutPanel6;
        private TrackBar maxCaloryTrackbar;
        private TextBox maxTrackBarValueTextBox;
        private TableLayoutPanel tableLayoutPanel7;
        private PictureBox pictureBox1;
        private TextBox display_textBox1;
    }
}