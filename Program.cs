using System;
using System.IO;
using System.Threading.Tasks;
namespace lab666
{
    class Program
    {
public static char otvet; 
public static string s; 
static async Task Main()
        {
	string chislo = null; while (chislo != "5")
            {
		do{
			Console.WriteLine("------------МЕНЮ------------");
                  	Console.WriteLine(" 1 - Посмотреть все записи.\n" +
                 	" 2 - Добавить новую запись.\n" +
                 	" 3 - выход.\n"); 
			chislo = Console.ReadLine(); switch (chislo)
                    {
			case "1":
                     	string path = @"C:\build_output\1.txt";
           		 try
           		 {
              			
                // асинхронное чтение
                		using (StreamReader sr = new StreamReader(path))
                		{
                  		  Console.WriteLine(await sr.ReadToEndAsync());
              			}
            		}
            		catch (Exception e)
            		{
                		Console.WriteLine(e.Message);
            		}break;
                        case "2":
string writePath = @"C:\build_output\1.txt";
  Console.WriteLine("---------------------");
            Console.WriteLine("| Что записываем? |");
            Console.WriteLine("---------------------");
        
	string text = Console.ReadLine();
            try
            {
               
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {   
		sw.WriteLine();
                    
sw.Write("---------------------");     
sw.WriteLine();               
sw.Write(text);
sw.WriteLine();
sw.WriteLine("---------------------"); 
                }
            Console.WriteLine("---------------------");
            Console.WriteLine("| Запись выполнена |");
            Console.WriteLine("---------------------");
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
break;
			case "3": Console.WriteLine("До встречи!");
                            Console.ReadKey(); return;}
                    do{Console.WriteLine("\nПродолжаем? y/n");
                        s = Console.ReadLine(); try {otvet = char.Parse(s);}
                        catch (FormatException)
                        {Console.WriteLine("Ошибка при вводе!!! ");}}
                    while (otvet != 'y' && otvet != 'n'); Console.Clear();}
                while (otvet == 'y'); if (otvet == 'n')
                {Console.WriteLine("\n" + "До встречи!"); break;}}
            Console.ReadLine();}}}
            