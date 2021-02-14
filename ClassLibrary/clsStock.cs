namespace ClassLibrary
{
    public class clsStock
    {
        public int StockID { get; set; }
        public int StockAvailability { get; set; }
        public string StockDescription { get; set; }
        public double StockPrice { get; set; }
        public bool IsBeingRestocked { get; set; }
    }
}