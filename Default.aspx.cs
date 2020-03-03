using System;
using System.Web;
using Newtonsoft.Json;
using System.Web.UI;
using System.IO;

namespace FrontendAssignment.WebForms
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Product[] products = null;
            var filePath = HttpContext.Current.Server.MapPath("~/App_Data/Products.json");
            using (var reader = new StreamReader(filePath))
            {
                products = JsonConvert.DeserializeObject<Product[]>(reader.ReadToEnd());
            }

            rpt.DataSource = products;
            rpt.DataBind();
        }

        public class Product
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("fromPrice")]
            public string FromPrice { get; set; }

            [JsonProperty("image")]
            public string Image { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }
        }
    }
}