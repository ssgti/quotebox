using System.Text;
using System.Text.Json;
using System.Net;
using System.Text.Json.Nodes;

namespace test1
{
    class nameQuote : quote
    {
        public string symbol { get; set; }
        public string name { get; set; }

        public Dictionary<string, string> labels { get; set; }

        public nameQuote(string symbol)
        {
            this.symbol = symbol;
            fetchData(symbol);
        }

        private void fetchData(string symbol)
        {
            string QUERY_URL = "https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords=" + symbol + "&apikey=LMLD4P0XA1H59J54";
            Uri queryUri = new Uri(QUERY_URL);

            using (WebClient client = new WebClient())
            {
                dynamic json_data = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(client.DownloadString(queryUri));

                foreach (KeyValuePair<string, dynamic> kvp in json_data)
                {
                    JsonArray jsonArray = JsonNode.Parse(kvp.Value.ToString());
                    JsonNode result = jsonArray[0];
                     // search currently just returns the 'closest match' returned by the API
                    //  until I can be bothered to turn it into a proper search system

                    this.symbol = result["1. symbol"].ToString();
                    this.name = result["2. name"].ToString();

                    this.labels = new Dictionary<string, string>()
                    {
                        { "symbol", result["1. symbol"].ToString() },
                        { "name", result["2. name"].ToString() }
                    };
                }
            }
        }
    }
}