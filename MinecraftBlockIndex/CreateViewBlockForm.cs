using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinecraftBlockIndex.Block_additon_handling;

namespace MinecraftBlockIndex
{
    public partial class UpdateViewBlockForm : Form
    {
        private AddBlock _block;
        public UpdateViewBlockForm(AddBlock block)
        {
            InitializeComponent();
            this._block = block;
        }

        private void CreateViewBlockForm_Load(object sender, EventArgs e)
        {
            txtUpdateBlock.Text = _block.BlockName;
            checkBoxEmitsLight.Checked = _block.EmitsLight;
            checkBoxIsBurnable.Checked = _block.IsBurnable;
            checkBoxIsTransparent.Checked = _block.IsTransparent;
            checkBoxIsFull.Checked = _block.IsFull;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddBlock block = new AddBlock(_block.BlockId, txtUpdateBlock.Text, checkBoxEmitsLight.Checked,
                checkBoxIsBurnable.Checked, checkBoxIsTransparent.Checked, checkBoxIsFull.Checked)
            {
                BlockId = _block.BlockId,
                BlockName = txtUpdateBlock.Text,
                EmitsLight = checkBoxEmitsLight.Checked,
                IsBurnable = checkBoxIsBurnable.Checked,
                IsTransparent = checkBoxIsTransparent.Checked,
                IsFull = checkBoxIsFull.Checked
            };

            int rowsChanged = AddBlockDB.Update(block);
            if (rowsChanged > 0)
            {
                MessageBox.Show("Block updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update block. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
