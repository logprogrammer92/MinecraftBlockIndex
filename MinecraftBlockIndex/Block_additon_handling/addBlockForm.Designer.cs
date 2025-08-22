namespace MinecraftBlockIndex.Block_additon_handling
{
    partial class addBlockForm
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
            btnExit = new Button();
            btnSubmit = new Button();
            boxAddBlock = new GroupBox();
            btnNeedHelp = new Button();
            lblName = new Label();
            txtBlockName = new TextBox();
            checkIsLight = new CheckBox();
            checkIsBurnable = new CheckBox();
            checkIsFull = new CheckBox();
            checkIsTransparent = new CheckBox();
            boxAddBlock.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(157, 201);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(83, 45);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(12, 201);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(139, 45);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Enter";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // boxAddBlock
            // 
            boxAddBlock.Controls.Add(checkIsTransparent);
            boxAddBlock.Controls.Add(checkIsFull);
            boxAddBlock.Controls.Add(checkIsBurnable);
            boxAddBlock.Controls.Add(checkIsLight);
            boxAddBlock.Controls.Add(btnNeedHelp);
            boxAddBlock.Controls.Add(lblName);
            boxAddBlock.Controls.Add(txtBlockName);
            boxAddBlock.Location = new Point(12, 13);
            boxAddBlock.Name = "boxAddBlock";
            boxAddBlock.Size = new Size(228, 182);
            boxAddBlock.TabIndex = 3;
            boxAddBlock.TabStop = false;
            boxAddBlock.Text = "Add A Block";
            // 
            // btnNeedHelp
            // 
            btnNeedHelp.Location = new Point(145, 134);
            btnNeedHelp.Name = "btnNeedHelp";
            btnNeedHelp.Size = new Size(77, 23);
            btnNeedHelp.TabIndex = 7;
            btnNeedHelp.Text = "Need help?";
            btnNeedHelp.UseVisualStyleBackColor = true;
            btnNeedHelp.Click += btnNeedHelp_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(21, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(71, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Block Name";
            // 
            // txtBlockName
            // 
            txtBlockName.Location = new Point(122, 22);
            txtBlockName.Name = "txtBlockName";
            txtBlockName.Size = new Size(100, 23);
            txtBlockName.TabIndex = 5;
            // 
            // checkIsLight
            // 
            checkIsLight.AutoSize = true;
            checkIsLight.Location = new Point(21, 59);
            checkIsLight.Name = "checkIsLight";
            checkIsLight.Size = new Size(90, 19);
            checkIsLight.TabIndex = 8;
            checkIsLight.Text = "Emits Light?";
            checkIsLight.UseVisualStyleBackColor = true;
            // 
            // checkIsBurnable
            // 
            checkIsBurnable.AutoSize = true;
            checkIsBurnable.Location = new Point(21, 84);
            checkIsBurnable.Name = "checkIsBurnable";
            checkIsBurnable.Size = new Size(78, 19);
            checkIsBurnable.TabIndex = 9;
            checkIsBurnable.Text = "Burnable?";
            checkIsBurnable.UseVisualStyleBackColor = true;
            // 
            // checkIsFull
            // 
            checkIsFull.AutoSize = true;
            checkIsFull.Location = new Point(21, 109);
            checkIsFull.Name = "checkIsFull";
            checkIsFull.Size = new Size(97, 19);
            checkIsFull.TabIndex = 10;
            checkIsFull.Text = "Whole block?";
            checkIsFull.UseVisualStyleBackColor = true;
            // 
            // checkIsTransparent
            // 
            checkIsTransparent.AutoSize = true;
            checkIsTransparent.Location = new Point(21, 134);
            checkIsTransparent.Name = "checkIsTransparent";
            checkIsTransparent.Size = new Size(93, 19);
            checkIsTransparent.TabIndex = 11;
            checkIsTransparent.Text = "Transparent?";
            checkIsTransparent.UseVisualStyleBackColor = true;
            // 
            // addBlockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 255);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(boxAddBlock);
            Name = "addBlockForm";
            Text = "addBlockForm";
            boxAddBlock.ResumeLayout(false);
            boxAddBlock.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnSubmit;
        private GroupBox boxAddBlock;
        private Button btnNeedHelp;
        private Label lblName;
        private TextBox txtBlockName;
        private CheckBox checkIsTransparent;
        private CheckBox checkIsFull;
        private CheckBox checkIsBurnable;
        private CheckBox checkIsLight;
    }
}