using DBApproach.Models;

namespace DBApproach
{
    class Program
    {
        public static void Main(string[] args)
        {
            StoreContext storeContext = new StoreContext();

            foreach(var customer in storeContext.Customers)
            {
                Console.WriteLine("{0} - {1}", customer.Companyname, customer.Contactname);
            }

            Console.ReadKey();
        }
    }
}
