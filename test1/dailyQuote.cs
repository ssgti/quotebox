using System.Text;
using System.Text.Json;
using System.Net;

namespace test1
{
    class dailyQuote : quote
    {
        public string symbol { get; set; }
        public double open { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double price { get; set; }
        public double pclose { get; set; }
        public string changep { get; set; }

        public dailyQuote(string symbol)
        {
            this.symbol = symbol;
            fetchData(symbol);
        }

        private void fetchData(string symbol)
        {
            string query_url = "https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=" + symbol + "&apikey=LMLD4P0XA1H59J54";
            Uri queryUri = new Uri(query_url);

            using (WebClient client = new WebClient())
            {
                dynamic json_data = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(client.DownloadString(queryUri));

                foreach(KeyValuePair<string, dynamic> kvp in json_data)
                {
                    using JsonDocument doc = JsonDocument.Parse(kvp.Value.ToString());
                    JsonElement jsonElement = doc.RootElement;

                    string o = jsonElement.GetProperty("02. open").ToString();
                    this.open = double.Parse(o);

                    string h = jsonElement.GetProperty("03. high").ToString();
                    this.high = double.Parse(h);

                    string l = jsonElement.GetProperty("04. low").ToString();
                    this.low = double.Parse(l);

                    string p = jsonElement.GetProperty("05. price").ToString();
                    this.price = double.Parse(p);

                    string c = jsonElement.GetProperty("08. previous close").ToString();
                    this.pclose = double.Parse(c);

                    string ch = jsonElement.GetProperty("10. change percent").ToString();
                    this.changep = ch;
                }
            }
        }
    }
}
