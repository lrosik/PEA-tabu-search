using System.Windows.Forms;

namespace TabuSearch
{
    public partial class FormMain : Form
    {
        public Parser Parser { get; set; } = new Parser();
        public Graph Graph { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLoadFile_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Parser.LoadFile(openFileDialog.FileName);
                Graph = new Graph{Matrix = Parser.MakeMatrix()};
                buttonRunSwap.Enabled = true;
                buttonRunInsert.Enabled = true;
                buttonRunInvert.Enabled = true;
            }
        }

        private void buttonRunSwap_Click(object sender, System.EventArgs e)
        {
            var swap = Graph.RunSwapTabuSearch(int.Parse(textBoxTime.Text), 5);
            textBoxSwap.Text = swap.ToString();
        }

        private void buttonRunInsert_Click(object sender, System.EventArgs e)
        {
            var insert = Graph.RunInsertTabuSearch(int.Parse(textBoxTime.Text), 5);
            textBoxInsert.Text = insert.ToString();
        }

        private void buttonRunInvert_Click(object sender, System.EventArgs e)
        {
            var invert = Graph.RunInvertTabuSearch(int.Parse(textBoxTime.Text), 5);
            textBoxInvert.Text = invert.ToString();
        }
    }
}
