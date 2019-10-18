using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordHashing
{
    class Program
    {
        public static string username;
        public static string password;
        public static Dictionary<string, string> Users = new Dictionary<string, string>();

        static void Main()
        {
            Run();
        }

        private static void Run()
        {
            Console.WriteLine("Select an option:" +
                "\n1. Establish an Account" +
                "\n2. Authenticate a user" +
                "\n3. Exit the System" +
                "\n4. Print User Directory");
            int response = int.Parse(Console.ReadLine());
            if (response == 3)
                Exit();
            if (response == 1)
            {
                accountCreate();
                Run();
            }
            if (response == 2)
            {
                accountAuthenticate();
                Run();
            }
            if (response == 4)
            {
                printUsers();
                Run();
            }

            else
                Run();
        }

        private static void printUsers()
        {
            foreach (object thing in Users)
                Console.WriteLine(thing);
        }

        private static void accountAuthenticate()
        {
            int valid = 0;
            Console.Write("Please Enter your UserName: ");
            string usercheck = Console.ReadLine();
            Console.Write("Please enter your Password: ");
            string passcheck = HashDirectory.Hash(ReadPassword());
            if (Users.ContainsKey(usercheck))
            {
                foreach(KeyValuePair<string, string> k in Users)
                {
                    if (k.Key == usercheck && k.Value == passcheck)
                        {
                            valid++;
                            Console.WriteLine("User has been Authenticated. Welcome Back.");

                        }

                }
                if (valid == 0)
                    Console.WriteLine("User has NOT been Authenticated");
            }
            else
                Console.WriteLine("User does not exist");
        }

        private static void accountCreate()
        {
            Console.Write("Please enter a UserName: ");
            username = Console.ReadLine();
            if(Users.ContainsKey(username))
            {
                Console.WriteLine("User already exists");
                accountCreate();
            }          
            Console.Write("Please enter a Password: ");
            password = HashDirectory.Hash(ReadPassword());
            //Console.WriteLine($"UserName: {username} \n Password: {password}");
            Users.Add(username, password);
        }

        private static void Exit()
        {
            System.Environment.Exit(0);
        }
        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        // remove one character from the list of password characters
                        password = password.Substring(0, password.Length - 1);
                        // get the location of the cursor
                        int pos = Console.CursorLeft;
                        // move the cursor to the left by one character
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        // replace it with space
                        Console.Write(" ");
                        // move the cursor to the left by one character again
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }

            // add a new line because user pressed enter at the end of their password
            Console.WriteLine();
            return password;
        }

    }
}
