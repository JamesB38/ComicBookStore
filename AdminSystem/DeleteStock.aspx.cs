using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class DeleteStock : System.Web.UI.Page
{
    Int32 StockID; 
    protected void Page_Load(object sender, EventArgs e)
    {
        StockID = Convert.ToInt32(Session["StockID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();

        Stocks.ThisStock.Find(StockID);

        Stocks.Delete();

        Response.Redirect("StockList.aspx");
    }
}