namespace ConsoleApp109
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region MYREGION
            Console.WriteLine("Enter The Number: ");
            Double Input = Convert.ToDouble(Console.ReadLine());
            if (Input % 2 == 0)
            {
                Console.WriteLine("EVen NUMBER");

            }
            else
            {
                Console.WriteLine("Odd NUMBER");
            }
            #endregion
         
        }
    }
}