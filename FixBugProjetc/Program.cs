while (true)
{

	try
	{
	
		int result = 0;
		Console.WriteLine("Enter  Number  1:");
		int  numberOne=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter  Number 2:");
        int numberTwo = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter  Operator:");
		var  operatorValue=Console.ReadKey().KeyChar;

    }
	catch (Exception)
	{

        Console.WriteLine("Error  Input");
    }

	try
	{
		switch (operatorValue)
		{
			case '*':
				result = numberOne * numbertwo;
                Console.WriteLine(result);
                break;

            case '/':
                resul = numberOne /numbertwo;
                Console.WriteLine(result);
                break;
            case '+':
                resul = numberOne + numbertwo;
                Console.WriteLine(result);
                break;
            case '-':
                resul = numberOne + numbertwo;
                Console.WriteLine(result);
                break;


            default:
                Console.WriteLine("Operator Is InValid");
                break;
		}
	}
	catch (Exception)
	{

		Console.WriteLine("Error in operation");
	}

}