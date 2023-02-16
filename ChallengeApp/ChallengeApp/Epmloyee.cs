namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
           this.Name = name;
           this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            //3.33
            //3
            // zaokrąglanie       w góre   /  w dół
            //int valueInInt = Math.Ceiling/Math.Floor
            int valueInInt = (int)grade; 
            float f = valueInInt;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("invalid grade value");
            }
        }
        public void AddGrade(double grade) 
        {
            var gradeMadeOfDouble = (float)grade;
            this.AddGrade(gradeMadeOfDouble);
        }
        public void AddGrade(long grade)
        {
                var gradeMadeOfLong = (float)grade;
                this.AddGrade(gradeMadeOfLong);
        }
        public void AddGrade(short grade)
        {
            var gradeMadeOfShort = (float)grade;
            this.AddGrade(gradeMadeOfShort);
        }
        public void AddGrade(decimal grade)
        {
            var gradeMadeOfDecimal = (float)grade;
            this.AddGrade(gradeMadeOfDecimal);
        }
        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("string is not float");
            }
            
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            // LUB statistics.Average /= this.grades.Count;
            statistics.Average = statistics.Average / this.grades.Count;
            return statistics;
        }
    }
}
 