using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.CustomerFullName = txtCustomerFN.Text;
        

        Session["ACustomer"] = ACustomer; 
    
        Response.Redirect("CustomerViewer.aspx"); 
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();

        Int32 CustomerID;

        Boolean Found = false;

        CustomerID = Convert.ToInt32(txtCustomerID.Text);

        Found = ACustomer.Find(CustomerID);

        if (Found == true)
        {
            txtCustomerFN.Text = ACustomer.CustomerFullName.ToString();
            txtCustomerDOB.Text = ACustomer.CustomerDOB.ToString();
            txtCustomerPNo.Text = ACustomer.CustomerPhoneNumber.ToString();
        }


    }
}