using MinecraftBlockIndex.Block_additon_handling;

namespace MinecraftBlockIndex
{
    public partial class Form1 : Form
    {
        List<AddBlock> blocks;

        public Form1()
        {
            InitializeComponent();
        }

        private void refreshBlockData()
        {
            blocks = AddBlockDB.GetAllBlocks();
            comboBoxBlock.Items.Clear();
            foreach (AddBlock block in blocks)
            {
                if (!comboBoxBlock.Items.Contains(block))
                {
                    comboBoxBlock.Items.Add(block);
                }
            }
            btnViewBlock.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshBlockData();
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

        private void comboBoxBlock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBlock.SelectedItem is AddBlock selectedBlock)
            {
                btnViewBlock.Enabled = true;
                lblBlockName.Text = selectedBlock.BlockName;
            }
            else
            {
                btnViewBlock.Enabled = false;
            }
        }

        private void btnViewBlock_Click(object sender, EventArgs e)
        {
            UpdateViewBlockForm viewBlockForm = new UpdateViewBlockForm((AddBlock)comboBoxBlock.SelectedItem);
            viewBlockForm.ShowDialog();
            refreshBlockData();

        }
    }
}
