using System.Net;
using System.Text.Json;

namespace test1
{
    class infoQuote : quote
    {
        public string symbol { get; set; }
        public Dictionary<string, string> labels { get; set; }
        public bool error { get; set; }

        public infoQuote(string symbol) // company overview
        {
            this.symbol = symbol;
            fetchData(symbol);
        }

        private void fetchData(string symbol)
        {
            string query_url = "https://www.alphavantage.co/query?function=OVERVIEW&symbol=" + symbol + "&apikey=LMLD4P0XA1H59J54";
            Uri queryUri = new Uri(query_url);

            using (WebClient client = new WebClient())
            {
                Dictionary<string, string> json_data = JsonSerializer.Deserialize<Dictionary<string, string>>(client.DownloadString(queryUri));

                // why are the methods of parsing this so inconsistent and frustrating
                if (json_data != null)
                {
                    string e = json_data["Exchange"];
                    string c = json_data["Currency"];
                    string co = json_data["Country"];
                    string s = json_data["Sector"];
                    string i = json_data["Industry"];

                    this.labels = new Dictionary<string, string>()
                    {
                        { "exchange", e },
                        { "currency", c },
                        { "country", co },
                        { "sector", s },
                        { "industry", i }
                    };
                }
            }
        }
    }
}