using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        List<clsStock> mStockList = new List<clsStock>();
        private clsStock mThisStock = new clsStock();


        public clsStockCollection()
        { 
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStock_SelectAll");

            PopulateArray(DB);

        }



        public List<clsStock> StockList {

            get
            {
                return mStockList;
            }

            set
            {
                mStockList = value;
            }

        }

        public Int32 Count {

            get
            {
                return mStockList.Count;
            }
            set
            {

            }

        }
        public clsStock ThisStock {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StockAvailability", mThisStock.StockAvailability);
            DB.AddParameter("@StockDescription", mThisStock.StockDescription);
            DB.AddParameter("@StockPrice", mThisStock.StockPrice);
            DB.AddParameter("@IsBeingRestocked", mThisStock.IsBeingRestocked);

            return DB.Execute("sproc_tblStock_Insert");


        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StockID", mThisStock.StockID);
            DB.AddParameter("@StockAvailability", mThisStock.StockAvailability);
            DB.AddParameter("@StockDescription", mThisStock.StockDescription);
            DB.AddParameter("@StockPrice", mThisStock.StockPrice);
            DB.AddParameter("@IsbeingRestocked", mThisStock.IsBeingRestocked);

            DB.Execute("sproc_tblStock_Update");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@StockID", mThisStock.StockID);

            DB.Execute("sproc_tblStock_Delete");
            
        }

        public void ReportByDescription(string Description)
        {

            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Description", Description);

            DB.Execute("sproc_tblStock_FilterByDescription");

            PopulateArray(DB);

        }

        void PopulateArray(clsDataConnection DB)
        {

            Int32 Index = 0;

            Int32 RecordCount;

            RecordCount = DB.Count;

            mStockList = new List<clsStock>();

            while(Index < RecordCount)
            {
                clsStock AnStock = new clsStock();

                AnStock.StockID = Convert.ToInt32(DB.DataTable.Rows[Index]["StockID"]);
                AnStock.StockAvailability = Convert.ToInt32(DB.DataTable.Rows[Index]["StockAvailability"]);
                AnStock.StockDescription = Convert.ToString(DB.DataTable.Rows[Index]["StockDescription"]);
                AnStock.StockPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["StockPrice"]);
                AnStock.IsBeingRestocked = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsBeingRestocked"]);

                mStockList.Add(AnStock);

                Index++;
            }

        }
    }
}
