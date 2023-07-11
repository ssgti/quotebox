namespace test1
{
    class quoteWindow : Form
    {
        string symbol;
        string name;
        Dictionary<string, string> labels;
        Point startpos;

        public quoteWindow(Dictionary<string, string> labels, string symbol, string name, Point startpos)
        {
            this.symbol = symbol;
            this.name = name;
            this.labels = labels;
            this.startpos = startpos;

            InitializeComponent(labels);
        }

        private preLabel label;

        private void InitializeComponent(Dictionary<string, string> labels)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = this.startpos;

            this.Text = symbol + " - " + name;

            this.SuspendLayout();

             // this saves a LOT of lines of code
            //  no longer need to manually define labels
            int vOffset = 10;
            foreach (KeyValuePair<string,string> type in labels)
            {
                Controls.Add(new preLabel(type.Key, type.Value, vOffset));
                vOffset += 20;
            }

            this.ClientSize = new System.Drawing.Size(400, vOffset + 10);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}