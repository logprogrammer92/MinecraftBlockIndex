namespace MinecraftBlockIndex
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
            btnAddBlock = new Button();
            btnExit = new Button();
            btnRemoveBlock = new Button();
            btnHelp = new Button();
            comboBoxBlock = new ComboBox();
            btnViewBlock = new Button();
            groupBoxBlockView = new GroupBox();
            lblBlockName = new Label();
            groupBoxBlockView.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddBlock
            // 
            btnAddBlock.Location = new Point(12, 115);
            btnAddBlock.Name = "btnAddBlock";
            btnAddBlock.Size = new Size(160, 71);
            btnAddBlock.TabIndex = 0;
            btnAddBlock.Text = "Add A Block";
            btnAddBlock.UseVisualStyleBackColor = true;
            btnAddBlock.Click += btnAddBlock_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(362, 153);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(132, 33);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRemoveBlock
            // 
            btnRemoveBlock.Location = new Point(178, 115);
            btnRemoveBlock.Name = "btnRemoveBlock";
            btnRemoveBlock.Size = new Size(178, 71);
            btnRemoveBlock.TabIndex = 2;
            btnRemoveBlock.Text = "Remove A Block";
            btnRemoveBlock.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            btnHelp.Location = new Point(362, 115);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(132, 32);
            btnHelp.TabIndex = 3;
            btnHelp.Text = "Guide";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // comboBoxBlock
            // 
            comboBoxBlock.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBlock.FormattingEnabled = true;
            comboBoxBlock.Location = new Point(166, 15);
            comboBoxBlock.Name = "comboBoxBlock";
            comboBoxBlock.Size = new Size(146, 23);
            comboBoxBlock.TabIndex = 4;
            comboBoxBlock.SelectedIndexChanged += comboBoxBlock_SelectedIndexChanged;
            // 
            // btnViewBlock
            // 
            btnViewBlock.Enabled = false;
            btnViewBlock.Location = new Point(166, 59);
            btnViewBlock.Name = "btnViewBlock";
            btnViewBlock.Size = new Size(126, 23);
            btnViewBlock.TabIndex = 5;
            btnViewBlock.Text = "View Block";
            btnViewBlock.UseVisualStyleBackColor = true;
            btnViewBlock.Click += btnViewBlock_Click;
            // 
            // groupBoxBlockView
            // 
            groupBoxBlockView.Controls.Add(lblBlockName);
            groupBoxBlockView.Controls.Add(comboBoxBlock);
            groupBoxBlockView.Controls.Add(btnViewBlock);
            groupBoxBlockView.Location = new Point(12, 21);
            groupBoxBlockView.Name = "groupBoxBlockView";
            groupBoxBlockView.Size = new Size(482, 88);
            groupBoxBlockView.TabIndex = 6;
            groupBoxBlockView.TabStop = false;
            groupBoxBlockView.Text = "Minecraft Block Info";
            // 
            // lblBlockName
            // 
            lblBlockName.AutoSize = true;
            lblBlockName.Location = new Point(89, 19);
            lblBlockName.Name = "lblBlockName";
            lblBlockName.Size = new Size(71, 15);
            lblBlockName.TabIndex = 6;
            lblBlockName.Text = "Block Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 319);
            Controls.Add(groupBoxBlockView);
            Controls.Add(btnHelp);
            Controls.Add(btnRemoveBlock);
            Controls.Add(btnExit);
            Controls.Add(btnAddBlock);
            Name = "Form1";
            Text = "Minecraft Block Index";
            Load += Form1_Load;
            groupBoxBlockView.ResumeLayout(false);
            groupBoxBlockView.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddBlock;
        private Button btnExit;
        private Button btnRemoveBlock;
        private Button btnHelp;
        private ComboBox comboBoxBlock;
        private Button btnViewBlock;
        private GroupBox groupBoxBlockView;
        private Label lblBlockName;
    }
}
