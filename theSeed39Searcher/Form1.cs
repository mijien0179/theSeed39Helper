using System.Diagnostics;

namespace theSeed39Searcher
{
    public partial class Form1 : Form
    {
        String UpdateDate = "2022.08.02.";
        Color AnswerColor = Color.Red;
        Button cancelBtn = new Button()
        {
            Text = "Cancel",

        };

        public Form1()
        {
            InitializeComponent();
            string qString = Properties.Resources.file;

            맨위로ToolStripMenuItem_Click(맨위로ToolStripMenuItem, new EventArgs());
            투명도80ToolStripMenuItem_Click(투명도80ToolStripMenuItem, new EventArgs());
            textBox1_TextChanged(textBox1, new EventArgs());

            cancelBtn.Click += new EventHandler(
                (s, e) =>
                {

                    textBox1.Text = "";

                }
            );

            searchList = qString.Split("\n");
            ImeMode = ImeMode.Hangul;
        }

        string[] searchList;

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += $" {UpdateDate}";

            CancelButton = cancelBtn;
        }

        public string Query
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        public string selected;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var answer = new Label[] { label2, label3, label4, label5 };
            foreach (var item in answer)
            {
                item.Text = "";
            }
            if (textBox1.Text == "")
            {
                label1.Text = "질문을 입력하세요.";
                return;
            }
            var data = textBox1.Text.Split(" ");

            int b = 0;

            selected = "답이 없습니다.";

            foreach (var str in searchList)
            {
                var tested = str.Replace(" ", "");
                b = 0;
                foreach (var item in data)
                {
                    if (!tested.Contains(item))
                    {
                        break;
                    }
                    b++;
                }
                if (b == data.Length)
                {
                    selected = str;
                    break;
                }
            }


            var items = selected.Split("|");
            for (int i = 0; i < items.Length; i++) items[i] = items[i].Trim();

            label1.Text = items[0];

            if (b != data.Length) return;

            for (int i = 0; i < 4; ++i)
            {
                FontStyle style = FontStyle.Regular;
                answer[i].Text = $"{i + 1}. {items[i + 1]}";
                answer[i].ForeColor = Color.Black;
                if (i + 1 == items[5][0] - '0')
                {
                    answer[i].ForeColor = AnswerColor;
                    if (굵게표시ToolStripMenuItem.Checked == true)
                    {
                        style = FontStyle.Bold;
                    }

                    if (포인트추가ToolStripMenuItem.Checked == true)
                    {
                        answer[i].Text += " *";
                    }
                }
                answer[i].Font = new Font("돋움체", 11, style);
            }


        }

        private void 맨위로ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = 맨위로ToolStripMenuItem.Checked;
        }

        private void 투명도80ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (투명도80ToolStripMenuItem.Checked == true)
            {
                this.Opacity = 0.8;
            }
            else
                this.Opacity = 1.0;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            textBox1.Select();
            if (창활성화시질문삭제ToolStripMenuItem.Checked) textBox1.Clear();
        }

        private void 개발자GithubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "https://github.com/mijien0179/theSeed39Searcher");

        }

        private void 정답색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                AnswerColor = cd.Color;
            }

        }

        private void 데이터출처ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "http://39.theseed.ze.am/");
        }

        private void 오류제보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", "https://github.com/mijien0179/theSeed39Helper/issues/new/choose");
        }
    }
}