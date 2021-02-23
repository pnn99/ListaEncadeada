using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListaEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.Write("Quantos empregados serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Empregado #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salário: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Entre com a Id do empregado que vai receber o aumento : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);
            if (emp != null) {
                Console.Write("Insira a porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("Está Id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada:");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
        }
    }
