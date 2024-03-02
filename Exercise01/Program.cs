using Exercise01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Entre com o número de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine($"Dados do empregado #{i + 1}:");
                Console.Write("É terceirizado (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Horas trabalhadas: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'y' ||  ch == 'Y')
                {
                    Console.Write("Despesa adicional: ");
                    double AdditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, AdditionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pagamentos: ");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + 
                    " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
              
        }
    }
}
