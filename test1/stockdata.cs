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
        public decimal price { get; set; }

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
                try
                {
                    MessageBox.Show(json_data.price);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
            }
        }
    }
}
