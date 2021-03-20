using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if(IsPostBack == false)
        {
            DisplayDescriptions();
        }

    }

    void DisplayDescriptions()
    {
        clsStockCollection Stocks = new clsStockCollection();

        lstStockList.DataSource = Stocks.StockList;

        lstStockList.DataValueField = "StockID"; //primary key

        lstStockList.DataTextField = "StockDescription"; //data thats going to be shown

        lstStockList.DataBind();
    }
}