using Exam2047;
using System.Reflection;

namespace TaskForExam2048
{
    public partial class Form1 : Form
    {
        void Start()
        {

            Model model = new Model(4);
            model.Start();
            //void Form1_KeyPress(object sender, KeyPressEventArgs e)
            //{
            //    if (e.KeyChar == (char)Keys.Down)
            //        model.Down();
            //}
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EscapeClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Start();
        }
    }
}