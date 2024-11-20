namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intBox = new Box<int>();
            intBox.SetValue(20);
            Console.WriteLine("Value: " + intBox.GetValue());

            var stringBox = new Box<string>();
            stringBox.SetValue("manana");
            Console.WriteLine("Value: " + stringBox.GetValue());

            var intBox1 = new Box<int>();
            intBox.SetValue(100);
            Console.WriteLine("Value (after SetValue): " + intBox.GetValue());

            var stringBox1 = new Box<string>();
            stringBox.SetValue("Temo");
            Console.WriteLine("Value (after SetValue): " + stringBox.GetValue());

            var stringList = new List<string> { "Manana", "Anastasia", "Toma", "Mate" };
            var intList = new List<int> { 1, 2, 3, 4 };
            int intCount = Utility.CountElementsAsInt(intList);
            int intstringCount = Utility.CountElementsAsInt(stringList);
            Console.WriteLine($"Intcount: {intCount}");
            Console.WriteLine($"Stringcount: {intstringCount}");



        }
    }

}
