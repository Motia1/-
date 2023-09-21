using System;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{

    class Lab_1
    {
        static void Main()
        {
            {
                byte bt = 42;
                sbyte sbt = -42;
                short s = 12345;
                ushort us = 54321;
                int i = 123456789;
                uint ui = 987654321;
                long l = 1234567890123456789;
                ulong ul = 9876543210987654321;
                float f = 3.14f;
                double d = 3.14159265359;
                decimal dc = 12345.6789m;
                bool b = true;
                char c = 'A';
                string str = "Привет, мир!";

                Console.WriteLine("byte: " + bt);
                Console.WriteLine("sbyte: " + sbt);
                Console.WriteLine("short: " + s);
                Console.WriteLine("ushort: " + us);
                Console.WriteLine("int: " + i);
                Console.WriteLine("uint: " + ui);
                Console.WriteLine("long: " + l);
                Console.WriteLine("ulong: " + ul);
                Console.WriteLine("float: " + f);
                Console.WriteLine("double: " + d);
                Console.WriteLine("decimal: " + dc);
                Console.WriteLine("bool: " + b);
                Console.WriteLine("char: " + c);
                Console.WriteLine("string: " + str);

                Console.Write("Введите целое число: ");
                int input = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Вы ввели: " + input);



                double da = 3.5;
                int ib = (int)da;
                char cc = (char)ib;
                float fd = (float)da;
                long le = (long)fd;

                Console.WriteLine("da (явное): " + da);
                Console.WriteLine("ib (явное): " + ib);
                Console.WriteLine("cc (явное): " + cc);
                Console.WriteLine("fd (явное): " + fd);
                Console.WriteLine("le (явное): " + le);

                int intValue = 4;
                double doubleValue = intValue;
                float floatValue = intValue;
                long longValue = intValue;
                short shortValue = 10;
                intValue = shortValue;
                ushort uShortValue = 50;
                ulong uLongValue = uShortValue;

                Console.WriteLine("doubleValue (неявное): " + doubleValue);
                Console.WriteLine("floatValue (неявное): " + floatValue);
                Console.WriteLine("longValue (неявное): " + longValue);
                Console.WriteLine("intValue (неявное): " + intValue);
                Console.WriteLine("uLongValue (неявное): " + uLongValue);

                int conInt = Convert.ToInt32('A');
                Console.WriteLine("Преобразрвание char в int при помощи Convert" + conInt);


                int originalInt = 42;

                object boxedInt = originalInt;

                int unboxedInt = (int)boxedInt;

                Console.WriteLine("originalInt: " + originalInt);
                Console.WriteLine("boxedInt: " + boxedInt);
                Console.WriteLine("unboxedInt: " + unboxedInt);

                var number = 42;

                var text = "Привет, мир!";

                Console.WriteLine("number: " + number);
                Console.WriteLine("text: " + text);

                int? nullableInt = null;

                if (nullableInt.HasValue == false)
                {
                    Console.WriteLine("nullableInt равен null");
                }

                nullableInt = 10;
                Console.WriteLine(nullableInt);
                string str1 = "Hello мир";
                string str2 = "Hello мир";
                string str3 = "123123123";

                bool Equal = (str1 == str2);
                Console.WriteLine(Equal);

                string Content = str1 + str2 + str3;
                Console.WriteLine(Content);

                string strA = "Heil";
                string strB = String.Copy(strA);
                Console.WriteLine(strB);

                string substring = str2.Substring(4, 3);
                Console.WriteLine("Выделение подстроки: " + substring);

                string[] words = str2.Split(' ');
                Console.WriteLine("Разделение строки на слова:");
                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }

                string emptyString = string.Empty;
                string nullString = null;
                bool isEmptyOrNull1 = string.IsNullOrEmpty(emptyString);
                bool isEmptyOrNull2 = string.IsNullOrEmpty(nullString);

                Console.WriteLine("Строка emptyString пуста или null: " + isEmptyOrNull1);
                Console.WriteLine("Строка nullString пуста или null: " + isEmptyOrNull2);

                // Создание строки на основе StringBuilder
                StringBuilder stringBuilder = new StringBuilder("Пример строки");

                // Удаление определенных позиций
                stringBuilder.Remove(3, 3); // Удаляем седьмой символ и следующие 7 символов

                // Добавление новых символов в начало и конец строки
                stringBuilder.Insert(0, "Новый "); // Вставляем "Новый " в начало строки
                stringBuilder.Append(" с добавлением в конец."); // Добавляем текст в конец строки

                // Вывод строки после всех операций
                Console.WriteLine(stringBuilder.ToString());

                int[,] multiDimensionalArray1 = { { 1, 2, 3 }, { 4, 5, 6 } };
                for (var j = 0; j < 2; j++)
                {
                    for (var k = 0; k < 3; k++) Console.Write(multiDimensionalArray1[j, k] + " ");
                    Console.WriteLine();
                }


                string[] arrayOfStrings = { "I ", "love ", "to ", "win." };
                foreach (string word in arrayOfStrings)
                {
                    Console.Write(word);
                }
                Console.WriteLine("length of arrayOfStrings is " + arrayOfStrings.Length);
                Console.WriteLine("Введите номер элемента массива для замены: ");
                var numberForReplace = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите текст для замены: ");
                var textForReplace = Convert.ToString(Console.ReadLine());
                arrayOfStrings[numberForReplace] = textForReplace;
                foreach (string word in arrayOfStrings)
                {
                    Console.Write(word);
                }

                Console.WriteLine();

                int[][] myArr = new int[4][];
                myArr[0] = new int[4];
                myArr[1] = new int[3];
                myArr[2] = new int[6];
                myArr[3] = new int[5];
                for (int j = 0; j < 4; j++) myArr[0][j] = j;
                for (int j = 0; j < 3; j++) myArr[1][j] = j;
                for (int j = 0; j < 6; j++) myArr[2][j] = j;
                for (int j = 0; j < 5; j++) myArr[3][j] = j;
                for (int k = 0; k < 4; k++)
                {
                    foreach (int numbe in myArr[k])
                    {
                        Console.Write(numbe);
                    }
                    Console.WriteLine();
                }

                var array = new object[3] { 1, 2, 3 };

                (int, string, char, string, ulong) t = (5, "haha", '0', "loop", 1234);
                Console.WriteLine($"First element:{t.Item1}. Second element: {t.Item2}. Fourth element: {t.Item5}");

                int iK = t.Item1;
                string strK = t.Item2;
                char chK = t.Item3;

                var tuple1 = (26, 32);
                var tuple2 = (17, 31);
                Console.WriteLine((bool)(tuple1 == tuple2));
                Console.WriteLine((bool)(tuple1 != tuple2));


                int[] arrayMain;
                string strMain;

                checkUncheck();
                checkedFunc();
            }
        }
        static ((int, int), char) MaxMinFirst(int[] arrayMain, string strMain)
        {
            var tupleInt = (arrayMain.Max(), arrayMain.Min());
            char firstLetter = strMain[0];
            var resultTuple = (tupleInt, firstLetter);
            return resultTuple;
        }
        static bool checkedFunc()
        {
            return true;
        }
        static void checkUncheck()
        {
            uint a = uint.MaxValue;

            unchecked
            {
                Console.WriteLine(a + 3);  // output: 2
            }

            try
            {
                checked
                {
                    Console.WriteLine(a + 3);
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);  // output: Arithmetic operation resulted in an overflow.
            }
            return;
        }
    }
}