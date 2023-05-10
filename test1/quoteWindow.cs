namespace test1
{
    class quoteWindow : Form
    {
        string symbol;
        string name;

        public quoteWindow(dailyQuote stock, string symbol, string name)
        {
            this.symbol = symbol;
            this.name = name;

            var labels = new Dictionary<string, string>(){
                { "open", stock.open.ToString() },
                { "high", stock.high.ToString() },
                { "low", stock.low.ToString() },
                { "price", stock.price.ToString() },
                { "previous close", stock.pclose.ToString() },
                { "percentage change", stock.changep.ToString() }
            };

            InitializeComponent(labels);
        }

        private preLabel label;

        private void InitializeComponent(Dictionary<string, string> labels)
        {
            
            this.Text = symbol + " - " + name;

            this.SuspendLayout();

              // this saves a LOT of lines of code
             //  no longer need to manually define labels
            //   should hopefully also make this class reusable
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