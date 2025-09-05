
namespace C__Learning.Ref
{
    internal class Methods
    {
        public static void Show() => Console.WriteLine("No data");

        public static void Show(string name) => Console.WriteLine(name);

        public static void Show(int age) => Console.WriteLine(age);

        public static void Run()
        {
            Show();               // No data
            Show("Ammar");        // Ammar
            Show(28);             // 28
        }
    }
}
