﻿using System;
namespace Display
{
	public class DisplayToUser
	{
		public static void Display()
		{
            Console.WriteLine("Press 1 to add cat food");
            Console.WriteLine("Press 2 to add a dog leash");
            Console.WriteLine("Press 3 to view a dog leash");
            Console.WriteLine("Press 4 to view in stock items");
            Console.WriteLine("Press 5 to view out of stock items");
            Console.WriteLine("Type 'exit' to quit\n");
        }
	}
}

