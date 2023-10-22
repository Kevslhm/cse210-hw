using System.Reflection.Metadata;

public class FunctionManager
{
    private List<LinearFunctions> _linearFunctions = new List<LinearFunctions>();
    private int _userNumber;
    private string _fileName = "Functions.txt";
    private float _mValue;
    private float _nValue;


    public void Run()
    {


        while (_userNumber != 5)
        {
            Console.WriteLine("Welcome to the Program!!");
            Console.WriteLine("This program will help you solve and graph the following types of Functions:");
            Console.WriteLine("1. Proporcional Function");
            Console.WriteLine("2. General Function");
            Console.WriteLine("3. Constant Funtion");
            Console.WriteLine("4. Cuadratic Function");
            Console.WriteLine("5. Quit");
            Console.Write("Please select a type of function you want to solve: ");
            _userNumber = int.Parse(Console.ReadLine());

            if (_userNumber == 1)
            {
                Console.Clear();
                Console.Write("Please type a proporcional function with the following format (y = m x): ");
                string lFunction = Console.ReadLine();
                SaveLinearFunction(_fileName, lFunction, _userNumber);
                ReadLinearFunction(_fileName);
                
                ProportionalityFunction pF = new ProportionalityFunction();
                pF.ValueTable(_mValue);
            }
            else if (_userNumber == 2)
            {
                Console.Clear();
                Console.Write("Please type a General function with the following format (y = m x + n): ");
                string lFunction = Console.ReadLine();
                SaveLinearFunction(_fileName, lFunction, _userNumber);
                ReadLinearFunction(_fileName);

                GeneralFunction generalFunction = new GeneralFunction();
                generalFunction.ValueTable(_mValue, _nValue);
            }
            else if (_userNumber == 3)
            {
                
            }
            else if (+_userNumber == 4)
            {
                
            }
        }
    }



    public void SaveLinearFunction(string fileName, string function, int userNumber) 
    {
        using(StreamWriter functionWriter = new StreamWriter (fileName))
        {
            if (userNumber == 1)
            {
                ProportionalityFunction proportionalityFunction = new ProportionalityFunction();
                proportionalityFunction.SetFunction(function);
                functionWriter.WriteLine(proportionalityFunction.GetFunctionData());
            }
            else if (userNumber == 2)
            {
                GeneralFunction generalFunction = new GeneralFunction();
                generalFunction.SetFunction(function);
                functionWriter.WriteLine(generalFunction.GetFunctionData());
            }
            
        }
    }

    public void ReadLinearFunction(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(':', ' ');

            if (parts[0] == "ProportionalFunction")
            {
                _mValue = float.Parse(parts[3]);
            }
            else if (parts[0] == "GeneralFunction")
            {
                _mValue = float.Parse(parts[3]);
                _nValue = float.Parse(parts[6]);
            }
            
        }
    }


    /* public void ValueTable()
    {
        List<int> xValues = new List<int>();

        Console.WriteLine("Please Select a series of number to take the x value in the table. (Type done when your done.)");
        Console.WriteLine("The numbers selected can be negative or positive.");

        string userNumber = "none";
        while (userNumber != "done")
        {
            Console.Write("Enter number: ");
            userNumber = Console.ReadLine();

            if (userNumber == "done")
            {
                break;
            }
            else
            {
                xValues.Add(int.Parse(userNumber));
            }
        }
        
        Console.WriteLine(" X | Y ");
        Console.WriteLine("-------");

        ProportionalityFunction pFunction = new ProportionalityFunction();


        foreach (int x in xValues)
        {
            pFunction.SetY(_mValue * x);
            if (x < 0)
            {
                Console.WriteLine($"{x} | {pFunction.GetY()}");
            }
            else
            {
                Console.WriteLine($"{x}  |  {pFunction.GetY()}");
            }

        }
        
    } */
}