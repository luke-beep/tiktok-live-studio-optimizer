#region TikTok LIVE Cleaner
#region Imports
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using TikTokLIVECleaner;
#endregion
#region Program
internal class Program
{
    #region Main
    private static void Main(string[] args)
    {
        
        #region Main Null Check
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }
        #endregion
        #region Methods
        Startup();
        #endregion




    }
    #endregion
    #region Startup
    public static void Startup()
    {
        /*string currdir = System.IO.Directory.GetCurrentDirectory();
        string finalpath = currdir + "\\tiktok_cleaner.json";
        if (!File.Exists(finalpath))
        {
            try
            {
                using (FileStream fs = new FileStream(finalpath, FileMode.CreateNew))
                {
                    byte[] content = System.Text.Encoding.UTF8.GetBytes("{\r\n  \"welcome\": \"TikTok LIVE Cleaner\",\r\n  \"color\": \"White\"\r\n}");
                    fs.Write(content, 0, content.Length);
                }
                Console.WriteLine("File created successfully at " + finalpath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        else
        {
            Console.WriteLine("File already exists at " + finalpath);
        }

        String jsonString = new StreamReader(finalpath).ReadToEnd();
        var tikTokLiveCleaner = TikTokLiveCleaner.FromJson(jsonString);
        string color = tikTokLiveCleaner.Color;*/
        


        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("░▀█▀░▀█▀░█░█░▀█▀░█▀█░█░█░░░█▀▀░▀█▀░█░█░█▀▄░▀█▀░█▀█░░░█▀█░█▀█░▀█▀░▀█▀░█▄█░▀█▀░▀▀█░█▀▀░█▀▄\r\n░░█░░░█░░█▀▄░░█░░█░█░█▀▄░░░▀▀█░░█░░█░█░█░█░░█░░█░█░░░█░█░█▀▀░░█░░░█░░█░█░░█░░▄▀░░█▀▀░█▀▄\r\n░░▀░░▀▀▀░▀░▀░░▀░░▀▀▀░▀░▀░░░▀▀▀░░▀░░▀▀▀░▀▀░░▀▀▀░▀▀▀░░░▀▀▀░▀░░░░▀░░▀▀▀░▀░▀░▀▀▀░▀▀▀░▀▀▀░▀░▀");
        Console.WriteLine("\n");
        Thread.Sleep(1000);
        Console.WriteLine("Welcome to the TikTok LIVE Studio Optimizer!\n");
        Console.WriteLine("Press Space to start.");
        Console.WriteLine("Press Escape to exit.\n");
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.Spacebar)
        {
            ClearWatchDog();
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("░▀█▀░▀█▀░█░█░▀█▀░█▀█░█░█░░░█▀▀░▀█▀░█░█░█▀▄░▀█▀░█▀█░░░█▀█░█▀█░▀█▀░▀█▀░█▄█░▀█▀░▀▀█░█▀▀░█▀▄\r\n░░█░░░█░░█▀▄░░█░░█░█░█▀▄░░░▀▀█░░█░░█░█░█░█░░█░░█░█░░░█░█░█▀▀░░█░░░█░░█░█░░█░░▄▀░░█▀▀░█▀▄\r\n░░▀░░▀▀▀░▀░▀░░▀░░▀▀▀░▀░▀░░░▀▀▀░░▀░░▀▀▀░▀▀░░▀▀▀░▀▀▀░░░▀▀▀░▀░░░░▀░░▀▀▀░▀░▀░▀▀▀░▀▀▀░▀▀▀░▀░▀");
            Console.WriteLine("\n");
            Console.WriteLine("Starting TikTok LIVE Studio Optimizer...");
            Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("░▀█▀░▀█▀░█░█░▀█▀░█▀█░█░█░░░█▀▀░▀█▀░█░█░█▀▄░▀█▀░█▀█░░░█▀█░█▀█░▀█▀░▀█▀░█▄█░▀█▀░▀▀█░█▀▀░█▀▄\r\n░░█░░░█░░█▀▄░░█░░█░█░█▀▄░░░▀▀█░░█░░█░█░█░█░░█░░█░█░░░█░█░█▀▀░░█░░░█░░█░█░░█░░▄▀░░█▀▀░█▀▄\r\n░░▀░░▀▀▀░▀░▀░░▀░░▀▀▀░▀░▀░░░▀▀▀░░▀░░▀▀▀░▀▀░░▀▀▀░▀▀▀░░░▀▀▀░▀░░░░▀░░▀▀▀░▀░▀░▀▀▀░▀▀▀░▀▀▀░▀░▀");
            Console.WriteLine("\n");
            Console.WriteLine("Listening for any process containing the name 'TikTok LIVE Studio'...");
            Console.WriteLine("\n");
            GetRunTime();
        }
        else if (key.Key == ConsoleKey.Escape)
        {
            Environment.Exit(0);
        }
    }
    #endregion
    #region ClearWatchDog
    public static void ClearWatchDog()
    {
        try
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string finalpath = Path.Combine(path, "TikTok LIVE Studio", "watchdog");
            foreach (string cache in Directory.EnumerateDirectories(finalpath))
            {
                Directory.Delete(cache, true);
                Console.WriteLine("\n");
                Console.WriteLine("Successfully deleted the folder at: " + cache);
            }
        } catch(Exception e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string finalpath = Path.Combine(path, "TikTok LIVE Studio", "watchdog");
            Console.WriteLine("Couldn't find TikTok Live Studio!");
            Console.WriteLine("An error occured looking for: "+ finalpath);
            Environment.Exit(0);
        }
    }
    #endregion
    #region GetRunTime
    public static void GetRunTime()
    {
        try
        {
            bool GetRuntimeBool = true;
            while (GetRuntimeBool)
            {
                Process[] pname = Process.GetProcessesByName("TikTok LIVE Studio");
                if (pname.Length > 0)
                {
                    foreach (var processr in pname)
                    {
                        Console.WriteLine("\nFound one!\n" + "Process ID: " + processr.Id + " | Process Name: " + processr.ProcessName);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("TikTok LIVE Studio is running with the PID: {0}", pname[0].Id);
                    if (pname.Length != 0)
                    {
                        Process process = Process.GetProcessById(pname[0].Id);
                        if (process != null)
                        {
                            process.WaitForExit();
                            ClearWatchDog();
                            Console.WriteLine("TikTok LIVE Studio has been terminated"); // Might error as pname[0] may not exist at this time
                        }
                    }
                    Thread.Sleep(10);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
    /*public static string settings()
    {
        string currdir = System.IO.Directory.GetCurrentDirectory();
        string finalpath = currdir + "\\tiktok_cleaner.json";
        if (!File.Exists(finalpath))
        {
            try
            {
                using (FileStream fs = new FileStream(finalpath, FileMode.CreateNew))
                {
                    byte[] content = System.Text.Encoding.UTF8.GetBytes("{\r\n  \"welcome\": \"TikTok LIVE Cleaner\",\r\n  \"color\": \"9\"\r\n}");
                    fs.Write(content, 0, content.Length);
                }
                Console.WriteLine("File created successfully at " + finalpath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        else
        {
            Console.WriteLine("File already exists at " + finalpath);
        }

        String jsonString = new StreamReader(finalpath).ReadToEnd();
        var tikTokLiveCleaner = TikTokLiveCleaner.FromJson(jsonString);
        string color = tikTokLiveCleaner.Color;
        return color;

    }*/
}


    #endregion

#endregion
#endregion
