﻿namespace CookBook.UI
{
    partial class RecipesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NameLbl = new Label();
            TypeLbl = new Label();
            DescriptionLbl = new Label();
            ImageLbl = new Label();
            AddRecipeBtn = new Button();
            ClearAllFieldsBtn = new Button();
            NameTxt = new TextBox();
            RecipeTypesCbx = new ComboBox();
            AddRecipeTypeBtn = new Button();
            DescriptionTxt = new RichTextBox();
            RecipePictureBox = new PictureBox();
            RecipesFilterCbx = new ComboBox();
            RecipesGrid = new DataGridView();
            EditRecipeButton = new Button();
            LeftPanel = new Panel();
            RightPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).BeginInit();
            RightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.BackColor = Color.FromArgb(32, 45, 64);
            NameLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            NameLbl.ForeColor = Color.White;
            NameLbl.Location = new Point(794, 38);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(77, 30);
            NameLbl.TabIndex = 0;
            NameLbl.Text = "Name:";
            // 
            // TypeLbl
            // 
            TypeLbl.AutoSize = true;
            TypeLbl.BackColor = Color.FromArgb(32, 45, 64);
            TypeLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            TypeLbl.ForeColor = Color.White;
            TypeLbl.Location = new Point(794, 97);
            TypeLbl.Name = "TypeLbl";
            TypeLbl.Size = new Size(65, 30);
            TypeLbl.TabIndex = 1;
            TypeLbl.Text = "Type:";
            // 
            // DescriptionLbl
            // 
            DescriptionLbl.AutoSize = true;
            DescriptionLbl.BackColor = Color.FromArgb(32, 45, 64);
            DescriptionLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            DescriptionLbl.ForeColor = Color.White;
            DescriptionLbl.Location = new Point(794, 181);
            DescriptionLbl.Name = "DescriptionLbl";
            DescriptionLbl.Size = new Size(131, 30);
            DescriptionLbl.TabIndex = 2;
            DescriptionLbl.Text = "Description:";
            // 
            // ImageLbl
            // 
            ImageLbl.AutoSize = true;
            ImageLbl.BackColor = Color.FromArgb(32, 45, 64);
            ImageLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            ImageLbl.ForeColor = Color.White;
            ImageLbl.Location = new Point(794, 320);
            ImageLbl.Name = "ImageLbl";
            ImageLbl.Size = new Size(80, 30);
            ImageLbl.TabIndex = 3;
            ImageLbl.Text = "Image:";
            // 
            // AddRecipeBtn
            // 
            AddRecipeBtn.FlatAppearance.BorderSize = 0;
            AddRecipeBtn.FlatStyle = FlatStyle.Flat;
            AddRecipeBtn.Location = new Point(12, 454);
            AddRecipeBtn.Name = "AddRecipeBtn";
            AddRecipeBtn.Size = new Size(398, 50);
            AddRecipeBtn.TabIndex = 4;
            AddRecipeBtn.Text = "Add recipe";
            AddRecipeBtn.UseVisualStyleBackColor = true;
            AddRecipeBtn.Click += AddRecipeBtn_Click;
            // 
            // ClearAllFieldsBtn
            // 
            ClearAllFieldsBtn.FlatAppearance.BorderSize = 0;
            ClearAllFieldsBtn.FlatStyle = FlatStyle.Flat;
            ClearAllFieldsBtn.Location = new Point(794, 517);
            ClearAllFieldsBtn.Name = "ClearAllFieldsBtn";
            ClearAllFieldsBtn.Size = new Size(398, 50);
            ClearAllFieldsBtn.TabIndex = 6;
            ClearAllFieldsBtn.Text = "Clear all fields";
            ClearAllFieldsBtn.UseVisualStyleBackColor = true;
            ClearAllFieldsBtn.Click += ClearAllFieldsBtn_Click;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(917, 38);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(275, 35);
            NameTxt.TabIndex = 7;
            // 
            // RecipeTypesCbx
            // 
            RecipeTypesCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            RecipeTypesCbx.FormattingEnabled = true;
            RecipeTypesCbx.Location = new Point(917, 89);
            RecipeTypesCbx.Name = "RecipeTypesCbx";
            RecipeTypesCbx.Size = new Size(154, 38);
            RecipeTypesCbx.TabIndex = 8;
            // 
            // AddRecipeTypeBtn
            // 
            AddRecipeTypeBtn.FlatAppearance.BorderSize = 0;
            AddRecipeTypeBtn.FlatStyle = FlatStyle.Flat;
            AddRecipeTypeBtn.Location = new Point(1086, 89);
            AddRecipeTypeBtn.Name = "AddRecipeTypeBtn";
            AddRecipeTypeBtn.Size = new Size(106, 38);
            AddRecipeTypeBtn.TabIndex = 9;
            AddRecipeTypeBtn.Text = "Add";
            AddRecipeTypeBtn.UseVisualStyleBackColor = true;
            AddRecipeTypeBtn.Click += AddRecipeTypeBtn_Click;
            // 
            // DescriptionTxt
            // 
            DescriptionTxt.Location = new Point(917, 150);
            DescriptionTxt.Name = "DescriptionTxt";
            DescriptionTxt.Size = new Size(275, 96);
            DescriptionTxt.TabIndex = 10;
            DescriptionTxt.Text = "";
            // 
            // RecipePictureBox
            // 
            RecipePictureBox.Location = new Point(917, 275);
            RecipePictureBox.Name = "RecipePictureBox";
            RecipePictureBox.Size = new Size(275, 153);
            RecipePictureBox.TabIndex = 11;
            RecipePictureBox.TabStop = false;
            RecipePictureBox.Click += RecipePictureBox_Click;
            // 
            // RecipesFilterCbx
            // 
            RecipesFilterCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            RecipesFilterCbx.FormattingEnabled = true;
            RecipesFilterCbx.Location = new Point(22, 35);
            RecipesFilterCbx.Name = "RecipesFilterCbx";
            RecipesFilterCbx.Size = new Size(748, 38);
            RecipesFilterCbx.TabIndex = 12;
            RecipesFilterCbx.SelectedIndexChanged += RecipesFilterCbx_SelectedIndexChanged;
            // 
            // RecipesGrid
            // 
            RecipesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RecipesGrid.Location = new Point(22, 97);
            RecipesGrid.Name = "RecipesGrid";
            RecipesGrid.Size = new Size(748, 465);
            RecipesGrid.TabIndex = 13;
            RecipesGrid.CellClick += RecipesGrid_CellClick;
            // 
            // EditRecipeButton
            // 
            EditRecipeButton.FlatAppearance.BorderSize = 0;
            EditRecipeButton.FlatStyle = FlatStyle.Flat;
            EditRecipeButton.Location = new Point(12, 454);
            EditRecipeButton.Name = "EditRecipeButton";
            EditRecipeButton.Size = new Size(398, 50);
            EditRecipeButton.TabIndex = 14;
            EditRecipeButton.Text = "Edit recipe";
            EditRecipeButton.UseVisualStyleBackColor = true;
            EditRecipeButton.Click += EditRecipeButton_Click;
            // 
            // LeftPanel
            // 
            LeftPanel.BackColor = Color.FromArgb(45, 66, 91);
            LeftPanel.Dock = DockStyle.Left;
            LeftPanel.Location = new Point(0, 0);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(782, 585);
            LeftPanel.TabIndex = 15;
            // 
            // RightPanel
            // 
            RightPanel.BackColor = Color.FromArgb(32, 45, 64);
            RightPanel.Controls.Add(EditRecipeButton);
            RightPanel.Controls.Add(AddRecipeBtn);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(782, 0);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(439, 585);
            RightPanel.TabIndex = 16;
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 585);
            Controls.Add(RecipesGrid);
            Controls.Add(RecipesFilterCbx);
            Controls.Add(RecipePictureBox);
            Controls.Add(DescriptionTxt);
            Controls.Add(AddRecipeTypeBtn);
            Controls.Add(RecipeTypesCbx);
            Controls.Add(NameTxt);
            Controls.Add(ClearAllFieldsBtn);
            Controls.Add(ImageLbl);
            Controls.Add(DescriptionLbl);
            Controls.Add(TypeLbl);
            Controls.Add(NameLbl);
            Controls.Add(RightPanel);
            Controls.Add(LeftPanel);
            Font = new Font("Segoe UI", 15.75F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "RecipesForm";
            Text = "RecipesForm";
            Load += RecipesForm_Load;
            ((System.ComponentModel.ISupportInitialize)RecipePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)RecipesGrid).EndInit();
            RightPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLbl;
        private Label TypeLbl;
        private Label DescriptionLbl;
        private Label ImageLbl;
        private Button AddRecipeBtn;
        private Button ClearAllFieldsBtn;
        private TextBox NameTxt;
        private ComboBox RecipeTypesCbx;
        private Button AddRecipeTypeBtn;
        private RichTextBox DescriptionTxt;
        private PictureBox RecipePictureBox;
        private ComboBox RecipesFilterCbx;
        private DataGridView RecipesGrid;
        private Button EditRecipeButton;
        private Panel LeftPanel;
        private Panel RightPanel;
    }
}