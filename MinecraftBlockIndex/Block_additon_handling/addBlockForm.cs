using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void btnNeedHelp_Click(object sender, EventArgs e)
        {
            //This help message explains to the user what each check is for.
            string helpMessage = 
                "Block Name: The unique name for the block/n" + 
                "Emits Light: Does the block emit light when left alone/n" +
                "Burnable: Can the block be burned by fire and lava?/n" +
                "Full Block: Is the block a full block or does it have space missing like a slab or stairs/n" +
                "Transparent: Can you see through the block like glass or leaves (depending on version)";

            MessageBox.Show(helpMessage);
        }
    }
}
