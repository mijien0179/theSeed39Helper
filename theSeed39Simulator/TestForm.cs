using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace theSeed39Simulator
{
    public partial class TestForm : Form
    {
        List<string> problemList = new List<string>();

        Label[] ansList;

        public Boolean retry = false;

        public int problemCount = 0;
        public int failCount = 0;

        private bool shutdown = false;

        Stopwatch sw = new Stopwatch();

        private int correction;
        private int _selected = 0;
        private int Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
               
                for (int i = 0; i < ansList.Length; ++i)
                {
                    if (i == Selected)
                    {
                        ansList[i].Font = new Font(ansList[i].Font, FontStyle.Underline);
                        ansList[i].ForeColor = Color.FromArgb(30, 30, 255);
                        ansList[i].BackColor = Color.FromArgb(230,230,230);
                    }
                    else
                    {
                        ansList[i].Font = new Font(ansList[i].Font, ansList[i].Font.Style & ~FontStyle.Underline);
                        ansList[i].ForeColor = Color.Black;
                        ansList[i].BackColor = BackColor;
                    }
                }

            }
        }

        public TestForm(List<string> data)
        {
            InitializeComponent();

            string[] file = Properties.Resources.file.Split('\n');
            foreach(var t in file)
            {
                if (data.Contains(t.Split("|")[0].Trim()))
                {
                    problemList.Add(t);
                }
            }

            ansList = new Label[]
            {
                label3,
                label4,
                label5,
                label6
            };

            for(int i = 0; i < ansList.Length; ++i)
            {
#if !DEBUG
                ansList[i].Text = "";
#endif

                ansList[i].Cursor = Cursors.Hand;

                if(i > 0)
                {
                    ansList[i].Location = new Point(ansList[i - 1].Left, ansList[i - 1].Bottom + 15);
                }
            }

            NewProblemShow();
        }

        private void NewProblemShow()
        {
            Random rand = new Random();
            int makeIndex = rand.Next(problemList.Count);

            string[] problem = problemList[makeIndex].Split("|");

            lblProblem.Text = problem[0].Trim();

            for(int i = 0; i< ansList.Length; ++i)
            {
                ansList[i].Text = $"{i + 1}. {problem[i + 1].Trim()}";
            }

            correction = problem[5].Trim()[0] - '1';
            Selected = 0;
        }

        private void AnswerChecker()
        {
            if(Selected == correction)
            {
                problemCount++;
                if(problemCount == 10)
                {
                    sw.Stop();
                    MessageBox.Show($"10번 모두 맞췄습니다.\n 걸린 시간: {sw.Elapsed.Minutes}:{sw.Elapsed.Seconds};{sw.Elapsed.Milliseconds}");
                    shutdown = true;
                    Close();
                }
            }
            else
            {
                failCount++;
                MessageBox.Show($"틀렸습니다.\n정답: {ansList[correction].Text}");
                if(failCount == 2)
                {
                    shutdown = true;
                    MessageBox.Show("두번 실패했습니다. 시뮬레이션을 종료합니다.");
                    Close();
                }
            }
            NewProblemShow();

        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!shutdown && MessageBox.Show("시험을 중단합니다.", Application.ProductName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnswerChecker();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Label lbl = sender as Label;
            for(int i = 0; i< ansList.Length; ++i)
            {
                if(lbl == ansList[i])
                {
                    Selected = i;
                    break;
                }
            }

            // AnswerChecker();
        }

        private void TestForm_KeyDown(object? sender, KeyEventArgs e)
        {
            int offset = 0;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (Selected > 0) offset = -1;
                    break;
                case Keys.Down:
                    if (Selected + 1 < ansList.Length) offset = 1;
                    break;
                case Keys.Enter:
                    AnswerChecker();
                    return;
            }
            Selected += offset;
        }

        private void TestForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                    e.IsInputKey = true;
                    break;
            }
        }

        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            TestForm_PreviewKeyDown(sender, e);
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            sw.Start();
        }
    }
}
