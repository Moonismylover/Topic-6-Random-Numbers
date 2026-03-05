namespace Topic_6___Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Topic 6 - Random Numbers";

            // Create a random number generator. Only one!

            Random generator = new Random(989890);
            int randNum;           // We will store our random number in this variable.

            randNum = generator.Next(10);
            // Generates a random number from 0 to 9 (10 is not included).

            
            Console.WriteLine("My random number is " + randNum);

            Console.WriteLine();

            Console.WriteLine("Here are some numbers from 0 to 4!");
            Console.Write(generator.Next(1, 5) + " ");
            Console.Write(generator.Next(1, 5) + " ");
            Console.Write(generator.Next(1, 5) + " ");
            Console.Write(generator.Next(1, 5) + " ");
            Console.Write(generator.Next(1, 5) + " ");
            Console.WriteLine(generator.Next(1, 5) + " ");
            Console.WriteLine();

            Console.WriteLine("Here are some numbers from 0 to 99!");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.WriteLine(generator.Next(100) + " ");
            Console.WriteLine();
            int num1 = generator.Next(10);
            int num2 = generator.Next(10);
            
            if (num1 == num2)
            {
                Console.WriteLine("The random numbers were the same! Weird.");
            }

            if (num1 != num2)
            {
                Console.WriteLine("The random numbers were different! Not weird. ");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue..."); 

            /*
            Questions:

            1) What do you think you could change so that you make random numbers from 0-5? 0-100?

                I could change the numbers in the brackets of the Next() method. 
                Ex. If I wanted 0-5, I would do: generator.Next(6) because that way 6 is not included. 
                Ex. If I wanted 0-100, I would do: generator.Next(101) because that way 101 is not included.

            2) Change the call of the Next() method on all six lines that pick numbers from 0-4, so
            that they look like this: Console.Write(generator.Next(1, 5) + " ");

            Run the program a few times. Is it picking random numbers from 1 to 5? If not, what
            range are they in? Can you fix it to pick numbers from 1 to 5? How about 3 to 5?

                It is picking random numbers from 1 to 4. The Next() method does not include the second number. 
                Therefore, (1, 5) means it will start at 1 and go up to but not include 5.

            3) Change the line where you create the random number generator so that it looks like
               this: Random generator = new Random(12353); This number is called a seed. 
               Run the program a few times. What do you notice? What happened to the random numbers?

                The generated numbers are always the same. The seed is the starting point for the random number 
                generator. If you use the same seed, you will get the same sequence of random numbers.

            4) Change the random seed to something else and observe the behavior. What happens to the 
               random numbers? (remove the seed when you are done).
             
                The generated numbers are different from the previous seed. 
                This is because the seed determines the sequence of random numbers generated. 
                If you change the seed, you will get a different sequence of random numbers.
            
            generator.Next(100, 200); --> numbers from 100 to 199
            numbers from 100 to 200 --> generator.Next(100, 201);
            numbers from 55 to 75 --> generator.Next(55, 76);
            numbers from 0 to 1000 --> generator.Next(1001);
            generator.Next(num); --> numbers from 0 to num is not included
            generator.Next(num1, num2); --> numbers from num1 to the number before num2
            generator.Next(num1, num2 + 1) --> numbers from num1 to num2

            */

            Console.ReadLine();
            Console.Clear();

            // Task 1

            int min, max, randnum;

            Console.WriteLine("Hey! Give me two whole values with a certain distance between them.");
            Console.WriteLine();
            Console.Write("Minimum value: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Maximum value: ");
            max = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine();

            randNum = generator.Next(min, max + 1);

            Console.WriteLine("Your random number is " + randNum);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");  
            Console.ReadLine();
            Console.Clear();

            // Task 2

            int guess, secretNum;

            Console.WriteLine("Let's play a guessing game! I will pick a random number from 1 to 10, and you have to guess it.");
            secretNum = generator.Next(1, 11);  
            Console.WriteLine();
            Console.Write("Your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (guess == secretNum)
            {
                Console.WriteLine("Congrats! You got it right!");
            }
            else
            {
                Console.WriteLine("Sorry, the correct number was " + secretNum + "... Imma peace out now!");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();

            // Task 3

            int dice1, dice2;

            Console.WriteLine("Let's roll some dice! I will roll two dice and add them together.");
            Console.WriteLine();

            dice1 = generator.Next(1, 7);   
            dice2 = generator.Next(1, 7);   

            Console.WriteLine("You rolled a " + dice1 + " and a " + dice2 + " for a total of " + (dice1 + dice2) + "!");
            
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
