namespace caculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string isare = Convert.ToString(Console.ReadLine());

            if (isare == "+" || isare == "topla")
            {
                Console.WriteLine(num1 + num2);

            }
            else if (isare == "*" || isare == "vur")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (isare == "/" || isare == "böl")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("0-a bölme emilliyyatı yoxdur");

                }
                else
                {
                    Console.WriteLine(num1 / num2);
                }

            }
            else if (isare == "-" || isare == "çıx")
            {
                Console.WriteLine(num1 - num2);
            }*/









            int ortalama = int.Parse(Console.ReadLine());
            
            if (ortalama >= 0 && ortalama <= 100)
            {
                if (ortalama >= 51 && ortalama < 61)
                {
                    Console.WriteLine("E");
                }
                else if (ortalama >= 61 && ortalama < 71)
                {
                    Console.WriteLine("D");
                }
                else if (ortalama >= 71 && ortalama < 81)
                {
                    Console.WriteLine("C");
                }
                else if (ortalama >= 81 && ortalama < 91)
                {
                    Console.WriteLine("B");
                }
                else if (ortalama >= 91 && ortalama <= 100)
                {
                    Console.WriteLine("A");
                }
                else
                {
                    Console.WriteLine("F");
                }
            }
            else
            {
                Console.WriteLine("Duzgun daxil edileyib");
            }
            

        }
    }
}