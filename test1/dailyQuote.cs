using System.Text;
using System.Text.Json;
using System.Net;
using System.Runtime.CompilerServices;

namespace test1
{
    class dailyQuote : quote
    {
        public string symbol { get; set; }
        public Dictionary<string, string> labels { get; set; }

        public dailyQuote(string symbol) // daily price quote and trading stats
        {
            this.symbol = symbol;
            fetchData(symbol);
        }

        private void fetchData(string symbol)
        {
            string query_url = "https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=" + symbol + "&apikey=LMLD4P0XA1H59J54";
            Uri queryUri = new Uri(query_url);

            // financial data comes straight from the API so it's nothing to do with me if it's wrong :)

            using (WebClient client = new WebClient())
            {
                dynamic json_data = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(client.DownloadString(queryUri));

                foreach(KeyValuePair<string, dynamic> kvp in json_data)
                {
                    using JsonDocument doc = JsonDocument.Parse(kvp.Value.ToString());
                    JsonElement jsonElement = doc.RootElement;
                    // both this and nameQuote use different methods for parsing JSON and I don't know which is better

                    string o = jsonElement.GetProperty("02. open").ToString();
                    string h = jsonElement.GetProperty("03. high").ToString();
                    string l = jsonElement.GetProperty("04. low").ToString();
                    string p = jsonElement.GetProperty("05. price").ToString();
                    string c = jsonElement.GetProperty("08. previous close").ToString();
                    string ch = jsonElement.GetProperty("10. change percent").ToString();

                    this.labels = new Dictionary<string, string>()
                    {
                        { "open", double.Parse(o).ToString() },
                        { "high", double.Parse(h).ToString() },
                        { "low", double.Parse(l).ToString() },
                        { "price", double.Parse(p).ToString() },
                        { "previous close", double.Parse(c).ToString() },
                        { "percentage change", ch }
                    }; // parsing and then converting to string is to remove empty decimal points
                }
            }
        }
    }
}
