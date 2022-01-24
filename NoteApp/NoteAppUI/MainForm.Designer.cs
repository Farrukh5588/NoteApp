
namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.NoteCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveNoteButton = new System.Windows.Forms.Button();
            this.EditNoteButton = new System.Windows.Forms.Button();
            this.AddNoteButton = new System.Windows.Forms.Button();
            this.ShowCategoryLabel = new System.Windows.Forms.Label();
            this.NoteListBox = new System.Windows.Forms.ListBox();
            this.ModifiedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CreatedTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModifiedLabel = new System.Windows.Forms.Label();
            this.CreatedLabel = new System.Windows.Forms.Label();
            this.CategorySelectedLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.NoteNameLabel = new System.Windows.Forms.Label();
            this.NoteTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(652, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.NoteCategoryComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.RemoveNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.AddNoteButton);
            this.splitContainer1.Panel1.Controls.Add(this.ShowCategoryLabel);
            this.splitContainer1.Panel1.Controls.Add(this.NoteListBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ModifiedTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.CreatedTimePicker);
            this.splitContainer1.Panel2.Controls.Add(this.ModifiedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CreatedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CategorySelectedLabel);
            this.splitContainer1.Panel2.Controls.Add(this.CategoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.NoteNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.NoteTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(652, 416);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 1;
            // 
            // NoteCategoryComboBox
            // 
            this.NoteCategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteCategoryComboBox.FormattingEnabled = true;
            this.NoteCategoryComboBox.Location = new System.Drawing.Point(85, 7);
            this.NoteCategoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.NoteCategoryComboBox.Name = "NoteCategoryComboBox";
            this.NoteCategoryComboBox.Size = new System.Drawing.Size(129, 21);
            this.NoteCategoryComboBox.TabIndex = 11;
            this.NoteCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.NoteCategoryComboBox_SelectedIndexChanged);
            // 
            // RemoveNoteButton
            // 
            this.RemoveNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveNoteButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemoveNoteButton.FlatAppearance.BorderSize = 0;
            this.RemoveNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("RemoveNoteButton.Image")));
            this.RemoveNoteButton.Location = new System.Drawing.Point(73, 380);
            this.RemoveNoteButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveNoteButton.Name = "RemoveNoteButton";
            this.RemoveNoteButton.Size = new System.Drawing.Size(30, 30);
            this.RemoveNoteButton.TabIndex = 10;
            this.RemoveNoteButton.UseVisualStyleBackColor = true;
            this.RemoveNoteButton.Click += new System.EventHandler(this.RemoveNoteButton_Click);
            // 
            // EditNoteButton
            // 
            this.EditNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditNoteButton.FlatAppearance.BorderSize = 0;
            this.EditNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("EditNoteButton.Image")));
            this.EditNoteButton.Location = new System.Drawing.Point(39, 380);
            this.EditNoteButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditNoteButton.Name = "EditNoteButton";
            this.EditNoteButton.Size = new System.Drawing.Size(30, 30);
            this.EditNoteButton.TabIndex = 9;
            this.EditNoteButton.UseVisualStyleBackColor = true;
            this.EditNoteButton.Click += new System.EventHandler(this.EditNoteButton_Click);
            // 
            // AddNoteButton
            // 
            this.AddNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNoteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddNoteButton.FlatAppearance.BorderSize = 0;
            this.AddNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNoteButton.Image = ((System.Drawing.Image)(resources.GetObject("AddNoteButton.Image")));
            this.AddNoteButton.Location = new System.Drawing.Point(5, 380);
            this.AddNoteButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddNoteButton.Name = "AddNoteButton";
            this.AddNoteButton.Size = new System.Drawing.Size(30, 30);
            this.AddNoteButton.TabIndex = 8;
            this.AddNoteButton.UseVisualStyleBackColor = true;
            this.AddNoteButton.Click += new System.EventHandler(this.AddNoteButton_Click);
            // 
            // ShowCategoryLabel
            // 
            this.ShowCategoryLabel.AutoSize = true;
            this.ShowCategoryLabel.Location = new System.Drawing.Point(2, 10);
            this.ShowCategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ShowCategoryLabel.Name = "ShowCategoryLabel";
            this.ShowCategoryLabel.Size = new System.Drawing.Size(79, 13);
            this.ShowCategoryLabel.TabIndex = 7;
            this.ShowCategoryLabel.Text = "ShowCategory:";
            // 
            // NoteListBox
            // 
            this.NoteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteListBox.FormattingEnabled = true;
            this.NoteListBox.IntegralHeight = false;
            this.NoteListBox.Location = new System.Drawing.Point(2, 31);
            this.NoteListBox.Margin = new System.Windows.Forms.Padding(2);
            this.NoteListBox.Name = "NoteListBox";
            this.NoteListBox.Size = new System.Drawing.Size(212, 345);
            this.NoteListBox.TabIndex = 6;
            this.NoteListBox.SelectedIndexChanged += new System.EventHandler(this.NoteListBox_SelectedIndexChanged);
            this.NoteListBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NoteListBox_KeyUp);
            // 
            // ModifiedTimePicker
            // 
            this.ModifiedTimePicker.Enabled = false;
            this.ModifiedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ModifiedTimePicker.Location = new System.Drawing.Point(206, 61);
            this.ModifiedTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.ModifiedTimePicker.Name = "ModifiedTimePicker";
            this.ModifiedTimePicker.Size = new System.Drawing.Size(82, 20);
            this.ModifiedTimePicker.TabIndex = 15;
            // 
            // CreatedTimePicker
            // 
            this.CreatedTimePicker.Enabled = false;
            this.CreatedTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreatedTimePicker.Location = new System.Drawing.Point(57, 61);
            this.CreatedTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.CreatedTimePicker.Name = "CreatedTimePicker";
            this.CreatedTimePicker.Size = new System.Drawing.Size(81, 20);
            this.CreatedTimePicker.TabIndex = 14;
            // 
            // ModifiedLabel
            // 
            this.ModifiedLabel.AutoSize = true;
            this.ModifiedLabel.Location = new System.Drawing.Point(153, 64);
            this.ModifiedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModifiedLabel.Name = "ModifiedLabel";
            this.ModifiedLabel.Size = new System.Drawing.Size(50, 13);
            this.ModifiedLabel.TabIndex = 13;
            this.ModifiedLabel.Text = "Modified:";
            // 
            // CreatedLabel
            // 
            this.CreatedLabel.AutoSize = true;
            this.CreatedLabel.Location = new System.Drawing.Point(5, 64);
            this.CreatedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreatedLabel.Name = "CreatedLabel";
            this.CreatedLabel.Size = new System.Drawing.Size(47, 13);
            this.CreatedLabel.TabIndex = 12;
            this.CreatedLabel.Text = "Created:";
            // 
            // CategorySelectedLabel
            // 
            this.CategorySelectedLabel.AutoSize = true;
            this.CategorySelectedLabel.Location = new System.Drawing.Point(61, 45);
            this.CategorySelectedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategorySelectedLabel.Name = "CategorySelectedLabel";
            this.CategorySelectedLabel.Size = new System.Drawing.Size(117, 13);
            this.CategorySelectedLabel.TabIndex = 11;
            this.CategorySelectedLabel.Text = "CategorySelectedLabel";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(5, 45);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 10;
            this.CategoryLabel.Text = "Category:";
            // 
            // NoteNameLabel
            // 
            this.NoteNameLabel.AutoSize = true;
            this.NoteNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteNameLabel.Location = new System.Drawing.Point(6, 8);
            this.NoteNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NoteNameLabel.Name = "NoteNameLabel";
            this.NoteNameLabel.Size = new System.Drawing.Size(166, 25);
            this.NoteNameLabel.TabIndex = 9;
            this.NoteNameLabel.Text = "NoteNameLabel";
            // 
            // NoteTextBox
            // 
            this.NoteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoteTextBox.Location = new System.Drawing.Point(8, 89);
            this.NoteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NoteTextBox.Multiline = true;
            this.NoteTextBox.Name = "NoteTextBox";
            this.NoteTextBox.ReadOnly = true;
            this.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NoteTextBox.Size = new System.Drawing.Size(420, 318);
            this.NoteTextBox.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 440);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainForm";
            this.Text = "NoteApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox NoteCategoryComboBox;
        private System.Windows.Forms.Button RemoveNoteButton;
        private System.Windows.Forms.Button EditNoteButton;
        private System.Windows.Forms.Button AddNoteButton;
        private System.Windows.Forms.Label ShowCategoryLabel;
        private System.Windows.Forms.ListBox NoteListBox;
        private System.Windows.Forms.DateTimePicker ModifiedTimePicker;
        private System.Windows.Forms.DateTimePicker CreatedTimePicker;
        private System.Windows.Forms.Label ModifiedLabel;
        private System.Windows.Forms.Label CreatedLabel;
        private System.Windows.Forms.Label CategorySelectedLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label NoteNameLabel;
        private System.Windows.Forms.TextBox NoteTextBox;
    }
}

