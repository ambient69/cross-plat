using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Classes
{
    public class Lab2
    {
        public static void Run(string inputPath, string outputPath)
        {

            try
            {
                string input = File.ReadAllText(inputPath);
                int N = Convert.ToInt32(input.Trim());

                if (N < 3)
                {
                    Console.WriteLine("Количество приборов должно быть не менее 3.");
                }
                else
                {
                    int[] devices = Enumerable.Range(1, N).ToArray();
                    int iterations = 1;

                    while (devices.Length > 3)
                    {
                        if (devices.Length % 2 == 0)
                        {
                            devices = devices.Where((x, index) => index % 2 != 0).ToArray();
                        }
                        else
                        {
                            devices = devices.Where((x, index) => index % 2 == 0).ToArray();
                        }
                        iterations++;
                    }

                    Console.WriteLine("Количество способов выбора приборов: " + iterations);

                    // Записываем количество способов выбора в файл output.txt
                    using (StreamWriter writer = new StreamWriter(outputPath))
                    {
                        writer.WriteLine("Количество способов выбора приборов: " + iterations);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл INPUT.txt не найден.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный формат данных в файле INPUT.txt.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
