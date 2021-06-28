using System;
using System.IO;

namespace ConsoleNotePad
{
	class Program
	{
		static void Main(string[] args)
		{
			var fileOpenMessage = string.Empty;
			var fileSaveMessage = string.Empty;
			var destinationChoice = string.Empty;
			var keyWord = string.Empty;
			var option = string.Empty;

			Console.Title = "Console NotePad";
			Console.Write("Important: ", Console.ForegroundColor = ConsoleColor.Blue);
			Console.ResetColor();
			Console.WriteLine("Include File name and extension when providing destination!");
			Console.ResetColor();
			Console.Write("Option: ", Console.ForegroundColor = ConsoleColor.Blue);
			Console.ResetColor();
			Console.WriteLine("1. Reads from file and outputs in console.");
			Console.Write("Option: ", Console.ForegroundColor = ConsoleColor.Blue);
			Console.ResetColor();
			Console.WriteLine("2. Lets you type into the console and save it as text document.");
			Console.Write("Selection: ", Console.ForegroundColor = ConsoleColor.Blue);
			Console.ResetColor();
			Console.Write("1/2: ");
			option = Console.ReadLine();
			switch (option)
			{
				case "1":
					Console.Write("Destination selection: ", Console.ForegroundColor = ConsoleColor.Blue);
					Console.ResetColor();
					destinationChoice = Console.ReadLine();
					using (var openFile = new StreamReader(destinationChoice))
					{
						fileOpenMessage = openFile.ReadLine();
						while (fileOpenMessage != null)
						{
							Console.WriteLine(fileOpenMessage);
							fileOpenMessage = openFile.ReadLine();
						}

					}
					Console.ReadLine();
					break;

				case "2":
					Console.Write("Destination selection: ", Console.ForegroundColor = ConsoleColor.Blue);
					Console.ResetColor();
					destinationChoice = Console.ReadLine();
					Console.Write("Choose keyword to stop: ", Console.ForegroundColor = ConsoleColor.Blue);
					Console.ResetColor();
					keyWord = Console.ReadLine();
					Console.WriteLine("\n------------------------------------------------------------------------", Console.ForegroundColor = ConsoleColor.Blue);
					Console.ResetColor();
					fileSaveMessage = Console.ReadLine();
					using (var saveFile = new StreamWriter(destinationChoice))
					{
						while (fileSaveMessage != keyWord)
						{
							saveFile.WriteLine(fileSaveMessage);
							fileSaveMessage = Console.ReadLine();
						}
						saveFile.Close();
					}
					break;

				default:
					Console.WriteLine("Invalid option. Restart the application.");
					break;
			}
		}
	}
}