namespace MinecraftBlockIndex
{
    partial class UpdateViewBlockForm
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
            boxUpdateBlock = new GroupBox();
            checkBoxIsTransparent = new CheckBox();
            checkBoxIsFull = new CheckBox();
            lblName = new Label();
            checkBoxIsBurnable = new CheckBox();
            txtUpdateBlock = new TextBox();
            checkBoxEmitsLight = new CheckBox();
            btnSave = new Button();
            btnExit = new Button();
            boxUpdateBlock.SuspendLayout();
            SuspendLayout();
            // 
            // boxUpdateBlock
            // 
            boxUpdateBlock.Controls.Add(checkBoxIsTransparent);
            boxUpdateBlock.Controls.Add(checkBoxIsFull);
            boxUpdateBlock.Controls.Add(lblName);
            boxUpdateBlock.Controls.Add(checkBoxIsBurnable);
            boxUpdateBlock.Controls.Add(txtUpdateBlock);
            boxUpdateBlock.Controls.Add(checkBoxEmitsLight);
            boxUpdateBlock.Location = new Point(12, 28);
            boxUpdateBlock.Name = "boxUpdateBlock";
            boxUpdateBlock.Size = new Size(241, 183);
            boxUpdateBlock.TabIndex = 4;
            boxUpdateBlock.TabStop = false;
            boxUpdateBlock.Text = "Updating A Block";
            // 
            // checkBoxIsTransparent
            // 
            checkBoxIsTransparent.AutoSize = true;
            checkBoxIsTransparent.Location = new Point(21, 152);
            checkBoxIsTransparent.Name = "checkBoxIsTransparent";
            checkBoxIsTransparent.Size = new Size(112, 19);
            checkBoxIsTransparent.TabIndex = 8;
            checkBoxIsTransparent.Text = "Is it transparent?";
            checkBoxIsTransparent.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsFull
            // 
            checkBoxIsFull.AutoSize = true;
            checkBoxIsFull.Location = new Point(21, 127);
            checkBoxIsFull.Name = "checkBoxIsFull";
            checkBoxIsFull.Size = new Size(82, 19);
            checkBoxIsFull.TabIndex = 7;
            checkBoxIsFull.Text = "Full Block?";
            checkBoxIsFull.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(21, 30);
            lblName.Name = "lblName";
            lblName.Size = new Size(71, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Block Name";
            // 
            // checkBoxIsBurnable
            // 
            checkBoxIsBurnable.AutoSize = true;
            checkBoxIsBurnable.Location = new Point(21, 102);
            checkBoxIsBurnable.Name = "checkBoxIsBurnable";
            checkBoxIsBurnable.Size = new Size(78, 19);
            checkBoxIsBurnable.TabIndex = 6;
            checkBoxIsBurnable.Text = "Burnable?";
            checkBoxIsBurnable.UseVisualStyleBackColor = true;
            // 
            // txtUpdateBlock
            // 
            txtUpdateBlock.Location = new Point(122, 22);
            txtUpdateBlock.Name = "txtUpdateBlock";
            txtUpdateBlock.Size = new Size(100, 23);
            txtUpdateBlock.TabIndex = 5;
            // 
            // checkBoxEmitsLight
            // 
            checkBoxEmitsLight.AutoSize = true;
            checkBoxEmitsLight.Location = new Point(21, 77);
            checkBoxEmitsLight.Name = "checkBoxEmitsLight";
            checkBoxEmitsLight.Size = new Size(90, 19);
            checkBoxEmitsLight.TabIndex = 5;
            checkBoxEmitsLight.Text = "Emits Light?";
            checkBoxEmitsLight.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 217);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 41);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(157, 217);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(99, 36);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // UpdateViewBlockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 279);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(boxUpdateBlock);
            Name = "UpdateViewBlockForm";
            Text = "UpdateViewBlockForm";
            Load += CreateViewBlockForm_Load;
            boxUpdateBlock.ResumeLayout(false);
            boxUpdateBlock.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox boxUpdateBlock;
        private Label lblName;
        private TextBox txtUpdateBlock;
        private CheckBox checkBoxEmitsLight;
        private CheckBox checkBoxIsBurnable;
        private CheckBox checkBoxIsFull;
        private CheckBox checkBoxIsTransparent;
        private Button btnSave;
        private Button btnExit;
    }
}