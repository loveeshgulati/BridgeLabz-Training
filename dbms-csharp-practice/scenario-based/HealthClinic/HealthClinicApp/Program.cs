 class Program
    {
        static void Main(string[] args)
        {
            ClinicMenu menu = new ClinicMenu();

            while (true)
            {
                menu.ShowMenu();
                Console.WriteLine();
            }
        }
    }