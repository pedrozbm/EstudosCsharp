using System.Data;

namespace ExercicioList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();


            Console.WriteLine("How many employees will be registered?");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {

                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                employee.Add(new Employee(id, name, salary));
            }
            Console.WriteLine("Enter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = employee.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                emp.increaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist! ");
            }
            Console.WriteLine("Update list od employees: ");
            foreach(Employee obj in employee)
            {
                Console.WriteLine(obj);
            }
        }
    }

}

