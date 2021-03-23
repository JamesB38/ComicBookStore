using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStockCollection {

        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection allStock = new clsStockCollection();

            List<clsStock> testList = new List<clsStock>();
            clsStock testItem = new clsStock();

            testItem.StockID = 1;
            testItem.StockAvailability = 10;
            testItem.StockDescription = "Comic Book";
            testItem.StockPrice = 9.99;
            testItem.IsBeingRestocked = true;

            testList.Add(testItem);

            allStock.StockList = testList;

            Assert.AreEqual(allStock.StockList, testList);
        }
        

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection allStock = new clsStockCollection();

            
            clsStock testItem = new clsStock();

            testItem.StockID = 1;
            testItem.StockAvailability = 10;
            testItem.StockDescription = "Comic Book";
            testItem.StockPrice = 9.99;
            testItem.IsBeingRestocked = true;

            allStock.ThisStock = testItem;

            Assert.AreEqual(allStock.ThisStock, testItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection allStock = new clsStockCollection();

            List<clsStock> testList = new List<clsStock>();
            clsStock testItem = new clsStock();

            testItem.StockID = 1;
            testItem.StockAvailability = 10;
            testItem.StockDescription = "Comic Book";
            testItem.StockPrice = 9.99;
            testItem.IsBeingRestocked = true;

            testList.Add(testItem);

            allStock.StockList = testList;

            Assert.AreEqual(allStock.Count, testList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection allStock = new clsStockCollection();

            clsStock testItem = new clsStock();

            Int32 PrimaryKey = 0; 

            testItem.StockID = 1;
            testItem.StockAvailability = 10;
            testItem.StockDescription = "Comic Book";
            testItem.StockPrice = 9.99;
            testItem.IsBeingRestocked = true;

            allStock.ThisStock = testItem;

            PrimaryKey = allStock.Add();

            testItem.StockID = PrimaryKey;

            allStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(allStock.ThisStock, testItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection allStock = new clsStockCollection();

            clsStock testItem = new clsStock();

            Int32 PrimaryKey = 0;

            testItem.StockAvailability = 10;
            testItem.StockDescription = "Comic Book";
            testItem.StockPrice = 9.99;
            testItem.IsBeingRestocked = true;

            allStock.ThisStock = testItem;

            PrimaryKey = allStock.Add();

            testItem.StockID = PrimaryKey;


            testItem.StockAvailability = 20;
            testItem.StockDescription = "better comic book";
            testItem.StockPrice = 13.99;
            testItem.IsBeingRestocked = false;

            allStock.ThisStock = testItem;

            allStock.Update();

            allStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(allStock.ThisStock, testItem);
        }


    }

    
}
