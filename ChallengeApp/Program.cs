
namespace ChallengeApp
{
    class Program
    {
        public static void  Main(string[] args)
        {
            Employee employee1 = new Employee("Adam", "Kowalski", 40);
            Employee employee2 = new Employee("Monika", "Potocka", 35);
            Employee employee3 = new Employee("Marek", "Kozub", 50);

            employee1.AddGrade(2);
            employee1.AddGrade(3);
            employee1.AddGrade(4);
            employee1.AddGrade(5);
            employee1.AddGrade(6);

            employee2.AddGrade(2);
            employee2.AddGrade(2);
            employee2.AddGrade(2);
            employee2.AddGrade(2);
            employee2.AddGrade(2);

            employee3.AddGrade(2);
            employee3.AddGrade(8);
            employee3.AddGrade(2);
            employee3.AddGrade(7);
            employee3.AddGrade(9);

            List<Employee> employees = new List<Employee>()
            {
                  employee1, employee2, employee3
            };
            int maxResult = 0;
            Employee employeeInMaxResult = null;

            foreach (Employee employee in employees)
            {
                if(employee.Result > maxResult)
                {
                    employeeInMaxResult=employee;
                }
            }
            Console.WriteLine($"{employeeInMaxResult.Name}  {employeeInMaxResult.SecoundName} " +
                $" zdobył {employeeInMaxResult.Result}  punktów plus premia");
        }
    }
} 












