using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //File handling
//File handling

//String functions - string.contains(),string.Startwith(), string.endswith()
//Collections - Generic collectoin, Non-Generic Collection

namespace Reading
{
    public class Reading
    {

        public void ReadFile()
        {


            FileStream fileStreamObj = new FileStream(@"D:\CSFiles\Data.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            //streamReaderObj.ReadLine();
            Console.WriteLine("Id" + "\t" + "Source" + "\t\t" + "Destination" + "\t" + "Date\t\t" + "Time\t\t" + "Status" + "\t" + "Network");
            while (streamReaderObj.Peek() > 0)
            {

                string line = streamReaderObj.ReadLine();
                if (line != "")
                {
                    string[] myStrs = line.Split(':');
                    if (myStrs[0] == "Date")
                    {

                        string[] dateTime = myStrs[1].Split(' ');

                        Console.Write(dateTime[0] + "\t" + dateTime[1] + ":" + myStrs[2] + ":" + myStrs[3] + "\t");

                    }
                    else
                    {
                        Console.Write(myStrs[1] + "\t");
                    }
                }
                else
                {
                    Console.WriteLine( );
                }

            }

            Console.WriteLine("\n" + "Read operation completed");

        }

        public void Success()
        {


            FileStream fileStreamObj = new FileStream(@"D:\CSFiles\Data.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            //streamReaderObj.ReadLine();
            Console.WriteLine("Id" + "\t" + "Status");
            while (streamReaderObj.Peek() > 0)
            {

                string line = streamReaderObj.ReadLine();
                if (line != "")
                {
                    string[] myStrs = line.Split(':');
                    if (myStrs[0] == "Status")
                    {
                        string status = myStrs[1];
                        if(status == "Success")
                        Console.Write(status + "\t");
                    }
                   else if (myStrs[0] == "Id")
                    {
                        Console.Write(myStrs[1] + "\t");
                    }
                }
                else
                {
                    Console.WriteLine();
                }

            }

            Console.WriteLine("\n" + "Read operation completed");

        }
        public void Failed()
        {


            FileStream fileStreamObj = new FileStream(@"D:\CSFiles\Data.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            //streamReaderObj.ReadLine();
            Console.WriteLine("Id" + "\t" + "Status");
            while (streamReaderObj.Peek() > 0)
            {

                string line = streamReaderObj.ReadLine();
                if (line != "")
                {
                    string[] myStrs = line.Split(':');
                    if (myStrs[0] == "Status")
                    {
                        string status = myStrs[1];
                        if (status == "Failed")
                            Console.Write(status + "\t");
                    }
                    else if (myStrs[0] == "Id")
                    {
                        Console.Write(myStrs[1] + "\t");
                    }
                }
                else
                {
                    Console.WriteLine();
                }

            }

            Console.WriteLine("\n" + "Read operation completed");

        }
        public void Missed()
        {


            FileStream fileStreamObj = new FileStream(@"D:\CSFiles\Data.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            //streamReaderObj.ReadLine();
            Console.WriteLine("Id" + "\t" + "Status");
            while (streamReaderObj.Peek() > 0)
            {

                string line = streamReaderObj.ReadLine();
                if (line != "")
                {
                    string[] myStrs = line.Split(':');
                    if (myStrs[0] == "Status")
                    {
                        string status = myStrs[1];
                        if (status == "Missed")
                            Console.Write(status + "\t");
                    }
                    else if (myStrs[0] == "Id")
                    {
                        Console.Write(myStrs[1] + "\t");
                    }
                }
                else
                {
                    Console.WriteLine();
                }

            }

            Console.WriteLine("\n" + "Read operation completed");

        }
        public void Dialled()
        {


            FileStream fileStreamObj = new FileStream(@"D:\CSFiles\Data.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReaderObj = new StreamReader(fileStreamObj);
            //streamReaderObj.ReadLine();
            Console.WriteLine("Id" + "\t" + "Status");
            while (streamReaderObj.Peek() > 0)
            {

                string line = streamReaderObj.ReadLine();
                if (line != "")
                {
                    string[] myStrs = line.Split(':');
                    if (myStrs[0] == "Status")
                    {
                        string status = myStrs[1];
                        if (status == "Dialled")
                            Console.Write(status + "\t");
                    }
                    else if (myStrs[0] == "Id")
                    {
                        Console.Write(myStrs[1] + "\t");
                    }
                }
                else
                {
                    Console.WriteLine();
                }

            }

            Console.WriteLine("\n" + "Read operation completed");

        }
        static void Main(string[] args)
        {
            Reading file = new Reading();

            file.ReadFile();
            //file.Success();
            //file.Failed();
            //file.Missed();
            //file.Dialled();
        }
    }
}

