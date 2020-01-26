using System.Globalization;
using System.Threading;

//Customer class has three public properties - Name(string),
//ContactPhone(string) and Revenue(decimal).
//Implement for the Customer's objects the capability of
//a various string representation. For example, the
//object with the Name = "Jeffrey Richter",
//Revenue = 1000000, ContactPhone = "+1 (425) 555-0100"
//can have the following string representation:
//Customer record: Jeffrey Richter, 1,000,000.00, +1 (425) 555-0100
//Customer record: +1 (425) 555-0100
//Customer record: Jeffrey Richter, 1,000,000.00
//Customer record: Jeffrey Richter
//Customer record: 1000000, etc.Add to Customer
//class an additional formatting capability,
//that is not provided by the class (Customer class do not change).
//Develop unit tests.
namespace Task1
{
    public class CustomerClass
    {        
        NumberFormatInfo f = new CultureInfo("en-US", false).NumberFormat;
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public decimal Revenue { get; set; }
        public string GetFullInformation()
        {
            return string.Format("{0}, {1}, {2}",Name, Revenue.ToString("N", f), ContactPhone);
        }
        public string GetPhone()
        {
            return string.Format("{0}",ContactPhone);
        }
        public string GetName()
        {
            return string.Format("{0}", Name);
        }
        public string GetNameAndRevenue()
        {
            return string.Format("{0}, {1}", Name,Revenue);
        }
    }
}
