var name = "Ewa";
string gender = "Kobieta";
string gender1 = "Mężczyzna";
int age = 33;
int age1 = 17;
   
if (gender == "Kobieta" && age > 27)
{
        Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age <= 33)
{
        Console.WriteLine("Ewa, lat 33");
}
if (gender1 == "Mężczyzna")
{
    if (age1 < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("Pełnoletni mężczyzna");
    }
}