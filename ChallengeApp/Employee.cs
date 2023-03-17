

namespace ChallengeApp;

public class Employee
{
    private List<float> score = new List<float>();

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
            return (int)this.score.Sum();

        }

    }
    public void AddScore(int score)
    {
        this.score.Add(score);
    }
    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        foreach (var score in this.score)
        {
            statistics.Max = Math.Max(statistics.Max, score);
            statistics.Min = Math.Min(statistics.Min, score);
            statistics.Average += score;
        }
        statistics.Average /= this.score.Count;
        return statistics;

    }

    public void AddScore(float score) 
        
    {
        if(score >= 0 && score<=100)
        {
            
            this.score.Add(score);
        }
        else
        {
            Console.WriteLine("Invalid score value");
        }
    }

    public void AddScore(string score)
    {
        if (float.TryParse(score, out float result))
        {
            this.score.Add(result);
        }
        else
        {
            Console.WriteLine("String is not a float");
        }
    }

    public void AddScore(double score)
    {
            var DoubleAsFloat = (float)score;
            this.AddScore(DoubleAsFloat);
           
    }

    public void AddScore(decimal score)
    {
        var DoubleAsFloat = (float)score;
        this.AddScore(Result);
    }
   
    
    public void AddScore(long score)
    {
        var DoubleAsFloat = (float)score;
        this.AddScore(Result);
    }
 }







