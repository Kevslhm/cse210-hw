using System.Reflection.Metadata;

public class FunctionManager
{
    private List<LinearFunctions> _linearFunctions = new List<LinearFunctions>();
    private int _userNumber;
    private string _fileName = "Functions.txt";
    private float _mValue;
    private float _nValue;

    private float _aValue;
    private float _bValue;
    private float _cValue;
    private string _fOperator;
    private string _sOperator;


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
                Console.WriteLine("Please type a proporcional function with the following format (y = m x). ");
                Console.Write("Please leave and empty space between variables, numbers, and operators: ");
                string lFunction = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                SaveLinearFunction(_fileName, lFunction, _userNumber);
                ReadLinearFunction(_fileName);
                
                ProportionalityFunction pF = new ProportionalityFunction();
                pF.ValueTable(_mValue);
            }
            else if (_userNumber == 2)
            {
                Console.Clear();
                Console.WriteLine("Please type a General function with the following format (y = m x + n). ");
                Console.Write("Please leave and empty space between variables, numbers, and operators: ");
                string lFunction = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                SaveLinearFunction(_fileName, lFunction, _userNumber);
                ReadLinearFunction(_fileName);

                GeneralFunction generalFunction = new GeneralFunction();
                generalFunction.ValueTable(_mValue, _nValue, 0, 0, 0, _fOperator);
            }
            else if (_userNumber == 3)
            {
                Console.Clear();
                Console.WriteLine("Please type a Constant function with the following format (y = n). ");
                Console.Write("Please leave and empty space between variables, numbers, and operators: ");
                string lFunction = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                SaveLinearFunction(_fileName, lFunction, _userNumber);
                ReadLinearFunction(_fileName);

                ConstantFunction constantFunction = new ConstantFunction();
                constantFunction.ValueTable(0, _nValue);
            }
            else if (_userNumber == 4) 
            {
                Console.Clear();
                Console.WriteLine("Please type a Cuadratic function with the following format (y = a x ^ 2 + b x + c). ");
                Console.Write("Please leave and empty space between variables, numbers, and operators: ");
                string lFunction = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                SaveLinearFunction(_fileName, lFunction, _userNumber);
                ReadLinearFunction(_fileName);

                CuadraticFunction cuadraticFunction = new CuadraticFunction();
                cuadraticFunction.ValueTable(0, 0, _aValue, _bValue, _cValue, _fOperator, _sOperator);
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
            else if (userNumber == 3)
            {
                ConstantFunction constantFunction = new ConstantFunction();
                constantFunction.SetFunction(function);
                functionWriter.WriteLine(constantFunction.GetFunctionData());
            }
            else if (userNumber == 4)
            {
                CuadraticFunction cuadraticFunction = new CuadraticFunction();
                cuadraticFunction.SetFunction(function);
                functionWriter.WriteLine(cuadraticFunction.GetFunctionData());
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

                _fOperator = parts[5];
            }
            else if (parts[0] == "CuadraticFunction")
            {
                _aValue = float.Parse(parts[3]);
                _bValue = float.Parse(parts[8]);
                _cValue = float.Parse(parts[11]);

                _fOperator = parts[7];
                _sOperator = parts[10];
            }
            else if (parts[0] == "ConstantFunction")
            {
                _nValue = float.Parse(parts[3]);
            }
            
        }
    }

    public void Draw()
    {
        
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