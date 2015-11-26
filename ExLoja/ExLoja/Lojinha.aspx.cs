using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ExLoja
{
    public partial class Lojinha : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProcura_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            string qyrPesquisa = string.Format("select * from produtos where descProd like '{0} %'", txtDescr.Text);

            SqlDataAdapter da = new SqlDataAdapter(qyrPesquisa, @"Data Source=LocalHost;Initial Catalog=excloja;Integrated Security=True");

            da.Fill(ds);

            grvResult.DataSource = ds.Tables[0];
            grvResult.DataBind();
        }
    }
}