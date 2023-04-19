namespace test1
{
    static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new inputWindow());
        }
    }

    interface quote
    {
        public string symbol { get; set; }
        private void fetchData(string symbol) { }
    }
}