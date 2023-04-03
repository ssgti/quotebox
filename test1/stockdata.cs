using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Net;
using System.Threading.Tasks;

namespace test1
{
    class stockdata
    {
        public string symbol { get; set; }
        public dynamic price { get; set; }

        public stockdata(string symbol)
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
                    MessageBox.Show((kvp.Value).toString());
                }
            }
        }
    }
}
