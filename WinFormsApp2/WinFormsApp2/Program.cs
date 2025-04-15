namespace WinFormsApp2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            print();
            Console.Write("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("6");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static void print()
        {
            Console.Write("Enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<x;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write("6");
                }
                Console.WriteLine();
            }
        }
    }
}