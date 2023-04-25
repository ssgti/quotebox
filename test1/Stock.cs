namespace test1
{
    class Stock
    {
        public string symbol { get; set; }
        public string name { get; set; }

        public Stock(string symbol)
        {
            this.symbol = symbol;
            nameQuote getData = new nameQuote(symbol);
            this.symbol = getData.symbol;
            this.name = getData.name;
        }
    }
}