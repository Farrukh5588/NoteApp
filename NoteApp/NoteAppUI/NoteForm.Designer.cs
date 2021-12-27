
namespace NoteAppUI
{
    partial class NoteForm
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.ModifiedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NoteCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(407, 372);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(60, 20);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(343, 372);
            this.OKButton.Margin = new System.Windows.Forms.Padding(2);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(60, 20);
            this.OKButton.TabIndex = 20;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.Location = new System.Drawing.Point(8, 74);
            this.TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(460, 296);
            this.TextBox.TabIndex = 19;
            // 
            // ModifiedTimePicker
            // 
            this.ModifiedTimePicker.Enabled = false;
            this.ModifiedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifiedTimePicker.Location = new System.Drawing.Point(235, 51);
            this.ModifiedTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.ModifiedTimePicker.Name = "ModifiedTimePicker";
            this.ModifiedTimePicker.Size = new System.Drawing.Size(92, 20);
            this.ModifiedTimePicker.TabIndex = 18;
            // 
            // CreatedTimePicker
            // 
            this.CreatedTimePicker.Enabled = false;
            this.CreatedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreatedTimePicker.Location = new System.Drawing.Point(64, 51);
            this.CreatedTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.CreatedTimePicker.Name = "CreatedTimePicker";
            this.CreatedTimePicker.Size = new System.Drawing.Size(105, 20);
            this.CreatedTimePicker.TabIndex = 17;
            // 
            // NoteCategoryComboBox
            // 
            this.NoteCategoryComboBox.FormattingEnabled = true;
            this.NoteCategoryComboBox.Location = new System.Drawing.Point(64, 27);
            this.NoteCategoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.NoteCategoryComboBox.Name = "NoteCategoryComboBox";
            this.NoteCategoryComboBox.Size = new System.Drawing.Size(105, 21);
            this.NoteCategoryComboBox.TabIndex = 16;
            this.NoteCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.NoteCategoryComboBox_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(64, 4);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(404, 20);
            this.NameTextBox.TabIndex = 15;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Location = new System.Drawing.Point(182, 54);
            this.ModifiedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(50, 13);
            this.ModifiedLabel.TabIndex = 14;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(8, 54);
            this.CreatedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 13;
            this.CreatedLabel.Text = "Created:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(8, 30);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 12;
            this.CategoryLabel.Text = "Category:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(8, 7);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(30, 13);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Title:";
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 396);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.ModifiedTimePicker);
            this.Controls.Add(this.CreatedTimePicker);
            this.Controls.Add(this.NoteCategoryComboBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ModifiedLabel);
            this.Controls.Add(this.CreatedLabel);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.NameLabel);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "NoteForm";
            this.ShowIcon = false;
            this.Text = "Add/Edit Note";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.DateTimePicker ModifiedTimePicker;
        private System.Windows.Forms.DateTimePicker CreatedTimePicker;
        private System.Windows.Forms.ComboBox NoteCategoryComboBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}