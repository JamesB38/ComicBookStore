using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mCustomerID;
        private bool mEmailSubscription;
        private string mCustomerFullName;
        private long mCustomerPhoneNumber; 
        private DateTime mCustomerDOB; 


        public bool EmailSubscription
        {
            get
            {
                return mEmailSubscription;
            }
            set
            {
                mEmailSubscription = value;
            }
        }



        public string CustomerFullName
        {
            get
            {
                return mCustomerFullName;
            }
            set
            {
                mCustomerFullName = value;
            }
        }




        public long CustomerPhoneNumber
        {
            get
            {
                return mCustomerPhoneNumber;
            }
            set
            {
                mCustomerPhoneNumber = value;
            }
        }




        public Int32 CustomerID
        {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value; 
            }
        }

        public DateTime CustomerDOB
        {
            get
            {
                return mCustomerDOB;
            }
            set
            {
                mCustomerDOB = value;
            }
        }





        public bool Find(int customerID)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerID", CustomerID);

            DB.Execute("sproc_tblCustomer_FilterByCustomerID");

            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                mCustomerPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerPhoneNo"]);
                mCustomerFullName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFullName"]);
                mEmailSubscription= Convert.ToBoolean(DB.DataTable.Rows[0]["EmailSubscription"]);
                return true;
            }
             
            else
            {
                return false;
            }
        }
    }
}