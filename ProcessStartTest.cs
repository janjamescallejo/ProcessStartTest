using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;


namespace ProcessStartTest
{
    class ProcessStartTest
    {
        static void ReadEmpath()
        {
            Console.WriteLine("Runs Empath");
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.FileName = "java";
                myProcess.StartInfo.Arguments = @"-jar C:\\Users\\Lenovo\\Desktop\\Thesis\\EMPATHCMS\\EmpathCMS.jar 9_KjnGMlmjVaJLMphp4dJi4ZQoDKLoWWs-q9bsFPpB8 C:\Users\Lenovo\Desktop\Thesis\Interview\SegmentedCuts\Number58\58";
                myProcess.Start();
                myProcess.WaitForExit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            string part;
            string temporarypath = @"C:\Users\Lenovo\Desktop\Thesis\EMPATHCMS\Temporary.txt";
            System.Console.WriteLine("Contents of Empath.txt = ");
            using (var input = new StreamReader(temporarypath))
            {
                while (!input.EndOfStream)
                {
                    
                    var splits = input.ReadLine().Split(',');
                    if (splits[0] == "")
                        continue;
                    for (int i = 0; i < 6; i++)
                    {
                        part = splits[i];
                        var splits2 = part.Split(':');
                        Console.Write("{0}, ", splits2[1]);
                    }
                    Console.Write("\n");
                }
            }
                
        }
        static void ReadCSV()
        {
            List<TimeStamp> Ts = new List<TimeStamp>();
            string path = "CSV Files/20171016080633.csv";
            using (var input = new StreamReader(path))
            {
                while (!input.EndOfStream)
                {
                    var splits = input.ReadLine().Split(',');
                    TimeStamp ts = new TimeStamp(splits[0], splits[11], splits[12], splits[13], splits[14], splits[15], splits[16], splits[17]);
                    Ts.Add(ts);
                    
                }
            }
            Console.WriteLine("Display Time Stamps");
            foreach(TimeStamp t in Ts)
            {
                Console.WriteLine(t.Timestamp);
            }
            
        }
        static void RunAffectiva()
        {
            //Change this to include Affectiva Video
            Console.WriteLine("Runs Affectiva");
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.FileName = @"C:\Users\Lenovo\Desktop\Thesis\cpp-sdk-samples-master\cpp-sdk-samples-master\x64\Release\opencv-webcam-demo.exe";
                myProcess.StartInfo.Arguments = @"-d ""C:\Program Files\Affectiva\Affdex SDK\data""  -l ""C:\Users\Lenovo\Desktop\Thesis\sdk_dgsison1972@yahoo.com.license"" ";
                myProcess.Start();
                myProcess.WaitForExit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void AbsolutePath()
        {
            bool exists = File.Exists("CSV Files/20171016080633.csv");
            if (exists == true)
                Console.WriteLine("File Exists");
            else
                Console.WriteLine("File Doesn't Exist");
        }
        static void Main(string[] args)
        {
            //ReadCSV();
            //ReadEmpath();
            RunAffectiva();
            //AbsolutePath();
            Console.ReadKey();

        }
        
       
    }

}
