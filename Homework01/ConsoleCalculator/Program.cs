class Calculator
{
    static public double Calculate(double num1,double num2,string op)
    {
        double result = double.NaN;//result默认为NaN
        switch (op)            
        {
            case "+":
                result = num1+num2;
                break;
            case "-":
                result = num1-num2;
                break ;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                //如果num2==0，result 不会抛异常，而是等于无穷
                if (num2 != 0)
                    result = num2 / num1;
                break ;
     
            default://这里result =NaN
                break;
        }
        return result;
    }
    
}
class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        Console.WriteLine("Console calculator in C#");

        while (!endApp)
        {
            string inNum1, inNum2;
            double cleanNum1, cleanNum2;

            //输入num1,num2
            Console.WriteLine("Please input num1");
            inNum1 = Console.ReadLine();
            while (!double.TryParse(inNum1, out cleanNum1)){
                Console.WriteLine("invalid num1\nTry again.");
                inNum1 = Console.ReadLine();
            }

            Console.WriteLine("Please input num2");
            inNum2 = Console.ReadLine();
            while (!double.TryParse(inNum2, out cleanNum2)){
                Console.WriteLine("invalid num2\nTry again.");
            }

            //输入运算符
            Console.WriteLine("Input an operator from +,-,*,/.");
            string op=Console.ReadLine();
            
            double result=Calculator.Calculate(cleanNum1,cleanNum2,op);
            if (double.IsNaN(result)) {
                Console.WriteLine("We've got a mathematical error.");
            }
            else
            {
                Console.WriteLine($"{cleanNum1}{op}{cleanNum2}={ result}");
            }

            Console.WriteLine("Press 'n' to close the app, or press any other key to continue");
            if (Console.ReadLine() == "n") endApp = true;
        }
    }
}