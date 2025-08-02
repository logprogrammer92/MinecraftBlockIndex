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
            boxAddBlock = new GroupBox();
            btnNeedHelp = new Button();
            lblName = new Label();
            textBox1 = new TextBox();
            radioIsTransparent = new RadioButton();
            radioIsSolid = new RadioButton();
            radioIsBurnable = new RadioButton();
            radioEmitsLight = new RadioButton();
            btnSubmit = new Button();
            btnExit = new Button();
            boxAddBlock.SuspendLayout();
            SuspendLayout();
            // 
            // boxAddBlock
            // 
            boxAddBlock.Controls.Add(btnNeedHelp);
            boxAddBlock.Controls.Add(lblName);
            boxAddBlock.Controls.Add(textBox1);
            boxAddBlock.Controls.Add(radioIsTransparent);
            boxAddBlock.Controls.Add(radioIsSolid);
            boxAddBlock.Controls.Add(radioIsBurnable);
            boxAddBlock.Controls.Add(radioEmitsLight);
            boxAddBlock.Location = new Point(12, 9);
            boxAddBlock.Name = "boxAddBlock";
            boxAddBlock.Size = new Size(228, 182);
            boxAddBlock.TabIndex = 0;
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
            // textBox1
            // 
            textBox1.Location = new Point(122, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // radioIsTransparent
            // 
            radioIsTransparent.AutoSize = true;
            radioIsTransparent.Location = new Point(21, 138);
            radioIsTransparent.Name = "radioIsTransparent";
            radioIsTransparent.Size = new Size(111, 19);
            radioIsTransparent.TabIndex = 4;
            radioIsTransparent.TabStop = true;
            radioIsTransparent.Text = "Is it transparent?";
            radioIsTransparent.UseVisualStyleBackColor = true;
            // 
            // radioIsSolid
            // 
            radioIsSolid.AutoSize = true;
            radioIsSolid.Location = new Point(21, 113);
            radioIsSolid.Name = "radioIsSolid";
            radioIsSolid.Size = new Size(81, 19);
            radioIsSolid.TabIndex = 3;
            radioIsSolid.TabStop = true;
            radioIsSolid.Text = "Full Block?";
            radioIsSolid.UseVisualStyleBackColor = true;
            // 
            // radioIsBurnable
            // 
            radioIsBurnable.AutoSize = true;
            radioIsBurnable.Location = new Point(21, 88);
            radioIsBurnable.Name = "radioIsBurnable";
            radioIsBurnable.Size = new Size(77, 19);
            radioIsBurnable.TabIndex = 2;
            radioIsBurnable.TabStop = true;
            radioIsBurnable.Text = "Burnable?";
            radioIsBurnable.UseVisualStyleBackColor = true;
            // 
            // radioEmitsLight
            // 
            radioEmitsLight.AutoSize = true;
            radioEmitsLight.Location = new Point(21, 63);
            radioEmitsLight.Name = "radioEmitsLight";
            radioEmitsLight.Size = new Size(89, 19);
            radioEmitsLight.TabIndex = 2;
            radioEmitsLight.TabStop = true;
            radioEmitsLight.Text = "Emits Light?";
            radioEmitsLight.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(12, 197);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(139, 45);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Enter";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(157, 197);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(83, 45);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // addBlockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(251, 253);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(boxAddBlock);
            Name = "addBlockForm";
            Text = "Add Block";
            boxAddBlock.ResumeLayout(false);
            boxAddBlock.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox boxAddBlock;
        private RadioButton radioIsTransparent;
        private RadioButton radioIsSolid;
        private RadioButton radioIsBurnable;
        private RadioButton radioEmitsLight;
        private Button btnSubmit;
        private Button btnExit;
        private Label lblName;
        private TextBox textBox1;
        private Button btnNeedHelp;
    }
}