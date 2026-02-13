using System;

class Program
{

	/* Go to Tools > Options.
     * In the search bar at the top left of the window, type IntelliCode.
     * Find C# user model predictions (or "Whole line completions") and set it to Disabled.
     * */

	static void Main()
	{
		bool running = true;

		while (running)
		{
			Console.Clear();

			Console.WriteLine("=== Burritos Shop Break Even Points Calculator ===");
			Console.WriteLine("1) Using For Loop");
			Console.WriteLine("2) Using While Loop");
			Console.WriteLine("3) Using Do-While Loop");
			Console.WriteLine("4) Exit");
			Console.Write("\nSelect an option: ");

			string input = Console.ReadLine();

			if (input == "1")
			{
				using_for_loop();
			}
			else if (input == "2")
			{
				using_while_loop();
			}
			else if (input == "3")
			{
				using_dowhile_loop();
			}
			else if (input == "4")
			{
				Console.WriteLine("Exiting program...");
				running = false;
			}
			else
			{
				Console.WriteLine("Invalid choice. Press any key to try again.");
				Console.ReadKey();
			}
		}
	}

	// --- Using For Loop ---

	static void using_for_loop()
	{
		Console.WriteLine("Calculating the break-even point using for loop ... ");
		Console.WriteLine("------------------------------------");

		// enter for loop code here
		decimal unit_price = 9.00m;
		decimal unit_cost = 3.80m;
		decimal fixed_cost = 1200.00m;

		int items_sold = 0;
		for (items_sold = 0; ; items_sold++)
		{
			decimal revenue = items_sold * unit_price;
			decimal cost = items_sold * unit_cost + fixed_cost;
			decimal profit = revenue - cost;
			if (profit > 0)
			{

				Console.WriteLine("------------------------------------");
				Console.WriteLine("Success! Profit reached.");
				Console.WriteLine($"Number of Burritos: {items_sold}");
				Console.WriteLine($"Revenue: {revenue:C2}");
				Console.WriteLine($"Cost: {cost:C2}");
				Console.WriteLine($"Profit: {profit:C2}");

				break;

			}
			else
			{
				Console.WriteLine($"After selling {items_sold} burritos: profit {profit:C2}.");
			}

		}
		Console.WriteLine("\nPress any key to return to menu...");
		Console.ReadKey();
	}

	// --- Using While Loop ---

	static void using_while_loop()
	{
		Console.WriteLine("Calculating the break-even point using while loop ... ");
		Console.WriteLine("------------------------------------");

		//enter while loop code here

		decimal unit_price = 9.00m;
		decimal unit_cost = 3.80m;
		decimal fixed_cost = 1200.00m;

		int items_sold = 0;
		decimal revenue = 0.00m;
		decimal cost = 0.00m;
		decimal profit = 0.00m;

		while (true)
		{
			revenue = items_sold * unit_price;
			cost = items_sold * unit_cost + fixed_cost;
			profit = revenue - cost;

			if (profit > 0)
			{
				Console.WriteLine("------------------------------------");
				Console.WriteLine("Success! Profit reached.");
				Console.WriteLine($"Number of Burritos: {items_sold}");
				Console.WriteLine($"Revenue: {revenue:C2}");
				Console.WriteLine($"Cost: {cost:C2}");
				Console.WriteLine($"Profit: {profit:C2}");
				break;
			}
			else
			{
				Console.WriteLine($"After selling {items_sold} burritos: profit {profit:C2}.");
			}

			items_sold++;
		}

		Console.WriteLine("\nPress any key to return to menu...");
		Console.ReadKey();
	}

	// --- Using Do-While Loop ---

	static void using_dowhile_loop()
	{
		Console.WriteLine("Calculating the break-even point using do-while loop ... ");
		Console.WriteLine("------------------------------------");
		
		//enter do-while code here
		decimal unit_price = 9.00m;
		decimal unit_cost = 3.80m;
		decimal fixed_cost = 1200.00m;

		int items_sold = 0;
		decimal revenue = 0.00m;
		decimal cost = 0.00m;
		decimal profit = 0.00m;

		do
		{
			revenue = items_sold * unit_price;
			cost = items_sold * unit_cost + fixed_cost;
			profit = revenue - cost;

			if (profit <= 0)
			{
				Console.WriteLine("------------------------------------");
				Console.WriteLine("Success! Profit reached.");
				Console.WriteLine($"Number of Burritos: {items_sold}");
				Console.WriteLine($"Revenue: {revenue:C2}");
				Console.WriteLine($"Cost: {cost:C2}");
				Console.WriteLine($"Profit: {profit:C2}");
				break;
			}
			else
			{
				Console.WriteLine($"After selling {items_sold} burritos: profit {profit:C2}.");
			}

			items_sold++;

		}
		while (true);

		Console.WriteLine("\nPress any key to return to menu...");
		Console.ReadKey();
	}
}