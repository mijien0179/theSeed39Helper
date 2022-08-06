namespace theSeed39Simulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.전체선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전체선택해제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(652, 547);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(236, 49);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "시작";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "메이플 더시드 39층 시뮬레이터";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 481);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "문제 은행";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.IntegralHeight = false;
            this.checkedListBox1.Location = new System.Drawing.Point(3, 27);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkedListBox1.Size = new System.Drawing.Size(870, 451);
            this.checkedListBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.전체선택ToolStripMenuItem,
            this.전체선택해제ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 68);
            // 
            // 전체선택ToolStripMenuItem
            // 
            this.전체선택ToolStripMenuItem.Name = "전체선택ToolStripMenuItem";
            this.전체선택ToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.전체선택ToolStripMenuItem.Text = "전체 선택";
            this.전체선택ToolStripMenuItem.Click += new System.EventHandler(this.전체선택ToolStripMenuItem_Click);
            // 
            // 전체선택해제ToolStripMenuItem
            // 
            this.전체선택해제ToolStripMenuItem.Name = "전체선택해제ToolStripMenuItem";
            this.전체선택해제ToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.전체선택해제ToolStripMenuItem.Text = "전체 선택 해제";
            this.전체선택해제ToolStripMenuItem.Click += new System.EventHandler(this.전체선택해제ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTest);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTest;
        private Label label1;
        private GroupBox groupBox1;
        private CheckedListBox checkedListBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 전체선택ToolStripMenuItem;
        private ToolStripMenuItem 전체선택해제ToolStripMenuItem;
    }
}