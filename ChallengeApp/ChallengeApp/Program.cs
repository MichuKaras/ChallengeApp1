using ChallengeApp;

Employee employee1 = new Employee("Waldemar", "Kiepski", "35");
Employee employee2 = new Employee("Tadeusz", "Norek", "58");
Employee employee3 = new Employee("Barbara", "Mostowiak", "80");

employee1.AddScore(5);
employee1.AddScore(4);
employee1.AddScore(6);
employee1.AddScore(7);
employee1.AddScore(5);

employee2.AddScore(4);
employee2.AddScore(2);
employee2.AddScore(6);
employee2.AddScore(7);
employee2.AddScore(1);

employee3.AddScore(4);
employee3.AddScore(6);
employee3.AddScore(9);
employee3.AddScore(5);
employee3.AddScore(6);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;



foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Pracownik Miesiąca to:");
Console.WriteLine("Imie: " + employeeWithMaxResult.Name );
Console.WriteLine("Nazwisko: " + employeeWithMaxResult.Surename);
Console.WriteLine("Wiek: " + employeeWithMaxResult.Age + " lat");
Console.WriteLine("Wynik: " + employeeWithMaxResult.Result + " punktów");