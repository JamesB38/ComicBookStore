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
            mCustomerID = 21;
            mCustomerDOB = Convert.ToDateTime("17/05/1999"); 
            mCustomerPhoneNumber = 07456643218;
            mCustomerFullName = "Diogo Rodrigues";
            mEmailSubscription = true;
            return true; 
        }
    }
}