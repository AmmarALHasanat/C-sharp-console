using C__Learning.OOP.Abstraction;
using C__Learning.OOP.Inheritance;


namespace C__Learning.ExceptionHandling
{
    internal class Program : ProgramBase
    {
        public override void Run()
        {
            ErrorHandler.Execute(() =>
            {
                Person p = new Person { Name = "Ali" };
                Student s = (Student)p;
            });

            try
            {
                var processor = new PaymentService();
                processor.ProcessPayment();
            }
            catch (PaymentFailedException ex)
            {
                Logger.Exception(ex);
                Console.WriteLine($"Error: {ex.Message}");

            }
            finally
            {
                Console.WriteLine("Payment attempt complete.");
            }

        }
    }
}
