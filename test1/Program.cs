namespace test1
{
    static class Program
    {
        static void Main()
        {
            string symbol = "INVP.L";
            dailyQuote stock = new dailyQuote(symbol);

            ApplicationConfiguration.Initialize();
            Application.Run(new quoteWindow(stock));
        }
    }

    interface quote
    {
        public string symbol { get; set; }
        private void fetchData(string symbol) { }
    }
}