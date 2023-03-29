
    public static  class Helper
    {
        public static bool Check(string name)
        {
            bool status = true;
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsDigit(name[i]))
                {
                    status = false;
                    Console.WriteLine("You can't enter digit to name");
                }
            }
            if (!char.IsUpper(name[0]))
            {
                status = false; Console.WriteLine("you must enter upper letter");
            }
            return status;
        }

        public static void Words()
        {
            Console.WriteLine("Choose one of the operations");
            Console.WriteLine("1-->Add Shop");
            Console.WriteLine("2-->Show Shop");
            Console.WriteLine("3-->Delete Shop");
            Console.WriteLine("4-->Update shop");
            Console.WriteLine("5-->add product");
            Console.WriteLine("6-->Delete Product");
            Console.WriteLine("7-->Update Product");
            Console.WriteLine("8-->Show Products");
        }
    }

