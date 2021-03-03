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

        public bool Find(object stockID)
        {

            mStockID = 21;
            mStockAvailability = 10;
            mStockDescription = "King Kong";
            mStockPrice = 9.99;
            mIsBeingRestocked = true;

            return true;
        }
    }
}