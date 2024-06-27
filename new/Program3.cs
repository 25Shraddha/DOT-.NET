using System;

public class Test
{
	public static void Main()
	{
		// your code goes here

		// string [] s=Console.ReadLine().Split(' ');
        // int x=int.Parse(s[0]);
        // int y=int.Parse(s[1]);


		string input = Console.ReadLine();

		string [] inputs = input.Split(' ');
		//int stoves = Convert.ToInt32(Console.ReadLine());
		//int minutes = Convert.ToInt32(Console.ReadLine());
		int stoves = Convert.ToInt32(inputs[0]);
		int minutes = Convert.ToInt32(inputs[1]);
	
		Console.WriteLine(stoves * minutes);
	}
}
