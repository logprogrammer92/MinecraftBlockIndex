using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftBlockIndex.Block_additon_handling
{
    public partial class addBlockForm : Form
    {
        public addBlockForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNeedHelp_Click(object sender, EventArgs e)
        {
            string helpMessage = "This help message is to guide the user in adding a block\n" +
                                  "To add a block, please fill in the following details:\n" +
                                  "Name: the identifier given to the block in the form of a formal name\n\n" +

                                  "If the user can answer yes to any of these checks, please fill in the bubble\n" +
                                  "Emits Light: Can the block give off light?\n" +
                                  "Burnable: Can the block be burned by lava or fire?\n" +
                                  "Full Block: Is the block a full block like oak planks or is it partially full like oak wood stairs\n" +
                                  "Is it transparent: Can you see through the block like glass or leaves?\n"
                                  ;
            MessageBox.Show(helpMessage);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
