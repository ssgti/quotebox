namespace test1
{
    static class Program
    {
        static void Main()
        {
            string symbol = "IBM";
            stockdata stock = new stockdata("IBM");

            ApplicationConfiguration.Initialize();
            Application.Run(new window(stock));
        }
    }
}