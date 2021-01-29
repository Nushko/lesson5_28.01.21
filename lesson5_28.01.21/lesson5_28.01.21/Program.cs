using System;
using System.Linq;

namespace lesson5_28._01._21
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrstring = new string[] { "1", "2", "3", "4" };
            int[] arrint = new int[] { 1, 2, 3, 4 };
            double[] arrdouble = new double[] { 1, 2, 3, 4 };
            decimal[] arrdecimal = new decimal[] { 1, 2, 3, 4 };
            float[] arrfloat = new float[] { 1, 2, 3, 4 };

            //Pop
            {
                Console.Write(
                    $"метод Pop: " +
                    $"\nДо => ");
                for (int i = 0; i < arrstring.Length; i++)
                {
                    Console.Write(arrstring[i] + " ");
                }

                Console.Write(
                    $"\nУдалённый элемент = {ArrayHelper.Pop(ref arrstring)}" +
                    $"\nПосле => ");
                for (int i = 0; i < arrstring.Length; i++)
                {
                    Console.Write(arrstring[i] + " ");
                }
            }
            Console.WriteLine("\n");

            //Push
            {
                Console.Write(
                    $"метод Push: " +
                    $"\nРазмер = {arrstring.Length}" +
                    $"\nДо => ");
                for (int i = 0; i < arrstring.Length; i++)
                {
                    Console.Write(arrstring[i] + " ");
                }

                Console.Write(
                    $"\nРазмер = {ArrayHelper.Push(ref arrstring, "5")}" +
                    $"\nПосле => ");
                for (int i = 0; i < arrstring.Length; i++)
                {
                    Console.Write(arrstring[i] + " ");
                }
            }
            Console.WriteLine("\n");

            //Shift
            {
                Console.Write(
                    $"метод Shift: " +
                    $"\nДо => ");
                for (int i = 0; i < arrstring.Length; i++)
                {
                    Console.Write(arrstring[i] + " ");
                }

                Console.Write(
                    $"\nУдалённый элемент = {ArrayHelper.Shift(ref arrstring)}" +
                    $"\nПосле => ");
                for (int i = 0; i < arrstring.Length; i++)
                {
                    Console.Write(arrstring[i] + " ");
                }
            }
            Console.WriteLine("\n");

            //Push
            {
                Console.Write(
                    $"метод UnShift: " +
                    $"\nРазмер = {arrstring.Length}" +
                    $"\nДо => ");
                for (int i = 0; i < arrstring.Length; i++)
                {
                    Console.Write(arrstring[i] + " ");
                }

                Console.Write(
                    $"\nРазмер = {ArrayHelper.UnShift(ref arrstring, "6")}" +
                    $"\nПосле => ");
                for (int i = 0; i < arrstring.Length; i++)
                {
                    Console.Write(arrstring[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
    public static class ArrayHelper
    {
        //Pop

        public static string Pop(ref string[] arr)
        {
            if (arr.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Массив пуст.");
                Console.ForegroundColor = ConsoleColor.White;
                return "0";
            }
            string x = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return x;
        }
        public static int Pop(ref int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Массив пуст.");
                Console.ForegroundColor = ConsoleColor.White;
                return 0;
            }
            int x = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return x;
        }
        public static double Pop(ref double[] arr)
        {
            if (arr.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Массив пуст.");
                Console.ForegroundColor = ConsoleColor.White;
                return 0;
            }
            double x = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return x;
        }
        public static decimal Pop(ref decimal[] arr)
        {
            if (arr.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Массив пуст.");
                Console.ForegroundColor = ConsoleColor.White;
                return 0;
            }
            decimal x = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return x;
        }
        public static float Pop(ref float[] arr)
        {
            if (arr.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Массив пуст.");
                Console.ForegroundColor = ConsoleColor.White;
                return 0;
            }
            float x = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            return x;
        }

        //Push

        public static int Push(ref string[] arr, string add)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = add;
            return arr.Length;
        }
        public static int Push(ref int[] arr, int add)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = add;
            return arr.Length;
        }
        public static int Push(ref double[] arr, double add)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = add;
            return arr.Length;
        }
        public static int Push(ref decimal[] arr, decimal add)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = add;
            return arr.Length;
        }
        public static int Push(ref float[] arr, float add)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = add;
            return arr.Length;
        }

        //Shift

        public static string Shift(ref string[] arr)
        {
            if (arr.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Массив пуст.");
                Console.ForegroundColor = ConsoleColor.White;
                return "0";
            }
            Array.Reverse(arr);
            string x = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            Array.Reverse(arr);
            return x;
        }
        public static int Shift(ref int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Массив пуст.");
                Console.ForegroundColor = ConsoleColor.White;
                return 0;
            }
            Array.Reverse(arr);
            int x = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            Array.Reverse(arr);
            return x;
        }
        public static double Shift(ref double[] arr)
        {
            if (arr.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Массив пуст.");
                Console.ForegroundColor = ConsoleColor.White;
                return 0;
            }
            Array.Reverse(arr);
            double x = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            Array.Reverse(arr);
            return x;
        }
        public static decimal Shift(ref decimal[] arr)
        {
            if (arr.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Массив пуст.");
                Console.ForegroundColor = ConsoleColor.White;
                return 0;
            }
            Array.Reverse(arr);
            decimal x = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            Array.Reverse(arr);
            return x;
        }
        public static float Shift(ref float[] arr)
        {
            if (arr.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Массив пуст.");
                Console.ForegroundColor = ConsoleColor.White;
                return 0;
            }
            Array.Reverse(arr);
            float x = arr[arr.Length - 1];
            Array.Resize(ref arr, arr.Length - 1);
            Array.Reverse(arr);
            return x;
        }

        //UnShift

        public static int UnShift(ref string[] arr, string add)
        {
            Array.Reverse(arr);
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = add;
            Array.Reverse(arr);
            return arr.Length;
        }
        public static int UnShift(ref int[] arr, int add)
        {
            Array.Reverse(arr);
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = add;
            Array.Reverse(arr);
            return arr.Length;
        }
        public static int UnShift(ref double[] arr, double add)
        {
            Array.Reverse(arr);
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = add;
            Array.Reverse(arr);
            return arr.Length;
        }
        public static int UnShift(ref decimal[] arr, decimal add)
        {
            Array.Reverse(arr);
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = add;
            Array.Reverse(arr);
            return arr.Length;
        }
        public static int UnShift(ref float[] arr, float add)
        {
            Array.Reverse(arr);
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = add;
            Array.Reverse(arr);
            return arr.Length;
        }
    }
}
