using MinecraftBlockIndex.Block_additon_handling;

namespace MinecraftBlockIndex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string helpMessage = "This application lets you view various blocks in the video game Minecraft\n" +
                                    "Minecraft has a lot of blocks and so this app is meant to store block data\n" +
                                    "For further reference.\n\n" +

                                    "In the upper half you can view each item name and upon clicking 'View Block'\n" +
                                    "you will be taken to a detailed view of the block's information\n\n" +

                                    "In the lower half you will find various buttons to either add a block to the\n" +
                                    "database for future viewing, remove a block from the database, or bring up \n" +
                                    "this handy guide again!";
            MessageBox.Show(helpMessage);
        }

        private void btnAddBlock_Click(object sender, EventArgs e)
        {
            addBlockForm addBlockForm = new addBlockForm();
            addBlockForm.ShowDialog();
        }
    }
}
