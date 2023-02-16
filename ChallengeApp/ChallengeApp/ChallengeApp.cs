﻿using ChallengeApp;

var employee = new Employee("Michał", "Karaś");
employee.AddGrade("Adam");
employee.AddGrade("4000");
employee.AddGrade(2);
employee.AddGrade(6);
employee.AddGrade(7.55);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");