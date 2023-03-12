

namespace ChallengeApp
    {
        public class Employee
        {
            private List<int> score = new List<int>();

            public Employee(string name, string surname, int age)
            {
                this.Name = name;
                this.Surname = surname;
                this.Age = age;
            }



            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }

            public int Result
            {
                get
                {
                    return this.score.Sum();

                }

            }
            public void AddScore(int score)
            {
                this.score.Add(score);
            }
        public Statistics GetStatistics()
        {
            var statistics  = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MaxValue;
            statistics.Min = float.MinValue;
            
            foreach (var score in this.score)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Average += score;
            }
            statistics.Average /= this.score.Count;
            return statistics;

        }


        }

    }




