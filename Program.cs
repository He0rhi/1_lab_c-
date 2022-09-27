using System;
using System.Text;
namespace лаба_1
{
    class First_zd
    {
        static void Main(string[] args)
        {
            First();
            Second();
            Third();
            Fourth();
            string str = "ЕГОР";
            int[] mass = { 1, 3, 5, 7, 9 };
            Fivth( mass, str);
            Sixth();
        }
        static void First()
        {
            Console.WriteLine("/*----------------------------------------1-------------------------------------------------------------------*/");

            Console.WriteLine("/*----------------------------------------a-------------------------------------------------------------------*/");

            bool elem = true;

            Console.WriteLine("Bool:");
            Console.WriteLine("elem - " + elem);
            Console.WriteLine("false - " + false);
            Console.WriteLine("Byte:");
            Console.WriteLine("Введите любое число, если введёте больше 256 либо меньше -256, то произойдет ошибка программы:");
            byte a = byte.Parse(Console.ReadLine());
            Console.WriteLine(a);
            Console.WriteLine("SByte:");
            Console.WriteLine("Введите любое число, если введёте больше 127 либо меньше -127, то произойдет ошибка программы:");
            sbyte b = sbyte.Parse(Console.ReadLine());
            Console.WriteLine(b);
            Console.Write("char: ");
            char bot = 'a';
            Console.WriteLine(bot);
            Console.Write("double: ");
            double d = 0.42e2;
            Console.WriteLine(d); 
            Console.Write("float: ");
            float e = 134.45E-2f;
            Console.WriteLine(e);
            Console.Write("demical: ");
            decimal f = 1.5E6m;
            Console.WriteLine(f);  
            Console.Write("int: ");
            int g=25;
            Console.WriteLine(g);


            Console.WriteLine("/*----------------------------------------b-------------------------------------------------------------------*/");

            Console.WriteLine("НЕЯВНЫЕ");
            Console.WriteLine("первое int-double:");
            int neavn1 = 1;
            double neavn1_1 = neavn1 + 0.5;
            Console.WriteLine(neavn1_1);
            Console.WriteLine("второе char-int:");
            char charg = 'a';
            int charg1 = charg + 1;
            Console.WriteLine(charg1);
            Console.WriteLine("третье char-double:");
            char charg2 = 'a';
            double charg3 = charg2 + 1.2;
            Console.WriteLine(charg3);

            Console.WriteLine("ЯВНЫЕ");
            Console.WriteLine("первое int - double:");
            int yavn1 = 1;
            double yavn1_1 = System.Convert.ToDouble(yavn1);
            Console.WriteLine(yavn1_1+0.5);
            Console.WriteLine("второе char-int:");
            char yavn2 = 'a';
            int yavn1_2 = System.Convert.ToInt32(yavn2);
            Console.WriteLine(yavn1_2);
            Console.WriteLine("третье int-char:");
            int yavn3 =14;
            char yavn1_3 = System.Convert.ToChar(yavn3);
            Console.WriteLine(yavn1_3);


            Console.WriteLine("/*----------------------------------------c-------------------------------------------------------------------*/");

            Console.WriteLine("упаковка значимых типов");
            Console.Write("упаковка int, введите:");
            int i = int.Parse(Console.ReadLine());
            object o = i;
            Console.WriteLine("измените int:");
            o=int.Parse(Console.ReadLine());
            Console.Write("изначальный int: ");
            Console.WriteLine(i);

            Console.Write("упакованный int: ");
            Console.WriteLine(o);


            Console.WriteLine("/*----------------------------------------d-------------------------------------------------------------------*/");
            Console.WriteLine("Работа с неявно типизированной переменной");

            var int_d = 5;  //int
            var char_d = "Hello"; //string
            Console.WriteLine(int_d);
            Console.WriteLine(char_d);

            for(var x = 1; x < 5; x++)
            {
                Console.Write("слово ");

            }
            Console.WriteLine("");

            Console.WriteLine("/*----------------------------------------e-------------------------------------------------------------------*/");
            Console.WriteLine("Работа с nullable");

            int? xx = 5;
            if (xx.HasValue)
            {
                int xx2 = (int)xx;
                Console.WriteLine("есть число " + xx2);
            }
            else
            {
                Console.WriteLine("null");

            }

            Console.WriteLine("/*----------------------------------------f-------------------------------------------------------------------*/");

         /*
            var ff = "f";
            ff = 2;
            Console.WriteLine(ff);
         */




        }
        static void Second()
        {
            Console.WriteLine("/*----------------------------------------2-------------------------------------------------------------------*/");
            Console.WriteLine("/*----------------------------------------a-------------------------------------------------------------------*/");
            string str1 = "a";
                string str2 = "a";
            int result = string.Compare(str1, str2);
            Console.Write("сравнение строк: ");
            Console.Write(str1 + " , ");
            Console.WriteLine(str2);
            if( result == 1 )
            {
                Console.WriteLine("певрая строка < вторая строка"); 
                    }
            else if( result == -1)
            {
                Console.WriteLine("певрая сротрока > вторая строка");

            }
            else
            {
                Console.WriteLine("певрая сротрока = вторая строка");

            }

            Console.WriteLine("/*----------------------------------------b-------------------------------------------------------------------*/");

            string a1 = "ааа ббб ввв ггг";
            string a2 = "ддд еее жжж ззз";
            string a3 = "иии ййй ккк ллл";

            Console.WriteLine("сцепление строк первой и второй: ");
            string scepl = string.Concat(a1, a2);
            Console.Write(scepl);

            Console.WriteLine("копирование третьей строки: ");
            string copi = string.Copy(a3);
            
            Console.Write(copi);

            Console.WriteLine("подстрока третьей: ");
            string slovo = "каждое слово имеет смысл";
            string[] words = slovo.Split(' ');

            foreach (var word in words)
            {
                Console.WriteLine($"<{word}>");
            }

            Console.WriteLine("вставка подстроки в заданную позицию: ");

            string vstav = a1.Insert(1, a3);
            Console.Write(vstav);

            Console.WriteLine("удаление подстроки: ");

           string rem =  a2.Remove(0, 5);
            Console.Write(rem);

            Console.WriteLine("/*----------------------------------------с-------------------------------------------------------------------*/");

            string ss_empty = string.Empty;
            string ss_null = null;

            if (string.IsNullOrEmpty(ss_null))
            {
                Console.WriteLine("Строка является типом null");
            }

            Console.WriteLine("/*----------------------------------------d-------------------------------------------------------------------*/");
            var sb = new StringBuilder("Привет");
            Console.WriteLine("строка: " + sb);
            sb.Remove(0, 3);
            Console.WriteLine("удаление 'при': " + sb);
            sb.Append("...");
            Console.WriteLine("добавление в конец '...' : " + sb);
            sb.Insert(0, "...");
            Console.WriteLine("добавление в начало '...' : " + sb);



        }
        static void Third()
        {


            Console.WriteLine("/*----------------------------------------1-------------------------------------------------------------------*/");
            Console.WriteLine("/*----------------------------------------a-------------------------------------------------------------------*/");

            int[,] matric = { { 1, 2, 3 }, { 4, 5, 6 },{ 7, 8, 9 } };


            for (int i = 0; i < 3;i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{matric[i, j]}\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("/*----------------------------------------b-------------------------------------------------------------------*/");

            Console.WriteLine("введите номер элемента, который вы хотите изменить: ");

            string[] strmass = { "one", "two", "three" };


            int a = int.Parse(Console.ReadLine()); //преобразует в число

            Console.WriteLine("введите измененный элемент: ");
            string b = Console.ReadLine();
            a -= 1;
            Console.WriteLine("измененный массив: ");
            strmass[a] = b;
            for(int c=0; c < strmass.Length; c++)
            {
                Console.Write(" " + strmass[c]);

            }
            Console.WriteLine();

            Console.WriteLine("/*----------------------------------------с-------------------------------------------------------------------*/");

            int[][] stupmass = new int[3][];
            stupmass[0] = new int[2];
            stupmass[1] = new int[3];
            stupmass[2] = new int[4];

            

            for (int i = 0; i < stupmass.Length; i++)
            {
                for (int j = 0; j < stupmass[i].Length; j++)
                {
                    stupmass[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < stupmass.Length; i++)
            {
                for (int j = 0; j < stupmass[i].Length; j++)
                {
                    Console.Write(stupmass[i][j]);

                }
                Console.WriteLine();

            }

            Console.WriteLine("/*----------------------------------------d-------------------------------------------------------------------*/");

            var strd = "";
            var massd = new int [10];

        }
        static void Fourth()
        {
            Console.WriteLine("/*----------------------------------------4-------------------------------------------------------------------*/");
            Console.WriteLine("/*----------------------------------------ab-------------------------------------------------------------------*/");


            (int one, string str, char f, string str2 , ulong b) g = (1, "fdfs", 'f', "ddfdf", 0b101);

            Console.WriteLine($"первый: {g.Item1} второй: {g.Item2} третий: {g.Item3} ");

            Console.WriteLine("/*----------------------------------------с-------------------------------------------------------------------*/");

            var c = ("Егор", 19);
            (string name, int age) = c;

            Console.WriteLine($"Имя: {name} \t Возраст: {age}");



            var (n1, _, p1, _, p2) = QueryCityDataForYears("Егор", 19, 2003);
            Console.WriteLine($"Мое имя {n1}, и мне {p1} лет, я {p2} года рождения");
            static (string, double, int, int, int) QueryCityDataForYears(string name, int year1, int year2)
            {
                int thirdyear = year2 / 2;
                double secondyear = year1 / 2;
                return (name, secondyear, year1, thirdyear, year2);
            }

            

            Console.WriteLine("/*----------------------------------------d-------------------------------------------------------------------*/");
            (int aa, int bb) first = (1, 2);

            (int aa, int bb) second = (1, 2);

            Console.WriteLine(first == second);  
            Console.WriteLine(first != second);

        }
        
        static void Fivth(int [] mass, string str)
        {
            int min = mass[0];
            int max = mass[0];
            int n = mass.Length;
            for(int i=0; i < n; i++)
            {
                if (min > mass[i])
                {
                    min = mass[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (mass[i] < 100 && mass[i] > max)
                    max = mass[i];
            }
            char fir = str[0];
            int summ=0;
            for (int i = 0; i < n; i++)
            {
                summ += mass[i];
            }

            (int minim, int maxim,int sum, char f) g = (min, max, summ, fir);

            Console.WriteLine($"Минимальное значение {g.minim}, максимальное значение {g.maxim}, сумма {g.sum} первая буква {g.f}");


        }
        static void Sixth()
        {
            Console.WriteLine("/*----------------------------------------6-------------------------------------------------------------------*/");
            Console.WriteLine("/*----------------------------------------a-------------------------------------------------------------------*/");

            uncheck();
            static void check()
            {

                int wow(int a, int b) => a * b;
                int f = 5;

                try
                {
                    checked
                    {
                        Console.WriteLine(wow(f,int.MaxValue));
                    }
                }
                catch(OverflowException e)
                {
                    Console.WriteLine("переполнение");
                }
                try
                {
                    checked
                    {
                        wow(f, f*int.MaxValue);
                    }
                }
                catch(OverflowException e) {
                    Console.WriteLine("переполнение");
                }
                
            }
            static void uncheck()
            {
                int wow(int a, int b) => a * b;
                int f = 5;
                try
                {
                    unchecked
                    {
                        Console.WriteLine(wow(f, int.MaxValue));

                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("переполнение");
                }
                try
                {
                    unchecked
                    {
                        Console.WriteLine(wow(f, f* int.MaxValue));
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("переполнение");
                }

            }


        }


    }

    }
    
    
    

