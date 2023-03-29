namespace test1
{
    class window : Form
    {
        string windowTitle;
        string labelName;

        public window(string windowTitle, string labelName)
        {
            this.windowTitle = windowTitle;
            this.labelName = labelName;
            InitializeComponent();
        }

        private System.Windows.Forms.Label label1;

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = windowTitle;

            this.SuspendLayout();

            label1 = new Label();

            this.label1 = new System.Windows.Forms.Label();
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "test";
            this.label1.AutoSize = true;
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = labelName;

            Controls.Add(label1);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}