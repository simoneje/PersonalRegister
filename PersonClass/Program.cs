using System;

namespace PersonalRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Register register = new Register();
            Employee employee1 = new Employee()
            {
                Name = "Henry",
                Salary = 100000,
                EmploymentDate = DateTime.Now
            };
            Employee employee2 = new Employee()
            {
                Name = "Maria",
                Salary = 60000,
                EmploymentDate = DateTime.Now
            };
            register.setEmployee(employee1);
            register.setEmployee(employee2);
            Console.Clear();
            Console.WriteLine("Välkommen till Personal Registret!");
            Console.WriteLine("Vänligen välj ett alternativ.\n1. Lägg till en ny anställd\n2. Öppna personal registret");
            try
            {
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Namn: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Lön (hela siffror endast): ");
                        int salary = int.Parse(Console.ReadLine());
                        DateTime date = DateTime.Now;
                        Employee employee = new Employee()
                        {
                            Name = name,
                            Salary = salary,
                            EmploymentDate = date
                        };
                        register.setEmployee(employee);
                        break;
                    case 2:
                        register.checkRegisterName();
                        Console.WriteLine("Skriv in ID på den du vill veta mer om eller tryck 0 för att gå tillbaka");
                        int choice2 = int.Parse(Console.ReadLine());
                        if (choice2 == 0)
                            break;
                        else
                        {
                            register.getEmployee(choice2);
                        }
                        break;
                }
            }
            catch(Exception er)
            {
                Console.Clear();
                Console.WriteLine("Oj oj, något gick fel!");
                Console.WriteLine(er);
            }
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }
        public DateTime EmploymentDate { get; set; }

    }
    class Register
    {
        public Dictionary<int, Employee> employeeRegister = new Dictionary<int, Employee>();
        // nextid är en intern variabel för klassen
        private int NextId = 1;
        public void setEmployee(Employee emp)
        {
            employeeRegister.Add(NextId, emp);
            NextId++;
        }
        public void checkRegisterName()
        {
            Console.Clear();
            foreach (var kvp in employeeRegister)
            {
                
                Console.WriteLine(kvp.Key + ". " + kvp.Value.Name);
            }
        }
        public void getEmployee(int id)
        {
            foreach (var kvp in employeeRegister)
            {
                if (id == kvp.Key)
                {
                    Console.WriteLine("Namn: " + kvp.Value.Name + "\nLön: " + kvp.Value.Salary + "\nStart Datum: " + kvp.Value.EmploymentDate);
                    break;
                }
                else
                {
                    Console.WriteLine("Angiven individ hittas inte i registret");
                }
            }
        }
    }
}