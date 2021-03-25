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

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StockID"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {

        Int32 StockID;

        if(lstStockList.SelectedIndex != -1)
        {
            StockID = Convert.ToInt32(lstStockList.SelectedValue);

            Session["StockID"] = StockID;

            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StockID;

        if(lstStockList.SelectedIndex != -1) //if something has been selected
        {
            StockID = Convert.ToInt32(lstStockList.SelectedValue);

            Session["StockID"] = StockID;

            Response.Redirect("DeleteStock.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();

        Stocks.ReportByDescription(txtDescription.Text);
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "StockID";
        lstStockList.DataTextField = "StockDescription";
        lstStockList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStockCollection Stocks = new clsStockCollection();

        Stocks.ReportByDescription("");

        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "StockID";
        lstStockList.DataTextField = "StockDescription";
        lstStockList.DataBind();

    }
}