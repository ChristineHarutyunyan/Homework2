using System;
using System.Collections.Generic; // for list
using System.Linq;

namespace ConsoleApp2
{    public class Record {
        public string name;
        public ushort age;
        public uint height;
        public uint history;
        public uint maths;
        public uint russian_language;

        public Record(string name, ushort age, uint height, uint history, uint maths, uint russian_language)
            {

              this.name = name;
              this.age = age;
              this.height = height;
              this.history = history;
              this.maths =maths;
              this.russian_language = russian_language;

        }
    }
    class Program
    {

      
        static void Main()
        {
            Console.WriteLine("Enter name"); string name = Console.ReadLine();
            Console.WriteLine("Enter age"); ushort age = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Enter height"); uint height = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Enter history"); uint history = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Enter maths"); uint maths = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Enter russian_language"); uint russian_language = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine(" "); double average_rating = (history + maths + russian_language) / (3.0);


            List<Record> notebookrecord=new List<Record>();
           
            Record rec = new Record(name, age, height, history, maths, russian_language);
            notebookrecord.Add(rec);

             





            Console.WriteLine(name + age + height + history + maths + russian_language + average_rating);  //обычный вывод

            //string pattern = "Имя: {0} \nВозраст: {1} \nРост: {2} \nИстория: {3}  \nМатематика: {4} \nРусский_язык:  {5}  \ncредний_балл: {6} ";
            //Console.WriteLine(pattern,
            //name, age, height, history, maths, russian_language, average_rating);      //форматированный вывод



            //Console.WriteLine($"Имя: {name,10}  Возраст: {age,10}   Рост: {height,10}  История: {history,10}  Математика: {maths,10} Русский_язык: {russian_language,10}  cредний_балл:{average_rating,10}"); //интерполяция строк
        }
    }
        }
    

