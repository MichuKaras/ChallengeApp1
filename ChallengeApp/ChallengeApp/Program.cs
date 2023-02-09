using ChallengeApp;

User employee1 = new User("Waldemar", "Kiepski");
User employee2 = new User("Tadeusz", "Norek");
User employee3 = new User("Barbara", "Mostowiak");

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

List<User> employees = new List<User>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
User employeeWithMaxResult = null;



foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
    }
}

