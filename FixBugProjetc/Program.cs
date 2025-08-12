char operatorValue='\0';
decimal result=0;
int numberOne=0;
 int numberTwo = 0;
while (true)
{

	try
	{
	
		 result = 0;
		Console.WriteLine("Enter  Number  1:");
		  numberOne=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter  Number 2:");
         numberTwo = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter  Operator:");
	  operatorValue=Console.ReadKey().KeyChar;

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
				result = numberOne * numberTwo;
                Console.WriteLine(result);
                break;

            case '/':
                result = numberOne / numberTwo;
                Console.WriteLine(result);
                break;
            case '+':
                result = numberOne + numberTwo;
                Console.WriteLine(result);
                break;
            case '-':
                result = numberOne + numberTwo;
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