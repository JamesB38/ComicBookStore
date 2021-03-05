using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsStock aStock = new clsStock();

        aStock.StockDescription = txtStockDescription.Text;

        Session["AStock"] = aStock;


    
        Response.Redirect("StockViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();

        Int32 StockID;

        Boolean Found = false;

        StockID = Convert.ToInt32(txtStockID.Text);

        Found = AnStock.Find(StockID);

        if(Found == true)
        {
            txtStockAvailability.Text = AnStock.StockAvailability.ToString();
            txtStockDescription.Text = AnStock.StockDescription;
            txtStockPrice.Text = AnStock.StockPrice.ToString();
     
        }
    }
}