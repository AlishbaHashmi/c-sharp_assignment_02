// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//1)

//Console.WriteLine("Enter First Number : ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Second Number : ");
//int num2 = Convert.ToInt32(Console.ReadLine());


//int addition = num1 + num2;
//Console.WriteLine($"Addition : {addition}");
//int subtraction = num1 - num2;
//Console.WriteLine($"Subtraction : {subtraction}");
//int multiplication = num1 * num2;
//Console.WriteLine($"Multiplication : {multiplication}");
//int division = num1 / num2;
//Console.WriteLine($"Division : {division}");
//int modulus = num1 % num2;
//Console.WriteLine($"Modulus : {modulus}");



//2)

//Console.WriteLine("Enter First Number : ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter Second Number : ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num1 > num2)
//{
//    Console.WriteLine("First number is Greater than Second number");
//}
//else if (num1 < num2)
//{
//    Console.WriteLine("First number is Less than Second number");
//}
//else 
//{
//    Console.WriteLine("First number is Equal to Second number");
//}



//3)


//Console.WriteLine("Enter a number : ");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"The multiplication table of your entered number {number} is : ");

//for (int i= 1; i <= 10; i++)
//{
//    int result = number * i;
//    Console.WriteLine($"{number} x {i} = {result}");
//}



//4)

//Console.WriteLine("Pattern of Asterisks : \n");

//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}  



//5)

//int sum = 0;
//for (int i = 1; i <= 100; i++)
//{
//    if(i %2 != 0)
//    {
//        continue;
//    }

//    sum += i;

//    if (i == 100)
//    {
//        break;
//    }
//    Console.WriteLine(i);
//}
//Console.WriteLine($"The sum of all even numbers between 1 and 100 is : {sum}");



//6)

//Console.WriteLine("Enter a word");
//string input = Console.ReadLine();

//string reverse = "";

//for (int i = input.Length- 1; i >=0; i--)
//{
//    reverse = reverse + input[i];
//}
//Console.WriteLine($"The reversed string is : {reverse}");



//7)


//Console.WriteLine("Prime numbers between 1 to 100  is : ");
//bool prime = true;

//for (int i = 2; i <= 100; i++) 
//{
//    for (int j = 2; j <= 100; j++)
//    {
//        if (i != j && i % j == 0) 
//        {
//            prime = false;
//            break;
//        }
//    }
//    if (prime)
//    {
//        Console.Write($"{i} \n");
//    }
//    prime = true;
//}
//Console.WriteLine();

