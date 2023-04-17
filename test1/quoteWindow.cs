namespace test1
{
    class quoteWindow : Form
    {
        string symbol;
        string open;
        string high;
        string low;
        string price;
        string pclose;
        string changep;

        public quoteWindow(dailyQuote stock)
        {
            this.symbol = stock.symbol.ToString();
            this.open = stock.open.ToString();
            this.high = stock.high.ToString();
            this.low = stock.low.ToString();
            this.price = stock.price.ToString();
            this.pclose = stock.pclose.ToString();
            this.changep = stock.changep.ToString();
            InitializeComponent();
        }

        private System.Windows.Forms.Label openLbl;
        private System.Windows.Forms.Label highLbl;
        private System.Windows.Forms.Label lowLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label pcloseLbl;
        private System.Windows.Forms.Label changepLbl;

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Text = symbol + " - previous day trading stats";

            this.SuspendLayout();

            openLbl = new Label();
            this.openLbl = new System.Windows.Forms.Label();
            this.openLbl.Location = new System.Drawing.Point(10, 10);
            this.openLbl.Name = "open";
            this.openLbl.AutoSize = true;
            this.openLbl.Size = new System.Drawing.Size(40, 20);
            this.openLbl.TabIndex = 0;
            this.openLbl.Text = "open: " + open;
            Controls.Add(openLbl);

            highLbl = new Label();
            this.highLbl = new System.Windows.Forms.Label();
            this.highLbl.Location = new System.Drawing.Point(10, 30);
            this.highLbl.Name = "high";
            this.highLbl.AutoSize = true;
            this.highLbl.Size = new System.Drawing.Size(40, 20);
            this.highLbl.TabIndex = 0;
            this.highLbl.Text = "high: " + high;
            Controls.Add(highLbl);

            lowLbl = new Label();
            this.lowLbl = new System.Windows.Forms.Label();
            this.lowLbl.Location = new System.Drawing.Point(10, 50);
            this.lowLbl.Name = "low";
            this.lowLbl.AutoSize = true;
            this.lowLbl.Size = new System.Drawing.Size(40, 20);
            this.lowLbl.TabIndex = 0;
            this.lowLbl.Text = "low: " + low;
            Controls.Add(lowLbl);

            priceLbl = new Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.priceLbl.Location = new System.Drawing.Point(10, 70);
            this.priceLbl.Name = "price";
            this.priceLbl.AutoSize = true;
            this.priceLbl.Size = new System.Drawing.Size(40, 20);
            this.priceLbl.TabIndex = 0;
            this.priceLbl.Text = "price: " + price;
            Controls.Add(priceLbl);

            pcloseLbl = new Label();
            this.pcloseLbl = new System.Windows.Forms.Label();
            this.pcloseLbl.Location = new System.Drawing.Point(10, 90);
            this.pcloseLbl.Name = "pclose";
            this.pcloseLbl.AutoSize = true;
            this.pcloseLbl.Size = new System.Drawing.Size(40, 20);
            this.pcloseLbl.TabIndex = 0;
            this.pcloseLbl.Text = "close: " + pclose;
            Controls.Add(pcloseLbl);

            changepLbl = new Label();
            this.changepLbl = new System.Windows.Forms.Label();
            this.changepLbl.Location = new System.Drawing.Point(10, 110);
            this.changepLbl.Name = "changep";
            this.changepLbl.AutoSize = true;
            this.changepLbl.Size = new System.Drawing.Size(40, 20);
            this.changepLbl.TabIndex = 0;
            this.changepLbl.Text = "change percent: " + changep;
            Controls.Add(changepLbl);


            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}