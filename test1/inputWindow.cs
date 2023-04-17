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
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchLabel;

        private void InitializeComponent()
        {
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Text = "stock quote endpoint";

            this.SuspendLayout();

            inputBox = new TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.inputBox.Location = new System.Drawing.Point(10, 30);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(60, 20);
            this.inputBox.Text = this.inputText;
        }
    }
}