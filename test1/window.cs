namespace test1
{
    class window : Form
    {
        string ticker;
        string price;

        public window(stockdata stock)
        {
            this.ticker = stock.symbol.ToString();
            this.price = stock.price.ToString();
            InitializeComponent();
        }

        private System.Windows.Forms.Label label1;

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Text = ticker;

            this.SuspendLayout();

            label1 = new Label();

            this.label1 = new System.Windows.Forms.Label();
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "price";
            this.label1.AutoSize = true;
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "price: " + price;

            Controls.Add(label1);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}