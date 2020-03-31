using System;
using System.IO;

namespace FileContaintApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the application\n");
            Console.WriteLine("Choose th option u want to perform \n\n");
            Program p = new Program();
           int choice;
            do
            {
            Console.WriteLine("1.	Copy a file\n");
            Console.WriteLine("2.	Rename a file\n");
            Console.WriteLine("3.	Concatenate two files\n");
            Console.WriteLine("4.	Create a file\n");
            Console.WriteLine("5.	Display contents of a file\n");

            choice = Convert.ToInt32(Console.ReadLine());

            
                switch (choice)
                {
                    case 1:
                        p.Copy();
                        break;


                    case 2:
                        p.RenameFile();
                        break;


                    case 3:
                        p.Concanate();
                        break;


                    case 4:
                        p.CreateFile();
                        break;

                    case 5:
                        p.Display();
                        break;


                    default:
                        Console.WriteLine("Invalid ckoice");
                        break;
                }
                
                

            } while (choice <= 5);

        }



        public void RenameFile() 
        {
            Console.WriteLine("Enter file source  you want to change on\n ");
             string sourceFile = Console.ReadLine();
            

            System.IO.FileInfo fi = new System.IO.FileInfo("D://"+sourceFile+".txt");
             
            if (fi.Exists)
            {
                Console.WriteLine("Enter new name  of file");
                string newName = Console.ReadLine();
                fi.MoveTo("D://"+newName+".txt");

                Console.WriteLine("File Renamed.");
            }

            else
            {
                Console.WriteLine("File does not exist ");
            }
        }

        public void Copy()
        {
            Console.WriteLine("Enter the source file name u want to copy");
            string source = Console.ReadLine();
            Console.WriteLine("Enter the destination file name u want to copy in ");
            string destination = Console.ReadLine();

            File.Delete("D://" + destination + ".txt");

            // File.Copy("D://" + source + ".txt", "D://" + destination + ".txt");

            File.Copy("D://" + source + ".txt", "D://" + destination + ".txt");
            
            Console.WriteLine("File copied..");


        }

        public void Concanate()
        {
          

            Console.Clear();
            string target = "Start ";
            Console.WriteLine("Enter Source file name\n");
            string source = Console.ReadLine();
            StreamReader sr = new StreamReader("D://" + source + ".txt");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
                target = target + str;
            }
            
            sr.Close();

            Console.WriteLine("Enter Destination file name\n");
            string destination = Console.ReadLine();
            StreamReader sr1 = new StreamReader("D://" + destination + ".txt");
            sr1.BaseStream.Seek(0, SeekOrigin.Begin);
            string str1 = sr1.ReadLine();
            while (str1 != null)
            {
                Console.WriteLine(str1);
                str1 = sr1.ReadLine();
                target = target + str1;
            }
           // target = target + str1;
            sr1.Close();

            Console.WriteLine("Enter new File name in which you want to append\n");
            string Targate = Console.ReadLine();
            StreamWriter sw = new StreamWriter("D://"+Targate+".txt");
            Console.WriteLine(target);

            //string path = $"D://" {0} ".txt",Targate;
           // Targate.AppendTex(target);
            //File.AppendText("D://" + Targate + ".txt");
            sw.WriteLine(target);
          
            
            
            sw.Flush();
            sw.Close();
            Console.WriteLine("file appended successfully");
        }


        public void CreateFile()
        {
           

            Console.WriteLine("Enter the Name of File you want to create");
            string fileName = Console.ReadLine();

            StreamWriter sw = new StreamWriter("D:/" + fileName + ".txt");
            Console.WriteLine("File Created Successfully!!");

            Console.WriteLine("Write text in File");
            string fileContent =Console.ReadLine();
            sw.WriteLine(fileContent);
            sw.Flush();
            sw.Close();
        }


        public void Display()
        {
            Console.WriteLine("Enter File Name");
            string fileName = Console.ReadLine();

            StreamReader sr = new StreamReader("D:/" + fileName + ".txt");
            Console.WriteLine("\n\n");

            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();

           while( str!=null)
                {
                Console.WriteLine(str);
                str = sr.ReadLine();
                 }
            Console.ReadLine();
            sr.Close();
            
        }

    }




}
