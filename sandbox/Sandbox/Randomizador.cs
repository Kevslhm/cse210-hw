public class Randomizador
{
    private List<int> _numbers = new List<int>();


    public void GetRandom()
    {
        _numbers.Add(0);
        int randomnumber;

        for (int i = 0; i < 15; i++)
        {
            Random random = new Random();
            randomnumber = random.Next(0, 15);
            _numbers.Add(randomnumber);

            foreach (int n in _numbers)
            {
                if (randomnumber != n)
                {
                    Console.WriteLine(n);
                }
            }
        }
        
    }
}