using System.Diagnostics;
using System.Windows.Forms;

namespace theSeed39Simulator
{
    public partial class Form1 : Form
    {
        static string version = "2022.08.04";

        public Form1()
        {
            InitializeComponent();

            MaximumSize = MinimumSize = Size;
            Text = $"Maple TheSeed 39 Floor Simulator - {version}";

            //label1.Location = new Point((Width - label1.Width) >> 1, label1.Top);
            btnTest.Location = new Point((Width - btnTest.Width) >> 1, btnTest.Top);

            HashSet<string> list = new HashSet<string>();
            string[] temp = Properties.Resources.file.Split("\n");
            
            foreach(string t in temp)
            {
                list.Add(t.Split("|")[0].Trim());
            }

            checkedListBox1.Items.AddRange(list.ToArray());
            CheckSet(true);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {

            List<string> list = new List<string>();
            list.AddRange(checkedListBox1.CheckedItems.OfType<string>().ToArray());

            this.Hide();
            TestForm frm;
            do
            {
                frm = new TestForm(list);
                frm.ShowDialog();
            } while (frm.retry);

            this.Show();
        }

        private void CheckSet(Boolean b)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, b);
        }

        private void 전체선택해제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckSet(false);
        }

        private void 전체선택ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckSet(true);
        }

        private void 개발자GithubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "https://github.com/mijien0179/theSeed39Helper");
        }

        private void 오류제보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "https://github.com/mijien0179/theSeed39Helper/issues/new/choose");
        }
    }
}