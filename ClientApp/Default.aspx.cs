using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace ClientApp
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Prathima.StockClient client = new Prathima.StockClient();
            //Response.Write(sc.GetStock("GOOG").Company);
            StringBuilder sb = new StringBuilder();
            Prathima.Stock st = client.GetStock(TextBox1.Text.Trim());
            if (st != null)
            {
                sb.AppendFormat("<br /><br /><B>Company:</B> {0}<br />", st.Company);
                sb.AppendFormat("<B>Date: </B>{0}<br />", st.Date);
                sb.AppendFormat("<B>Close: </B>{0}<br />", st.Close);
                sb.AppendFormat("<B>Symbol: </B>{0}<br />", st.Symbol);
                Label1.Text = sb.ToString();
            }
        }
    }
}
