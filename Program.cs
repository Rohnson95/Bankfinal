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
        protected int login;

        public int Login
        {
            get { return login; }
            set { login = value; }

        }
        #region Accounts
        /* Roberts Account */
        protected decimal account1 = 25000;
        public decimal Account1
        {

            get { return account1; }
            set { account1 = value; }
        }
        protected decimal savings1 = 101000;
        public decimal Savings1
        {
            get { return savings1; }
            set { savings1 = value; }
        }
        /* Williams Account */
        protected decimal account2 = 50000;
        public decimal Account2
        {
            get { return account2; }
            set { account2 = value; }

        }

        protected decimal savings2 = 125000;
        public decimal Savings2
        {
            get { return savings2; }
            set { savings2 = value; }
        }
        protected decimal vacation2 = 33000;
        public decimal Vacation2
        {
            get { return vacation2; }
            set { vacation2 = value; }
        }
        /* Marias Account */
        protected decimal account3 = 35000;
        public decimal Account3
        {
            get { return account3; }
            set { account3 = value; }
        }
        protected decimal savings3 = 200000;
        public decimal Savings3
        {
            get { return savings3; }
            set { savings3 = value; }
        }
        protected decimal vacation3 = 45000;
        public decimal Vacation3
        {
            get { return vacation3; }
            set { vacation3 = value; }
        }
        protected decimal food3 = 2500;
        public decimal Food3
        {
            get { return food3; }
            set { food3 = value; }
        }
        // Neils Account
        protected decimal account4 = 65000;
        public decimal Account4
        {
            get { return account4; }
            set { account4 = value; }
        }
        protected decimal savings4 = 250000;
        public decimal Savings4
        {
            get { return savings4; }
            set { savings4 = value; }
        }
        protected decimal vacation4 = 56000;
        public decimal Vacation4
        {
            get { return vacation4; }
            set { vacation4 = value; }
        }
        protected decimal food4 = 3000;
        public decimal Food4
        {
            get { return food4; }
            set { food4 = value; }
        }
        protected decimal guitarAccount4 = 4000;
        public decimal GuitarAccount4
        {
            get { return guitarAccount4; }
            set { guitarAccount4 = value; }
        }
        //Christinas Account
        protected decimal account5 = 85000;
        public decimal Account5
        {
            get { return account5; }
            set { account5 = value; }
        }
        protected decimal savings5 = 123000;
        public decimal Savings5
        {
            get { return savings5; }
            set { savings5 = value; }

        }
        protected decimal vacation5 = 48000;
        public decimal Vacation5
        {
            get { return vacation5; }
            set { vacation5 = value; }
        }
        protected decimal food5 = 1000;
        public decimal Food5
        {
            get { return food5; }
            set { food5 = value; }
        }
        protected decimal yarn5 = 1500;
        public decimal Yarn5
        {
            get { return yarn5; }
            set { yarn5 = value; }
        }
        #endregion


        public void AccountChecker()
        {

            string[] user = { "ROBERT", "WILLIAM", "MARIA", "NEIL", "CHRISTINA" };
            string[] password = { "1234", "5678", "8135", "5411", "2411" };
            bool selection = true;
            bool isTrue = true;
            int index = 0;
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
            /*do
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
                else if (keypressed == ConsoleKey.A)
                {
                    Console.Clear();
                    Environment.Exit(0);
                }

                if (index <= -1)
                {
                    index = 0;
                }
                else if (index > 3)
                {
                    index = 3;
                }
                return index;
            }*/
        }
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

        }
        public void UserAccount()
        {
            string[] robAccountMenu = { "1. PrivatKonto", "2. Sparkonto", "3. Logga Ut", "4. Avsluta" };

            int index = 0;
            decimal[] mainAccount = { 25000, 50000 };
            decimal[] savings = { 101000, 125000 };
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
                        if (Login == 0)
                        {

                            Console.Clear();

                            Console.WriteLine("{0:N2} Kr", Account1);
                            Console.ReadKey();


                            Console.ReadKey();
                        }
                        else if (Login == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("{0:N2} Kr", Account2);
                            Console.ReadKey();

                        }
                        else if (Login == 2)
                        {
                            Console.Clear();

                            Console.WriteLine("{0:N2} Kr", Account3);
                            Console.ReadKey();
                        }
                        else if (Login == 3)
                        {
                            Console.Clear();

                            Console.WriteLine("{0:N2} Kr", Account4);
                            Console.ReadKey();
                        }
                        else if (Login == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("{0:N2} Kr", Account5);
                            Console.ReadKey();
                        }
                    }
                    else if (index == 1)
                    {
                        if (Login == 0)
                        {
                            Console.Clear();

                            Console.WriteLine(Savings1 + " Kr");
                            Console.ReadKey();
                        }
                        else if (Login == 1)
                        {
                            Console.Clear();

                            Console.WriteLine("{0:N2} Kr", Savings2);
                            Console.ReadKey();
                        }
                        else if (Login == 2)
                        {
                            Console.Clear();

                            Console.WriteLine("{0:N2} Kr", Savings3);
                            Console.ReadKey();
                        }
                        else if (Login == 3)
                        {
                            Console.Clear();

                            Console.WriteLine("{0:N2} Kr", Savings4);
                            Console.ReadKey();
                        }
                        else if (Login == 4)
                        {
                            Console.Clear();

                            Console.WriteLine("{0:N2} Kr", Savings5);
                            Console.ReadKey();
                        }
                    }
                    else if (index == 2)
                    {
                        if (Login == 1)
                        {
                            Console.Clear();

                            Console.WriteLine("{0:N2} Kr", Vacation2);
                            Console.ReadKey();
                        }
                        else if (Login == 2)
                        {
                            Console.Clear();

                            Console.WriteLine("{0:N2} Kr", Vacation3);
                            Console.ReadKey();
                        }
                        else if (Login == 3)
                        {
                            Console.Clear();

                            Console.WriteLine("{0:N2} Kr", Vacation4);
                            Console.ReadKey();
                        }
                        else if (login == 4)
                        {
                            Console.Clear();

                            Console.WriteLine("{0:N2} Kr", Vacation5);
                            Console.ReadKey();
                        }
                    }
                    else if (index == 3)
                    {
                        if (Login == 2)
                        {
                            Console.Clear();

                            Console.WriteLine("{0:N2} Kr", Food3);
                            Console.ReadKey();
                        }
                        else if (Login == 3)
                        {
                            Console.Clear();

                            Console.WriteLine("{0:N2} Kr", Food4);
                            Console.ReadKey();
                        }
                        else if (Login == 4)
                        {
                            Console.Clear();

                            Console.WriteLine("{0:N2} Kr", Food5);
                            Console.ReadKey();
                        }
                    }
                    else if (index == 4)
                    {
                        if (Login == 3)
                        {
                            {
                                Console.Clear();

                                Console.WriteLine("{0:N2} Kr", GuitarAccount4);
                                Console.ReadKey();
                            }
                        }
                        else if (Login == 4)
                        {
                            {
                                Console.Clear();

                                Console.WriteLine("{0:N2} Kr", Yarn5);
                                Console.ReadKey();
                            }
                        }

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
            string[] menu = { "1. Överför mellan konton", "2. Överför Till Annan Användare" };
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
                        TransferToOthers();
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
                else if (index > 1)
                {
                    index = 1;
                }
                return index;

            }
        }
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
                        if (Login == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Sparkonto");
                            string input = Console.ReadLine();
                            decimal moneyInput;

                            switch (input)
                            {

                                case "1":


                                    Console.WriteLine("Privatkonto > SparKonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Account1)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account1);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Account1 = Account1 - moneyInput; Savings1 = Savings1 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;

                            }
                        }
                        else if (Login == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Sparkonto");
                            Console.WriteLine("2. Semesterkonto");
                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("Privatkonto > Sparkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Account2)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account2);
                                        Console.ReadKey();
                                    }
                                    else
                                    {

                                        Account2 = Account2 - moneyInput; Savings2 = Savings2 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;

                                case "2":
                                    Console.WriteLine("Privatkonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Account2)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account2);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Account2 = Account2 - moneyInput; Vacation2 = Vacation2 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                            }
                        }
                        else if (Login == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Sparkonto");
                            Console.WriteLine("2. Semesterkonto");
                            Console.WriteLine("3. Matkonto");
                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("Privatkonto > Sparkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Account3)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account3);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Account3 = Account3 - moneyInput; Savings3 = Savings3 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;

                                case "2":
                                    Console.WriteLine("Privatkonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Account3)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account3);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Account3 = Account3 - moneyInput; Savings3 = Savings3 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;

                                case "3":
                                    Console.WriteLine("Privatkonto > Matkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Account3)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account3);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Account3 = Account3 - moneyInput; Food3 = Food3 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                            }
                        }
                        else if (Login == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Sparkonto");
                            Console.WriteLine("2. Semesterkonto");
                            Console.WriteLine("3. Matkonto");
                            Console.WriteLine("4. Gitarrkonto");
                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("Privatkonto > Sparkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Account4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Account4 = Account4 - moneyInput; Savings4 = Savings4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;

                                case "2":
                                    Console.WriteLine("Privatkonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Account4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {

                                        Account4 = Account4 - moneyInput; Savings4 = Savings4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;

                                case "3":
                                    Console.WriteLine("Privatkonto > Matkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Account4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Account4 = Account4 - moneyInput; Food4 = Food4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("Privatkonto > Gitarrkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Account4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Account4 = Account4 - moneyInput; GuitarAccount4 = GuitarAccount4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                            }
                        }
                        else if (Login == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Sparkonto");
                            Console.WriteLine("2. Semesterkonto");
                            Console.WriteLine("3. Matkonto");
                            Console.WriteLine("4. Garnkonto");
                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("Privatkonto > Sparkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Account5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {


                                        Account5 = Account5 - moneyInput; Savings5 = Savings5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;

                                case "2":
                                    Console.WriteLine("Privatkonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Account5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Account5 = Account5 - moneyInput; Savings5 = Savings5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;

                                case "3":
                                    Console.WriteLine("Privatkonto > Matkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Account5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Account5 = Account5 - moneyInput; Food4 = Food4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("Privatkonto > Matkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Account5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Account5 = Account5 - moneyInput; Yarn5 = Yarn5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(500);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                            }
                        }
                    }
                    else if (index == 1)
                    {
                        if (Login == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Privatkonto");
                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {

                                case "1":
                                    Console.WriteLine("SparKonto > PrivatKonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Savings1)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account1);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Account1 = Account1 + moneyInput; Savings1 = Savings1 - moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;


                            }


                        }
                        else if (Login == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Privatkonto");
                            Console.WriteLine("2. Semesterkonto");

                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {

                                case "1":
                                    Console.WriteLine("SparKonto > PrivatKonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Savings2)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings2);
                                        Console.ReadKey();
                                    }
                                    Savings2 = Savings2 - moneyInput; Account2 = Account2 + moneyInput;
                                    Console.WriteLine("Överför");
                                    Thread.Sleep(500);
                                    Console.WriteLine(". . .");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                    Console.ReadKey();
                                    FirstMenu();
                                    break;

                                case "2":
                                    Console.WriteLine("SparKonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Savings2)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings2);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Savings2 = Savings2 - moneyInput; Vacation2 = Vacation2 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;



                            }

                        }
                        else if (Login == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Privatkonto");
                            Console.WriteLine("2. Semesterkonto");
                            Console.WriteLine("3. Matkonto");

                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {

                                case "1":
                                    Console.WriteLine("SparKonto > PrivatKonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Savings3)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings3);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Savings3 = Savings3 - moneyInput; Account3 = Account3 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;

                                case "2":
                                    Console.WriteLine("SparKonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Savings3)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings3);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Savings3 = Savings3 - moneyInput; Vacation3 = Vacation3 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("SparKonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Savings3)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings3);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Savings3 = Savings3 - moneyInput; Food3 = Food3 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;

                            }


                        }
                        else if (Login == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Privatkonto");
                            Console.WriteLine("2. Semesterkonto");
                            Console.WriteLine("3. Matkonto");
                            Console.WriteLine("4. Gitarrkonto");

                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {

                                case "1":
                                    Console.WriteLine("SparKonto > PrivatKonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Savings4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Savings4 = Savings4 - moneyInput; Account4 = Account4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;

                                case "2":
                                    Console.WriteLine("SparKonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Savings4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Savings4 = Savings4 - moneyInput; Vacation4 = Vacation4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("SparKonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Savings4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Savings4 = Savings4 - moneyInput; Food4 = Food4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("SparKonto > Gitarrkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Savings4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Savings4 = Savings4 - moneyInput; GuitarAccount4 = GuitarAccount4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                            }
                        }
                        else if (Login == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Privatkonto");
                            Console.WriteLine("2. Semesterkonto");
                            Console.WriteLine("3. Matkonto");
                            Console.WriteLine("4. Gitarrkonto");

                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {

                                case "1":
                                    Console.WriteLine("SparKonto > PrivatKonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Savings5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Savings5 = Savings5 - moneyInput; Account5 = Account5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;

                                case "2":
                                    Console.WriteLine("SparKonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Savings5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Savings5 = Savings5 - moneyInput; Vacation5 = Vacation5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("SparKonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Savings5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Savings5 = Savings5 - moneyInput; Food5 = Food5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("SparKonto > Garnkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Savings5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Savings5 = Savings5 - moneyInput; Yarn5 = Yarn5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                            }



                        }
                    }
                    else if (index == 2)
                    {

                        if (Login == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Privatkonto");
                            Console.WriteLine("2. Sparkonto");
                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("Semesterkonto > Privatkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Vacation2)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation2);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Vacation2 = Vacation2 - moneyInput; Account2 = Account2 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Semesterkonto > Sparkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Vacation2)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation2);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Vacation2 = Vacation2 - moneyInput; Savings2 = Savings2 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                    }
                                    break;

                            }
                        }
                        else if (Login == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Privatkonto");
                            Console.WriteLine("2. Sparkonto");
                            Console.WriteLine("3. Matkonto");
                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("Semesterkonto > Privatkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Vacation3)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation3);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Vacation3 = Vacation3 - moneyInput; Account3 = Account3 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Semesterkonto > Sparkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Vacation3)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation3);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Vacation3 = Vacation3 - moneyInput; Savings3 = Savings3 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("Semesterkonto > Matkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Vacation3)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation3);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Vacation3 = Vacation3 - moneyInput; Food3 = Food3 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;


                            }

                        }
                        else if (Login == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Privatkonto");
                            Console.WriteLine("2. Sparkonto");
                            Console.WriteLine("3. Matkonto");
                            Console.WriteLine("4. Gitarrkonto");
                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("Semesterkonto > Privatkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Vacation4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Vacation4 = Vacation4 - moneyInput; Account4 = Account4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Semesterkonto > Sparkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Vacation4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Vacation4 = Vacation4 - moneyInput; Savings4 = Savings4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("Semesterkonto > Matkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Vacation4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Vacation4 = Vacation4 - moneyInput; Food4 = Food4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("Semesterkonto > Gitarrkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Vacation4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Vacation4 = Vacation4 - moneyInput; GuitarAccount4 = GuitarAccount4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                            }

                        }
                        else if (Login == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Privatkonto");
                            Console.WriteLine("2. Sparkonto");
                            Console.WriteLine("3. Matkonto");
                            Console.WriteLine("4. Garnkonto");
                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("Semesterkonto > Privatkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Vacation5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Vacation5 = Vacation5 - moneyInput; Account5 = Account5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Semesterkonto > Sparkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Vacation5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Vacation5 = Vacation5 - moneyInput; Savings5 = Savings5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("Semesterkonto > Matkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Vacation5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Vacation5 = Vacation5 - moneyInput; Food5 = Food5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("Semesterkonto > Garnkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Vacation5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Vacation5 = Vacation5 - moneyInput; Yarn5 = Yarn5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;


                            }
                        }

                    }
                    else if (index == 3)
                    {
                        if (Login == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Privatkonto");
                            Console.WriteLine("2. Sparkonto");
                            Console.WriteLine("3. Semesterkonto");
                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("Matkonto > Privatkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Food3)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Food3);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Food3 = Food3 - moneyInput; Account3 = Account3 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Matkonto > Sparkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Food3)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Food3);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Food3 = Food3 - moneyInput; Savings3 = Savings3 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("Matkonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Food3)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Food3);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Food3 = Food3 - moneyInput; Vacation3 = Vacation3 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                            }
                        }
                        else if (Login == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Privatkonto");
                            Console.WriteLine("2. Sparkonto");
                            Console.WriteLine("3. Semesterkonto");
                            Console.WriteLine("4. Gitarrkonto");
                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("Matkonto > Privatkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Food4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Food4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Food4 = Food4 - moneyInput; Account4 = Account4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Matkonto > Sparkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Food4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Food4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Food4 = Food4 - moneyInput; Savings4 = Savings4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("Matkonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Food4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Food4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Food4 = Food4 - moneyInput; Vacation4 = Vacation4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("Matkonto > Gitarrkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Food4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Food4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Food4 = Food4 - moneyInput; GuitarAccount4 = GuitarAccount4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                            }
                        }
                        else if (Login == 4)
                        {

                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Privatkonto");
                            Console.WriteLine("2. Sparkonto");
                            Console.WriteLine("3. Semesterkonto");
                            Console.WriteLine("4. Garnkonto");
                            string input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("Matkonto > Privatkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Food5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Food5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Food5 = Food5 - moneyInput; Account5 = Account5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Matkonto > Sparkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Food5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Food5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Food5 = Food5 - moneyInput; Savings5 = Savings5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("Matkonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Food5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Food5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Food5 = Food5 - moneyInput; Vacation5 = Vacation5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("Matkonto > Garnkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Food5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Food5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Food5 = Food5 - moneyInput; GuitarAccount4 = GuitarAccount4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                            }

                        }
                    }
                    else if (index == 4)
                    {
                        if (Login == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Privatkonto");
                            Console.WriteLine("2. Sparkonto");
                            Console.WriteLine("3. Semesterkonto");
                            Console.WriteLine("4. Matkonto");
                            string? input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("Matkonto > Privatkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > GuitarAccount4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", GuitarAccount4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        GuitarAccount4 = GuitarAccount4 - moneyInput; Account4 = Account4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Gitarrkonto > Sparkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > GuitarAccount4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", GuitarAccount4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        GuitarAccount4 = GuitarAccount4 - moneyInput; Savings4 = Savings4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("Gitarrkonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > GuitarAccount4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", GuitarAccount4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        GuitarAccount4 = GuitarAccount4 - moneyInput; Vacation4 = Vacation4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("Gitarrkonto > Matkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > GuitarAccount4)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", GuitarAccount4);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        GuitarAccount4 = GuitarAccount4 - moneyInput; Food4 = Food4 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                            }
                        }
                        else if (Login == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Välj konto att överföra till:");
                            Console.WriteLine("1. Privatkonto");
                            Console.WriteLine("2. Sparkonto");
                            Console.WriteLine("3. Semesterkonto");
                            Console.WriteLine("4. Matkonto");
                            string? input = Console.ReadLine();
                            decimal moneyInput;
                            switch (input)
                            {
                                case "1":
                                    Console.WriteLine("Garnkonto > Privatkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Yarn5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Yarn5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Yarn5 = Yarn5 - moneyInput; Account5 = Account5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Gitarrkonto > Sparkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Yarn5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Yarn5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Yarn5 = Yarn5 - moneyInput; Savings5 = Savings5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("Matkonto > Semesterkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Yarn5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Yarn5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Yarn5 = Yarn5 - moneyInput; Vacation5 = Vacation5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("Matkonto > Matkonto");
                                    Console.WriteLine("Välj Belopp");
                                    Console.Write("===>");
                                    moneyInput = decimal.Parse(Console.ReadLine());
                                    if (moneyInput > Yarn5)
                                    {
                                        Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Yarn5);
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Food5 = Yarn5 - moneyInput; Food5 = Food5 + moneyInput;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(500);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Överföring Klar, Tryck Enter för att återgå till huvudmeny");
                                        Console.ReadKey();
                                        FirstMenu();
                                    }
                                    break;
                            }
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
        }

        public void TransferToOthers()
        {

        }
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
                        if (Login == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Account1)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account1);
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Account1 = Account1 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Account1);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            }
                            Console.ReadKey();
                        }
                        else if (Login == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Account2)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account2);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Account2 = Account2 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot ", moneyInput, Account2);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            }

                        }
                        else if (Login == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Account3)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account3);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Account3 = Account3 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Account3);
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            }

                        }
                        else if (Login == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Account4)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account4);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Account4 = Account4 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Account4);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            }

                        }
                        else if (Login == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Account5)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Account5);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Account5 = Account5 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Account5);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            }

                        }

                    }
                    else if (index == 1)
                    {
                        if (Login == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Savings1)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings1);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Savings1 = Savings1 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Savings1);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }
                            }
                            Console.ReadKey();

                        }
                        else if (Login == 1)
                        {

                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Savings2)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings2);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Savings2 = Savings2 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Savings2);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                                Console.ReadKey();
                            }

                        }
                        else if (Login == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Savings3)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings3);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Savings3 = Savings3 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Savings3);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                                Console.ReadKey();
                            }

                        }
                        else if (Login == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Savings4)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings4);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Savings4 = Savings4 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Savings4);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                                Console.ReadKey();
                            }

                        }
                        else if (Login == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Savings5)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Savings5);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Savings4 = Savings4 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Savings5);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                                Console.ReadKey();
                            }
                        }
                    }
                    else if (index == 2)
                    {

                        if (Login == 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Vacation2)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation2);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Vacation2 = Vacation2 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Vacation2);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                                Console.ReadKey();
                            }

                        }
                        else if (Login == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Vacation3)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation3);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Savings3 = Savings3 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Vacation3);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                                Console.ReadKey();
                            }

                        }
                        else if (Login == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Vacation4)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation4);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Vacation4 = Vacation4 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Vacation4);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                                Console.ReadKey();
                            }
                        }
                        else if (Login == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Vacation5)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Vacation5);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Vacation5 = Vacation5 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Vacation5);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                                Console.ReadKey();
                            }
                        }
                    }
                    else if (index == 3)
                    {
                        if (Login == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Food3)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Food3);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Food3 = Food3 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Food3);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                                Console.ReadKey();
                            }
                        }
                        else if (Login == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Food4)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Food4);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Food4 = Food4 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Food4);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                                Console.ReadKey();
                            }
                        }
                        else if (Login == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Food5)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Food5);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Food5 = Food5 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Food5);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                                Console.ReadKey();
                            }
                        }

                    }
                    else if (index == 4)
                    {
                        if (Login == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > GuitarAccount4)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", GuitarAccount4);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        GuitarAccount4 = GuitarAccount4 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, GuitarAccount4);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                                Console.ReadKey();
                            }
                        }
                        else if (Login == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("Hur mycket pengar vill du ta ut?");
                            Console.Write("===>");
                            decimal moneyInput = decimal.Parse(Console.ReadLine());
                            if (moneyInput > Yarn5)
                            {
                                Console.WriteLine("Du har inte så mycket pengar på ditt konto! du har {0:N2}", Yarn5);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.Write("Pin: ");
                                string pin = Console.ReadLine();
                                while (isTrue)
                                {
                                    if (pin == password[Login])
                                    {
                                        Yarn5 = Yarn5 - moneyInput;
                                        isTrue = false;
                                        Console.WriteLine("Överför");
                                        Thread.Sleep(1000);
                                        Console.WriteLine(". . .");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Klart! du tog ut {0:N2} och har {1:N2} kvar på kontot", moneyInput, Yarn5);
                                        Console.ReadKey();
                                        Console.Clear();
                                        FirstMenu();
                                    }
                                    else if (pin != password[Login])
                                    {
                                        Console.WriteLine("Fel pinkod! Försök igen");
                                        Console.ReadKey();
                                    }
                                    break;
                                }

                                Console.ReadKey();
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
        }
    }
}
public class Assets
{
    protected static string[][] accounts = new string[][]
    {
            new string[] { "1. PrivatKonto", "2. Sparkonto" },
            new string[] { "1. PrivatKonto", "2. Sparkonto", "3. Semesterkonto" },
            new string[] { "1. PrivatKonto", "2. Sparkonto", "3. Semesterkonto","4. Matkonto" },
            new string[] { "1. PrivatKonto", "2. Sparkonto", "3. Semesterkonto","4. Matkonto", "5. Gitarrkonto" },
            new string[] { "1. PrivatKonto", "2. Sparkonto", "3. Semesterkonto", "4. Matkonto", "5. Garnkonto" }


    };
    public static string[][] Accounts
    {
        get { return accounts; }
    }
}


