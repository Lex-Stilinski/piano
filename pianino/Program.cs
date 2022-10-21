namespace pianino
{
    internal class Program
    {
        static int[] Octava(int octave)
        {
            int[] octava3 = new int[12] { 131, 139, 147, 157, 165, 175, 185, 196, 208, 220, 233, 247 };
            int[] octava4 = new int[12] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
            int[] octava5 = new int[12] { 523, 554, 587, 622, 659, 689, 740, 784, 831, 880, 932, 988 };

            if (octave == 3)
            {
                return octava3;
            }
            else if (octave == 4)
            {
                return octava4;
            }
            else if (octave == 5)
            {
                return octava5;
            }
            else
            {
                return null;
            }
        }
        static void Main()
        {
            Console.WriteLine("Добро пожаловать. Вы запустили пианино");
            Console.WriteLine("Для выхода нажмите Esc");
            Console.WriteLine("Переключение между октавами F3, F4, F5, соответственно 3, 4 и 5 октавы");
            Console.WriteLine("Белые клавиши: D, F, G, H, J,K, L \nЧерные клавиши: R, T, U, I, O");
            Console.WriteLine("Выберите октаву: ");

            int[] knop = Octava(0);
            ConsoleKeyInfo key = Console.ReadKey();

            do
            {
                if (key.Key == ConsoleKey.F3)
                {
                    knop = Octava(3);
                    Console.WriteLine("\nВыбрана 3 октава");
                }
                else if (key.Key == ConsoleKey.F4)
                {
                    knop = Octava(4);
                    Console.WriteLine("\nВыбрана 4 октава");
                }
                else if (key.Key == ConsoleKey.F5)
                {
                    knop = Octava(5);
                    Console.WriteLine("\nВыбрана 5 октава");
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("ВВы вышли из программы");
                    break;
                }

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.D)
                {
                    Sound(knop[0]);
                }
                if (key.Key == ConsoleKey.R)
                {
                    Sound(knop[1]);
                }
                if (key.Key == ConsoleKey.F)
                {
                    Sound(knop[2]);
                }
                if (key.Key == ConsoleKey.T)
                {
                    Sound(knop[3]);
                }
                if (key.Key == ConsoleKey.G)
                {
                    Sound(knop[4]);
                }
                if (key.Key == ConsoleKey.H)
                {
                    Sound(knop[5]);
                }
                if (key.Key == ConsoleKey.U)
                {
                    Sound(knop[6]);
                }
                if (key.Key == ConsoleKey.J)
                {
                    Sound(knop[7]);
                }
                if (key.Key == ConsoleKey.I)
                {
                    Sound(knop[8]);
                }
                if (key.Key == ConsoleKey.K)
                {
                    Sound(knop[9]);
                }
                if (key.Key == ConsoleKey.O)
                {
                    Sound(knop[10]);
                }
                if (key.Key == ConsoleKey.L)
                {
                    Sound(knop[11]);
                }
            }
            while (key.Key != ConsoleKey.Escape);
        }

        static void Sound(int clavisha)
        {
            Console.Beep(clavisha, 800);
        }
    }
}