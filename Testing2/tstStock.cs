using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstStock
    {

        string StockAvailability = "10";
        string StockDescription = "King Kong";
        string StockPrice = "9.99";


        [TestMethod]
        public void InstanceOk()
        {
            clsStock AnStock = new clsStock();

            Assert.IsNotNull(AnStock);

        }

        [TestMethod]
        public void StockIDOk()
        {
            clsStock AnStock = new clsStock();

            Int32 testData = 1234;

            AnStock.StockID = testData;

            Assert.AreEqual(AnStock.StockID, testData);
        }

        [TestMethod]
        public void StockAvailabilityOk()
        {
            clsStock AnStock = new clsStock();

            Int32 testData = 4321;

            AnStock.StockAvailability = testData;

            Assert.AreEqual(AnStock.StockAvailability, testData);
        }

        [TestMethod]
        public void StockDescriptionOk()
        {
            clsStock AnStock = new clsStock();

            String testData = "This is a really good comic book";

            AnStock.StockDescription = testData;

            Assert.AreEqual(AnStock.StockDescription, testData);
        }

        [TestMethod]
        public void StockPriceOk()
        {
            clsStock AnStock = new clsStock();

            double testData = 9.99;

            AnStock.StockPrice = testData;

            Assert.AreEqual(AnStock.StockPrice, testData);
        }

        [TestMethod]
        public void IsBeingRestockedOk()
        {
            clsStock AnStock = new clsStock();

            Boolean testData = true;

            AnStock.IsBeingRestocked = testData;

            Assert.AreEqual(AnStock.IsBeingRestocked, testData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = true;

            Int32 StockID = 2;

            Found = AnStock.Find(StockID);

            Assert.IsTrue(Found);



        }

        [TestMethod]

        public void TestStockIDFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 1;

            Found = AnStock.Find(StockID);

            if(AnStock.StockID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestStockAvailabilityFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 1;

            Found = AnStock.Find(StockID);

            if (AnStock.StockAvailability != 10)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestStockDescriptionFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 1;

            Found = AnStock.Find(StockID);

            if (AnStock.StockDescription != "Demon Days: X-Men #1")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestStockPriceFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 1;

            Found = AnStock.Find(StockID);

            if (AnStock.StockPrice != 8.99)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void TestIsBeingRestockedFound()
        {
            clsStock AnStock = new clsStock();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StockID = 1;

            Found = AnStock.Find(StockID);

            if (AnStock.IsBeingRestocked != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOk()
        {
            clsStock AnStock = new clsStock();

            string Error = "";

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreEqual(Error, "");

        }

        [TestMethod]

        public void StockAvailabilityExtremeMin()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockAvailability = "-100000";

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StockAvailabilityMinLessOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockAvailability = "-1";

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StockAvailabilityMin()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockAvailability = "0";

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Console.WriteLine(Error);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StockAvailabilityMinPlusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockAvailability = "1";

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StockAvailabilityInvalidDataType()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockAvailability = "ten pounds";

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StockDescriptionMinMinusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockDescription = "";

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StockDescriptionMin()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockDescription = "a";

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StockDescriptionMinPlusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockDescription = "aa";

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StockDescriptionMaxMinusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockDescription = "";

            StockDescription = StockDescription.PadRight(199, 'a');

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StockDescriptionMax()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockDescription = "";

            StockDescription = StockDescription.PadRight(200, 'a');

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StockDescriptionMaxPlusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockDescription = "";

            StockDescription = StockDescription.PadRight(201, 'a');

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StockDescriptionMid()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockDescription = "";

            StockDescription = StockDescription.PadRight(100, 'a');

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void StockDescriptionExtremeMax()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockDescription = "";

            StockDescription = StockDescription.PadRight(1000, 'a');

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void StockPriceExtremeMin()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockPrice = "-100000000";

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreNotEqual(Error, "");
        }

        public void StockPriceMinMinusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockPrice = "-0.01";

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreNotEqual(Error, "");
        }

        public void StockPriceMin()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockPrice = "0.00";

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreEqual(Error, "");
        }

        public void StockPriceMinPlusOne()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockPrice = "0.01";

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreEqual(Error, "");
        }

        public void StockPriceInvalidDataType()
        {
            clsStock AnStock = new clsStock();

            String Error = "";

            string StockPrice = "This is not a price";

            Error = AnStock.Valid(StockAvailability, StockDescription, StockPrice);

            Assert.AreNotEqual(Error, "");
        }





    }
}
