using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 StockID;
    protected void Page_Load(object sender, EventArgs e)
    {

        StockID = Convert.ToInt32(Session["StockID"]);
        if (IsPostBack == false)
        {
            if (StockID != -1)
            {
                DisplayStock();
            }
        }

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();

        int StockID = Convert.ToInt32(txtStockID.Text);

        string StockAvailability = txtStockAvailability.Text;

        string StockDescription = txtStockDescription.Text;

        string StockPrice = txtStockPrice.Text;

        string Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);
        

        if(Error == "")
        {
            AnStock.StockID = StockID;

            AnStock.StockAvailability = Convert.ToInt32(StockAvailability);

            AnStock.StockDescription = StockDescription;

            AnStock.StockPrice = Convert.ToDouble(StockPrice);

            AnStock.IsBeingRestocked = chkIsBeingRestocked.Checked;

            clsStockCollection StockList = new clsStockCollection();


            if(StockID == -1)
            {
                StockList.ThisStock = AnStock;

                StockList.Add();
            }
            else
            {
                StockList.ThisStock.Find(StockID);

                StockList.ThisStock = AnStock;

                StockList.Update();
            }

            Response.Redirect("StockList.aspx");
            
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

    void DisplayStock()
    {
        clsStockCollection AllStock = new clsStockCollection();

        AllStock.ThisStock.Find(StockID); //ThisStock is null

        txtStockID.Text = AllStock.ThisStock.StockID.ToString();
        txtStockAvailability.Text = AllStock.ThisStock.StockAvailability.ToString();
        txtStockDescription.Text = AllStock.ThisStock.StockDescription;
        txtStockPrice.Text = AllStock.ThisStock.StockPrice.ToString();
        chkIsBeingRestocked.Checked = AllStock.ThisStock.IsBeingRestocked;
    }


}