namespace test1
{
    class inputWindow : Form
    {
        string inputText;
        
        public inputWindow()
        {
            InitializeComponent();
        }

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button quoteBtn;
        private System.Windows.Forms.Label quoteLabel;
        private System.Windows.Forms.Label statusLabel;

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Text = "stock quote endpoint    (very WIP)";

            this.SuspendLayout();

            inputBox = new TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.inputBox.Location = new System.Drawing.Point(10, 30);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 30);
            Controls.Add(inputBox);

            quoteBtn = new Button();
            this.quoteBtn = new System.Windows.Forms.Button();
            this.quoteBtn.Location = new System.Drawing.Point(10, 60);
            this.quoteBtn.Text = "get quote";
            this.quoteBtn.Size = new System.Drawing.Size(100, 25);
            quoteBtn.Click += new EventHandler(quoteBtn_Click);
            Controls.Add(quoteBtn);

            quoteLabel = new Label();
            this.quoteLabel = new System.Windows.Forms.Label();
            this.quoteLabel.Location = new System.Drawing.Point(7, 10);
            this.quoteLabel.AutoSize = true;
            this.quoteLabel.Size = new System.Drawing.Size(100, 30);
            this.quoteLabel.Text = "enter stock symbol";
            Controls.Add(quoteLabel);

            statusLabel = new Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusLabel.Location = new System.Drawing.Point(7, 90);
            this.statusLabel.AutoSize = true;
            this.statusLabel.Size = new System.Drawing.Size(100, 30);
            this.statusLabel.Text = "";
            Controls.Add(statusLabel);

            this.StartPosition = FormStartPosition.CenterScreen;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void quoteBtn_Click(object sender, System.EventArgs e)
        {

            if(inputBox.Text != "")
            {
                try
                {
                    Point dqStartPos = new Point(10, 10);
                    Stock stock = new Stock(inputBox.Text.ToString());
                    dailyQuote stockQuote = new dailyQuote(stock.symbol);
                    quoteWindow sQuote = new quoteWindow(stockQuote.labels, stock.symbol, stock.name, dqStartPos);
                    sQuote.Show();

                    Point iqStartPos = new Point(10, 100);
                    infoQuote infoQuote = new infoQuote(stock.symbol);
                    quoteWindow iQuote = new quoteWindow(infoQuote.labels, stock.symbol, stock.name, dqStartPos);
                    iQuote.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "oops!");
                }
                statusLabel.Text = "";
            }
            else
            {
                statusLabel.Text = "search box empty!";
            }
        }
    }
}