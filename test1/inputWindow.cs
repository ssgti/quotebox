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

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Text = "stock quote endpoint";

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

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void quoteBtn_Click(object sender, System.EventArgs e)
        {
            try
            {
                dailyQuote stock = new dailyQuote(inputBox.Text.ToString());
                quoteWindow quote = new quoteWindow(stock);
                quote.Show();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "oops!");
            }
        }
    }
}