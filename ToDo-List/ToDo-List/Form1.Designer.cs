namespace ToDo_List
{
    partial class Form1
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
            checkBox = new CheckedListBox();
            textBox1 = new TextBox();
            addButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            SuspendLayout();
            // 
            // checkBox
            // 
            checkBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            checkBox.FormattingEnabled = true;
            checkBox.Items.AddRange(new object[] { "Add your ToDo's here" });
            checkBox.Location = new Point(12, 12);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(776, 378);
            checkBox.TabIndex = 0;
            checkBox.SelectedIndexChanged += checkBox_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(12, 411);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(576, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.Location = new Point(694, 411);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 27);
            addButton.TabIndex = 2;
            addButton.Text = "Add Item";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.Location = new Point(594, 411);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 27);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.BackColor = Color.SpringGreen;
            saveButton.Location = new Point(694, 12);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 27);
            saveButton.TabIndex = 4;
            saveButton.Text = "Save List";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(textBox1);
            Controls.Add(checkBox);
            Name = "Form1";
            Text = "ToDo-List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkBox;
        private TextBox textBox1;
        private Button addButton;
        private Button deleteButton;
        private Button saveButton;
    }
}
