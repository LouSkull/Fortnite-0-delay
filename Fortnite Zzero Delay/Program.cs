using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.WriteLine(@"
  ______                    _____       _             
 |___  /                   |  __ \     | |            
    / / _______ _ __ ___   | |  | | ___| | __ _ _   _ 
   / / |_  / _ \ '__/ _ \  | |  | |/ _ \ |/ _` | | | |
  / /__ / /  __/ | | (_) | | |__| |  __/ | (_| | |_| |
 /_____/___\___|_|  \___/  |_____/ \___|_|\__,_|\__, |
                                                 __/ |
                                                |___/     0.1 By LouSkull
");
        Console.WriteLine("Choose an option:");
        Console.WriteLine();
        Console.WriteLine("1. Enable Zero Delay in Fortnite");
        Console.WriteLine("2. Disable Zero Delay in Fortnite");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Your Choose -->  ");
        if (int.TryParse(Console.ReadLine(), out int userChoice))
        {
            switch (userChoice)
            {
                case 1:
                    string batchFilePath1 = "Registry\\Enable.bat";
                    StartBatchFile(batchFilePath1);
                    Console.WriteLine("Successfully!");
                    Console.Write("Do you wanna start fortnite? (1,2)  ");
                    string StartFortnite = Console.ReadLine();
                    
                    if(StartFortnite == "1")
                    {
                        Process.Start("FortniteLauncher.url");
                    }

                    else if(StartFortnite == "2")
                    {
                        Console.WriteLine("Bye...");
                        Environment.Exit(0);
                    }

                    break;

                case 2:
                    string batchFilePath2 = "Registry\\Disable.bat";
                    StartBatchFile(batchFilePath2);
                    Console.WriteLine("Successfully!");
                    Console.Write("Do you wanna start fortnite? (1,2)  ");
                    string StartFortnite1 = Console.ReadLine();

                    if (StartFortnite1 == "1")
                    {
                        Process.Start("FortniteLauncher.url");
                    }

                    else if (StartFortnite1 == "2")
                    {
                        Console.WriteLine("Bye...");
                        Environment.Exit(0);
                    }

                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void StartBatchFile(string filePath)
    {
        try
        {
            if (!System.IO.File.Exists(filePath))
            {
                Console.WriteLine($"Batch file not found: {filePath}");
                return;
            }
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c call \"{filePath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process { StartInfo = psi };
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            Console.WriteLine(output);

            if (!string.IsNullOrWhiteSpace(error))
            {
                Console.WriteLine("Batch file error:");
                Console.WriteLine(error);
            }

            process.WaitForExit();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
