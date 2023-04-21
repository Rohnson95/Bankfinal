namespace TempBankV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.AccountChecker();
        }
    }
    internal class Menu
    {
        protected int login; //This is used to store the index of the person logged in

        public int Login
        {
            get { return login; }
            set { login = value; }
        }
        //Contains Every accounts funds using get;set. I realised pretty late that a smarter solution would be to store all values in a jagged array instead

        public void AccountChecker()
        {
            string[] user = { "ROBERT", "WILLIAM", "MARIA", "NEIL", "CHRISTINA" };
            string[] password = { "1234", "5678", "8135", "5411", "2411" };
            bool isTrue = true;
            Console.WriteLine("Welcome to ChasBank, To log in - Press Enter");
            Console.ReadKey();
            while (isTrue)
            {
                Console.Write("Användarnamn:");
                string anv = Console.ReadLine().ToUpper();
                Console.Write("Pin: ");
                string pin = Console.ReadLine();

                for (int i = 0; i < 5; i++)
                {
                    if (anv == user[i] && pin == password[i])
                    {
                        Console.WriteLine("Välkommen {0}", user[i]);
                        Console.ReadKey();
                        isTrue = false;
                        Login = i;
                        FirstMenu();
                    }
                }
            }
        } //Does a crossreference to the strings within the arrays to check if the login is correct
        public void FirstMenu()
        {
            string[] mainMenu = { "1. Se över dina konton och saldo", "2. Överföring mellan konton", "3. Ta ut pengar" };
            bool selection = true;
            bool isTrue = true;
            int index = 0;
            do
            {
                Console.Clear();
                for (int i = 0; i < mainMenu.Length; i++)
                {
                    if (i == index)
                    {
                        Console.Write("->");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    Console.WriteLine(mainMenu[i]);
                }
                Console.ResetColor();
                Console.WriteLine("Logga Ut [L] Avsluta [A]");
                index = input(index);
            } while (selection);

            int input(int index)
            {
                ConsoleKey keypressed = Console.ReadKey().Key;

                if (keypressed == ConsoleKey.DownArrow)
                {
                    index += 1;
                }
                else if (keypressed == ConsoleKey.UpArrow)
                {
                    index -= 1;
                }
                else if (keypressed == ConsoleKey.Enter)
                {
                    if (index == 0)
                    {
                        UserAccount();
                    }
                    else if (index == 1)
                    {
                        Transfers();
                    }
                    else if (index == 2)
                    {
                        Console.Clear();
                        Withdraw();
                    }
                    else if (index == 3)
                    {
                        Environment.Exit(0);
                    }
                }
                else if (keypressed == ConsoleKey.L)
                {
                    Console.Clear();
                    AccountChecker();
                }
                else if (keypressed == ConsoleKey.A)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }

                if (index <= -1)
                {
                    index = 0;
                }
                else if (index > 2)
                {
                    index = 2;
                }
                return index;
            }

        } //This is the mainmenu, here's where you navigate through what you want to do in the bank 
        public void UserAccount() //Using jagged arrays to display the accounts and funds available for the account that is currently logged in. Here is where the get;set for login plays a big part.
        {
            int index = 0;
            bool selection = true;
            do
            {
                Console.Clear();
                for (int i = 0; i < Assets.Accounts[Login].Length; i++)
                {
                    if (i == index)
                    {
                        Console.Write(">");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.WriteLine(Assets.Accounts[Login][i]);
                }
                Console.ResetColor();
                Console.WriteLine("Gå Tillbaka [←] Logga ut [L]  Avsluta [A]");
                index = input(index);
            } while (selection);

            int input(int index)
            {
                ConsoleKey keypressed = Console.ReadKey().Key;

                if (keypressed == ConsoleKey.DownArrow)
                {
                    index += 1;
                }
                else if (keypressed == ConsoleKey.UpArrow)
                {
                    index -= 1;
                }
                else if (keypressed == ConsoleKey.Enter)
                {
                    if (index == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("{0:N2} Kr", Assets.Funds[Login][0]);
                        Console.ReadKey();
                    }
                    else if (index == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("{0:N2} Kr", Assets.Funds[Login][1]);
                        Console.ReadKey();
                    }
                    else if (index == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("{0:N2} Kr", Assets.Funds[Login][2]);
                        Console.ReadKey();
                    }
                    else if (index == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("{0:N2} Kr", Assets.Funds[Login][3]);
                        Console.ReadKey();
                    }
                    else if (index == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("{0:N2} Kr", Assets.Funds[Login][4]);
                        Console.ReadKey();
                    }

                }
                else if (keypressed == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    FirstMenu();
                }
                else if (keypressed == ConsoleKey.L)
                {
                    Console.Clear();
                    FirstMenu();
                }
                else if (keypressed == ConsoleKey.A)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
                if (index <= -1)
                {
                    index = 0;
                }
                else if (index > Assets.Accounts[Login].Length - 1)
                {
                    index = Assets.Accounts[Login].Length - 1;
                }
                return index;
            }
        }
        public void Transfers()
        {
            string[] menu = { "1. Överför mellan konton" };
            bool selection = true;
            int index = 0;
            do
            {
                Console.Clear();
                for (int i = 0; i < menu.Length; i++)
                {
                    if (i == index)
                    {
                        Console.Write(">");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.WriteLine(menu[i]);
                }
                Console.ResetColor();
                Console.WriteLine("Tryck [←] för att gå tillbaka");
                index = input(index);
            } while (selection);

            int input(int index)
            {
                ConsoleKey keypressed = Console.ReadKey().Key;

                if (keypressed == ConsoleKey.DownArrow)
                {
                    index += 1;
                }
                else if (keypressed == ConsoleKey.UpArrow)
                {
                    index -= 1;
                }
                else if (keypressed == ConsoleKey.Enter)
                {
                    if (index == 0)
                    {
                        Console.Clear();
                        TransferToSelf();
                    }
                    else if (index == 1)
                    {
                        Console.Clear();

                    }
                }
                else if (keypressed == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    FirstMenu();
                }
                if (index <= -1)
                {
                    index = 0;
                }
                else if (index > 0)
                {
                    index = 0;
                }
                return index;

            }
        } //I made a menu for this even though there's only one option currently, this is because I had the plan to have transfers available between the users of the bank. I realised that i needed to change the entire program for this
        public void TransferToSelf()
        {
            bool selection = true;
            int index = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Vilket Konto vill du överföra från?");
                for (int i = 0; i < Assets.Accounts[Login].Length; i++)
                {
                    if (i == index)
                    {
                        Console.Write(">");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    Console.WriteLine(Assets.Accounts[Login][i]);
                }
                Console.ResetColor();
                index = input(index);
            } while (selection);
            int input(int index)
            {
                ConsoleKey keypressed = Console.ReadKey().Key;

                if (keypressed == ConsoleKey.DownArrow)
                {
                    index += 1;
                }
                else if (keypressed == ConsoleKey.UpArrow)
                {
                    index -= 1;
                }
                else if (keypressed == ConsoleKey.Enter)
                {
                    if (index == 0)
                    {
                        Console.WriteLine("Välj ett konto att överföra till:");
                        for (int i = 1; i < Assets.Accounts[Login].Length; i++)
                        {
                            Console.WriteLine(Assets.Accounts[Login][i]);

                        }
                        string input = Console.ReadLine();
                        decimal moneyInput;
                        switch (input)
                        {
                            case "2":
                                Console.WriteLine("Privatkonto => Sparkonto");
                                Console.Write("Summa: ");
                                moneyInput = decimal.Parse(Console.ReadLine());
                                Assets.Funds[Login][0] -= moneyInput;
                                Assets.Funds[Login][1] += moneyInput;
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                            case "3":
                                if (Login == 0)
                                {
                                    Console.WriteLine("Ogiltig inmatning.");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Privatkonto => Semesterkonto");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    Assets.Funds[Login][0] -= moneyInput;
                                    Assets.Funds[Login][2] += moneyInput;
                                    Console.WriteLine("Klart!");
                                    Console.ReadKey();
                                    FirstMenu();
                                }
                                break;
                            case "4":
                                if (Login == 0 || Login == 1)
                                {
                                    Console.WriteLine("Ogiltig inmatning.");
                                }
                                else
                                {
                                    Console.WriteLine("Privatkonto => Matkonto");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    Assets.Funds[Login][0] -= moneyInput;
                                    Assets.Funds[Login][3] += moneyInput;
                                    Console.ReadKey();
                                    FirstMenu();
                                }
                                break;
                            case "5":
                                if (Login == 0 || Login == 1 || Login == 2)
                                {
                                    Console.WriteLine("Ogiltig inmatning.");
                                }

                                else
                                {
                                    Console.WriteLine("Privatkonto => {0}", Assets.Accounts[Login][4]);
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    Assets.Funds[Login][0] -= moneyInput;
                                    Assets.Funds[Login][4] += moneyInput;
                                    Console.WriteLine("Klart!");
                                    Console.ReadKey();
                                    FirstMenu();

                                }
                                break;

                        }
                    }
                    else if (index == 1)
                    {
                        Console.WriteLine("Välj ett konto att överföra till:");
                        for (int i = 0; i < Assets.Accounts[Login].Length; i++)
                        {

                            Console.WriteLine(Assets.Accounts[Login][i]);
                        }
                        string? input = Console.ReadLine();
                        decimal moneyInput;
                        switch (input)
                        {
                            case "1":
                                Console.WriteLine("Sparkonto => Privatkonto");
                                Console.Write("Summa: ");
                                moneyInput = decimal.Parse(Console.ReadLine());
                                Assets.Funds[Login][1] -= moneyInput;
                                Assets.Funds[Login][0] += moneyInput;
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                            case "2":
                                Console.WriteLine("Ogiltig Inmatning");
                                Console.ReadKey();
                                break;
                            case "3":
                                if (Login == 0)
                                {
                                    Console.WriteLine("Ogiltig inmatning");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Sparkonto => Semesterkonto");
                                    Console.Write("Summa: ");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    Assets.Funds[Login][1] -= moneyInput;
                                    Assets.Funds[Login][2] += moneyInput;
                                    Console.WriteLine("Klart!");
                                    Console.ReadKey();
                                    FirstMenu();
                                }
                                break;
                            case "4":
                                if (Login == 0 || Login == 1)
                                {
                                    Console.WriteLine("Ogiltid inmatning");
                                    Console.ReadKey();
                                }
                                else
                                {
                                    Console.WriteLine("Sparkonto => Matkonto");
                                    Console.Write("Summa: ");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    Assets.Funds[Login][1] -= moneyInput;
                                    Assets.Funds[Login][3] += moneyInput;
                                    Console.WriteLine("Klart!");
                                    Console.ReadKey();
                                    FirstMenu();
                                }
                                break;
                            case "5":
                                if (Login == 0 || Login == 1 || Login == 2)
                                {
                                    Console.WriteLine("Ogiltig inmatning");
                                    Console.ReadKey();
                                }

                                else
                                {
                                    Console.WriteLine("{0} => {1}", Assets.Accounts[Login][1], Assets.Accounts[Login][4]);
                                    Console.Write("Summa: ");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    Assets.Funds[Login][1] -= moneyInput;
                                    Assets.Funds[Login][4] += moneyInput;
                                    Console.WriteLine("Klart!");
                                    Console.ReadKey();
                                    FirstMenu();
                                }
                                break;
                        }



                    }
                    else if (index == 2)
                    {
                        Console.WriteLine("Välj ett konto att överföra till:");
                        for (int i = 0; i < Assets.Accounts[Login].Length; i++)
                        {

                            Console.WriteLine(Assets.Accounts[Login][i]);
                        }
                        string? input = Console.ReadLine();
                        decimal moneyInput;
                        switch (input)
                        {
                            case "1":
                                Console.WriteLine("Semesterkonto => Privatkonto");
                                Console.Write("Summa: ");
                                moneyInput = decimal.Parse(Console.ReadLine());
                                Assets.Funds[Login][2] -= moneyInput;
                                Assets.Funds[Login][0] += moneyInput;
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                            case "2":
                                Console.WriteLine("Semesterkonto => Sparkonto");
                                Console.Write("Summa: ");
                                moneyInput = decimal.Parse(Console.ReadLine());
                                Assets.Funds[Login][2] -= moneyInput;
                                Assets.Funds[Login][1] += moneyInput;
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                            case "3":
                                Console.WriteLine("Ogiltig inmatning");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                            case "4":
                                Console.WriteLine("Semesterkonto => Matkonto");
                                Console.Write("Summa: ");
                                moneyInput = decimal.Parse(Console.ReadLine());
                                Assets.Funds[Login][2] -= moneyInput;
                                Assets.Funds[Login][3] += moneyInput;
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                            case "5":
                                Console.WriteLine("Semesterkonto => {0}", Assets.Accounts[Login][4]);
                                Console.Write("Summa: ");
                                moneyInput = decimal.Parse(Console.ReadLine());
                                Assets.Funds[Login][2] -= moneyInput;
                                Assets.Funds[Login][4] += moneyInput;
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                        }
                    }
                    else if (index == 3)
                    {
                        Console.WriteLine("Välj ett konto att överföra till:");
                        for (int i = 0; i < Assets.Accounts[Login].Length; i++)
                        {

                            Console.WriteLine(Assets.Accounts[Login][i]);
                        }
                        string? input = Console.ReadLine();
                        decimal moneyInput;
                        switch (input)
                        {
                            case "1":
                                Console.WriteLine("Matkonto => Privatkonto");
                                Console.Write("Summa: ");
                                moneyInput = decimal.Parse(Console.ReadLine());
                                Assets.Funds[Login][3] -= moneyInput;
                                Assets.Funds[Login][0] += moneyInput;
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                                break;

                            case "2":
                                Console.WriteLine("Matkonto => Sparkonto");
                                Console.Write("Summa: ");
                                moneyInput = decimal.Parse(Console.ReadLine());
                                Assets.Funds[Login][3] -= moneyInput;
                                Assets.Funds[Login][1] += moneyInput;
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                            case "3":
                                Console.WriteLine("Matkonto => Semesterkonto");
                                Console.Write("Summa: ");
                                moneyInput = decimal.Parse(Console.ReadLine());
                                Assets.Funds[Login][3] -= moneyInput;
                                Assets.Funds[Login][2] += moneyInput;
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                            case "4":
                                Console.WriteLine("Ogiltig inmatning");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                            case "5":
                                Console.WriteLine("Matkonto => {0}", Assets.Accounts[Login][4]);
                                Console.Write("Summa: ");
                                moneyInput = decimal.Parse(Console.ReadLine());
                                Assets.Funds[Login][3] -= moneyInput;
                                Assets.Funds[Login][4] += moneyInput;
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                        }
                    }
                    else if (index == 4)
                    {
                        Console.WriteLine("Välj ett konto att överföra till:");
                        for (int i = 0; i < Assets.Accounts[Login].Length; i++)
                        {

                            Console.WriteLine(Assets.Accounts[Login][i]);
                        }
                        string? input = Console.ReadLine();
                        decimal moneyInput;
                        switch (input)
                        {
                            case "1":
                                Console.WriteLine("{0} => Privatkonto", Assets.Accounts[Login][4]);
                                Console.Write("Summa: ");
                                moneyInput = decimal.Parse(Console.ReadLine());
                                Assets.Funds[Login][4] -= moneyInput;
                                Assets.Funds[Login][0] += moneyInput;
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                            case "2":
                                Console.WriteLine("{0} => Sparkonto", Assets.Accounts[Login][4]);
                                Console.Write("Summa: ");
                                moneyInput = decimal.Parse(Console.ReadLine());
                                Assets.Funds[Login][4] -= moneyInput;
                                Assets.Funds[Login][1] += moneyInput;
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                            case "3":
                                Console.WriteLine("{0} => Privatkonto", Assets.Accounts[Login][4]);
                                Console.Write("Summa: ");
                                moneyInput = decimal.Parse(Console.ReadLine());
                                Assets.Funds[Login][4] -= moneyInput;
                                Assets.Funds[Login][2] += moneyInput;
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                            case "4":
                                Console.WriteLine("{0} => Privatkonto", Assets.Accounts[Login][4]);
                                Console.Write("Summa: ");
                                moneyInput = decimal.Parse(Console.ReadLine());
                                Assets.Funds[Login][4] -= moneyInput;
                                Assets.Funds[Login][3] += moneyInput;
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                            case "5":
                                Console.WriteLine("Ogiltig inmatning");
                                Console.ReadKey();
                                FirstMenu();
                                break;
                        }
                    }
                }

                if (index <= -1)
                {
                    index = 0;
                }
                else if (index > Assets.Accounts[Login].Length - 1)
                {
                    index = Assets.Accounts[Login].Length - 1;
                }
                return index;
            }
        } //Manages the actual transfers and removal of funds from one account and adding funds to a second one. 

        public void Withdraw()
        {
            string[] user = { "Robert", "William", "Maria", "Neil", "Christina" };
            string[] password = { "1234", "5678", "8135", "5411", "2411" };
            bool selection = true;
            bool isTrue = true;
            int index = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Vilket konto vill du ta ut pengar ifrån?");
                for (int i = 0; i < Assets.Accounts[Login].Length; i++)
                {
                    if (i == index)
                    {
                        Console.Write(">");
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.WriteLine(Assets.Accounts[Login][i]);

                }
                Console.ResetColor();
                Console.WriteLine("Tryck [←] för att gå tillbaka");
                index = input(index);
            }
            while (selection);
            int input(int index)
            {
                ConsoleKey keypressed = Console.ReadKey().Key;

                if (keypressed == ConsoleKey.DownArrow)
                {
                    index += 1;
                }
                else if (keypressed == ConsoleKey.UpArrow)
                {
                    index -= 1;
                }
                else if (keypressed == ConsoleKey.Enter)
                {
                    if (index == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Hur mycket pengar vill du ta ut?");
                        Console.Write("===>");
                        decimal moneyInput = decimal.Parse(Console.ReadLine());
                        if (moneyInput > Assets.Funds[Login][0])
                        {
                            Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Assets.Funds[Login][0]);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("Pin:");
                            string? pin = Console.ReadLine();
                            if (pin == password[Login])
                            {
                                Assets.Funds[Login][0] -= moneyInput;
                                isTrue = false;
                                Console.WriteLine("Överför");
                                Thread.Sleep(1000);
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                            }
                        }
                    }
                    else if (index == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Hur mycket pengar vill du ta ut?");
                        Console.Write("===>");
                        decimal moneyInput = decimal.Parse(Console.ReadLine());
                        if (moneyInput > Assets.Funds[Login][1])
                        {
                            Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Assets.Funds[Login][1]);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("Pin:");
                            string? pin = Console.ReadLine();
                            if (pin == password[Login])
                            {
                                Assets.Funds[Login][1] -= moneyInput;
                                isTrue = false;
                                Console.WriteLine("Överför");
                                Thread.Sleep(1000);
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                            }
                        }
                    }
                    else if (index == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Hur mycket pengar vill du ta ut?");
                        Console.Write("===>");
                        decimal moneyInput = decimal.Parse(Console.ReadLine());
                        if (moneyInput > Assets.Funds[Login][2])
                        {
                            Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Assets.Funds[Login][2]);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("Pin:");
                            string? pin = Console.ReadLine();
                            if (pin == password[Login])
                            {
                                Assets.Funds[Login][2] -= moneyInput;
                                isTrue = false;
                                Console.WriteLine("Överför");
                                Thread.Sleep(1000);
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                            }
                        }
                    }
                    else if (index == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Hur mycket pengar vill du ta ut?");
                        Console.Write("===>");
                        decimal moneyInput = decimal.Parse(Console.ReadLine());
                        if (moneyInput > Assets.Funds[Login][3])
                        {
                            Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Assets.Funds[Login][0]);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("Pin:");
                            string? pin = Console.ReadLine();
                            if (pin == password[Login])
                            {
                                Assets.Funds[Login][3] -= moneyInput;
                                isTrue = false;
                                Console.WriteLine("Överför");
                                Thread.Sleep(1000);
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                            }
                        }
                    }
                    else if (index == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Hur mycket pengar vill du ta ut?");
                        Console.Write("===>");
                        decimal moneyInput = decimal.Parse(Console.ReadLine());
                        if (moneyInput > Assets.Funds[Login][4])
                        {
                            Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Assets.Funds[Login][4]);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.Write("Pin:");
                            string? pin = Console.ReadLine();
                            if (pin == password[Login])
                            {
                                Assets.Funds[Login][4] -= moneyInput;
                                isTrue = false;
                                Console.WriteLine("Överför");
                                Thread.Sleep(1000);
                                Console.WriteLine("Klart!");
                                Console.ReadKey();
                                FirstMenu();
                            }
                        }
                    }

                }
                else if (keypressed == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    FirstMenu();
                }
                if (index <= -1)
                {
                    index = 0;
                }
                else if (index > Assets.Accounts[Login].Length - 1)
                {
                    index = Assets.Accounts[Login].Length - 1;
                }
                return index;
            }
        } //Withdraws funds from a selected account
    }
}
public class Assets
{
    protected static string[][] accounts = new string[][] // I use a jagged array to more easily print different options depending on the account logged in, This is done by having the index connected to a get;set; 
    {
            new string[] { "1. PrivatKonto", "2. Sparkonto" },
            new string[] { "1. PrivatKonto", "2. Sparkonto", "3. Semesterkonto" },
            new string[] { "1. PrivatKonto", "2. Sparkonto", "3. Semesterkonto","4. Matkonto" },
            new string[] { "1. PrivatKonto", "2. Sparkonto", "3. Semesterkonto","4. Matkonto", "5. Gitarrkonto" },
            new string[] { "1. PrivatKonto", "2. Sparkonto", "3. Semesterkonto", "4. Matkonto", "5. Garnkonto" }
    };
    protected static decimal[][] funds = new decimal[][]
    {
        new decimal[] { 25000, 101000}, //Robert
        new decimal[] {50000, 125000,33000}, //William
        new decimal[] {35000,150000,40000,5000}, //Maria
        new decimal[]{40000,200000,45000,3000,23300}, //Neil
        new decimal[]{120000,500000,300000,3000,1500} //Christina
    };
    public static decimal[][] Funds
    {
        get { return funds; }
    }
    public static string[][] Accounts
    {
        get { return accounts; }
    }
}