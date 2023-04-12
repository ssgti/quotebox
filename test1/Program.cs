namespace test1
{
    static class Program
    {
        static void Main()
        {
            string symbol = "INVP.L";
            stockdata stock = new stockdata(symbol);

            ApplicationConfiguration.Initialize();
            Application.Run(new window(stock));
        }
    }
}