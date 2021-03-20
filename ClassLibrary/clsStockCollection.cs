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


        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStock_SelectAll");

            RecordCount = DB.Count;

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







            /*clsStock testItem = new clsStock();

            testItem.StockID = 1;
            testItem.StockAvailability = 10;
            testItem.StockDescription = "Comic Book";
            testItem.StockPrice = 9.99;
            testItem.IsBeingRestocked = true;

            mStockList.Add(testItem);

            testItem = new clsStock();
            testItem.StockID = 2;
            testItem.StockAvailability = 12;
            testItem.StockDescription = "Better Comic Book";
            testItem.StockPrice = 11.99;
            testItem.IsBeingRestocked = false;

            mStockList.Add(testItem);*/


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
        public object ThisStock { get; set; }
    }
}
