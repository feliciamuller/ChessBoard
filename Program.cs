namespace ChessBoard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Skriv in en siffra");
            int number = Int32.Parse(Console.ReadLine());

            //Code to show the squares
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string black = "◼︎";
            string white = "◻︎";
            

            //Outer loop to run the inner loop
            for (int outerLoop = 0; outerLoop < number; outerLoop++)

            {

                //The inner loop prints white and black squares depending on the conditions
                for (int innerLoop = 0; innerLoop < number; innerLoop++)
                {

                    //Check conditions
                    if (outerLoop % 2 == innerLoop % 2)
                    {
                        Console.Write(black);
                    }
            
                    else
                    {
                        Console.Write(white);
                    }
      

                }

                //Empty line to start a new row
                Console.WriteLine();
                    
            }

           







        }
    }
}