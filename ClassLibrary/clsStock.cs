using System;

namespace ClassLibrary
{
    public class clsStock
    {


        private Int32 mStockID;
        private Int32 mStockAvailability;
        private String mStockDescription;
        private Double mStockPrice;
        private bool mIsBeingRestocked;

        public Int32 StockID
        {
            get
            {
                return mStockID;
            }

            set
            {
                mStockID = value;
                
            }

        }

        public Int32 StockAvailability
        {
            get
            {
                return mStockAvailability;
            }

            set
            {
                mStockAvailability = value;
            }
        }
        public string StockDescription
        {
            get
            {
                return mStockDescription;
            }

            set
            {
                mStockDescription = value;
            }
        }
        public double StockPrice
        {
            get
            {
                return mStockPrice;
            }

            set
            {
                mStockPrice = value;
            }
        }
        public bool IsBeingRestocked
        {
            get
            {
                return mIsBeingRestocked;
            }

            set
            {
                mIsBeingRestocked = value;
            }
        }

        public bool Find(int StockID)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StockID", StockID);

            DB.Execute("sproc_tblStock_FilterByStockID");

            if(DB.Count == 1)
            {
                mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StockID"]);
                mStockAvailability = Convert.ToInt32(DB.DataTable.Rows[0]["StockAvailability"]);
                mStockDescription = Convert.ToString(DB.DataTable.Rows[0]["StockDescription"]);
                mStockPrice = Convert.ToDouble(DB.DataTable.Rows[0]["StockPrice"]);
                mIsBeingRestocked = Convert.ToBoolean(DB.DataTable.Rows[0]["IsBeingRestocked"]);

                return true;
                
            }
            else
            {
                return false;
            }

        }

        public string Valid(string StockAvailability, string StockDescription, string StockPrice)
        {
            return "";
        }
    }
}