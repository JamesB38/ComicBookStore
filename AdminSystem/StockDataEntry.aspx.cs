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
        clsStock AnStock = new clsStock();

        string StockAvailability = txtStockAvailability.Text;

        string StockDescription = txtStockDescription.Text;

        string StockPrice = txtStockPrice.Text;

        string Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);
        

        if(Error == "")
        {
            AnStock.StockAvailability = Convert.ToInt32(txtStockAvailability.Text);

            AnStock.StockDescription = txtStockDescription.Text;

            AnStock.StockPrice = Convert.ToDouble(txtStockPrice.Text);
            
            Session["AStock"] = AnStock;
            
            Response.Redirect("StockViewer.aspx");
        }

        else
        {
            lblError.Text = Error;
        }
       
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