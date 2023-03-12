using ChallengeApp;

Employee employee1 = new Employee("Jan","Kowalski ", 25);
Employee employee2 = new Employee("Ewa", "Michalak", 30);
Employee employee3 = new Employee("Adam", "Kaminski", 21);


employee1.AddScore(9);
employee1.AddScore(7);
employee1.AddScore(8);
employee1.AddScore(5); 
employee1.AddScore(8);

employee2.AddScore(6);
employee2.AddScore(7);
employee2.AddScore(3);
employee2.AddScore(4);
employee2.AddScore(2);

employee3.AddScore(5); 
employee3.AddScore(8);
employee3.AddScore(6);
employee3.AddScore(5);
employee3.AddScore(9);


//interpolacja stringow
var statistics =employee1.GetStatistics();


Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}"); 



List<Employee> employees = new List<Employee>()
{
    employee1,  employee2,   employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;


foreach (var Employee in employees) 
{
    if (Employee.Result > maxResult)
    {
        employeeWithMaxResult = Employee;
        maxResult = Employee.Result;
    }
}
Console.WriteLine("Pracownik z najwieksza iloscia punktow to:" + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname +  " " 
+ maxResult + "punktow" );
Console.WriteLine("Wiek" + employeeWithMaxResult.Age);







  

