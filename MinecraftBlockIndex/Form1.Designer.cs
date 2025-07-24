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
            addBtn = new Button();
            delViewBtn = new Button();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.Location = new Point(103, 322);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(124, 55);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add Block";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // delViewBtn
            // 
            delViewBtn.Location = new Point(420, 322);
            delViewBtn.Name = "delViewBtn";
            delViewBtn.Size = new Size(127, 55);
            delViewBtn.TabIndex = 1;
            delViewBtn.Text = "Delete/View Block";
            delViewBtn.UseVisualStyleBackColor = true;
            delViewBtn.Click += delViewBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 511);
            Controls.Add(delViewBtn);
            Controls.Add(addBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button addBtn;
        private Button delViewBtn;
    }
}
