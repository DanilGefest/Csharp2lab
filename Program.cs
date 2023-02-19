using System;

namespace BasicFile {
    internal class Program {
        private static void DocumentOutput(BasicDocument basicFile) // материнский класс
        {
            basicFile.PrintValues();
        }

        public class MSExcelDocument : BasicDocument {  //ввод дочкрних классов и инфы по ним
            public string Name { get; set; }
            public string Authors { get; set; }
            public string[] KeyWords { get; set; }
            public string Theme { get; set; }
            public string PathToFile { get; set; }

            public string FileInfo1 { get; set; }
            public string FileInfo2 { get; set; }
            public string FileInfo3 { get; set; }


            public override void PrintValues()
            {
                Console.WriteLine($"FileInfo1: {FileInfo1}\nFileInfo2: {FileInfo2}\nFileInfo3: {FileInfo3}");
                Console.ReadKey();
            }

        }
        public class HTML : BasicDocument {
            public string Name { get; set; }
            public string Authors { get; set; }
            public string[] KeyWords { get; set; }
            public string Theme { get; set; }
            public string PathToFile { get; set; }

            public string FileInfo4 { get; set; }
            public string FileInfo5 { get; set; }

            public override void PrintValues()
            {
                Console.WriteLine($"FileInfo4: {FileInfo4}\nFileInfo5: {FileInfo5}");
                Console.ReadKey();
            }
        }
        public class PDF : BasicDocument {
            public string Name { get; set; }
            public string Authors { get; set; }
            public string[] KeyWords { get; set; }
            public string Theme { get; set; }
            public string PathToFile { get; set; }

            public string FileInfo6 { get; set; }
            public string FileInfo7 { get; set; }

            public override void PrintValues()
            {
                Console.WriteLine($"FileInfo6: {FileInfo6}\nFileInfo7: {FileInfo7}");
                Console.ReadKey();
            }
        }
        public class TXT : BasicDocument {
            public string Name { get; set; }
            public string Authors { get; set; }
            public string[] KeyWords { get; set; }
            public string Theme { get; set; }
            public string PathToFile { get; set; }

            public string FileInfo8 { get; set; }
            public string FileInfo9 { get; set; }

            public override void PrintValues()
            {
                Console.WriteLine($"FileInfo8: {FileInfo8}\nFileInfo9: {FileInfo9}");
                Console.ReadKey();
            }
        }
        public class Word : BasicDocument {
            public string Name { get; set; }
            public string Authors { get; set; }
            public string[] KeyWords { get; set; }
            public string Theme { get; set; }
            public string PathToFile { get; set; }

            public string FileInfo10 { get; set; }
            public string FileInfo11 { get; set; }
            public string FileInfo12 { get; set; }

            public override void PrintValues()
            {
                Console.WriteLine($"FileInfo10: {FileInfo10}\nFileInfo11: {FileInfo11}\nFileInfo12: {FileInfo12}");
                Console.ReadKey();
            }
        }

        public class BasicDocument {
            public string Name { get; set; }
            public string Authors { get; set; }
            public string[] KeyWords { get; set; }
            public string Theme { get; set; }
            public string PathToFile { get; set; }

            public virtual void PrintValues()
            {
                string str = "";

                for (int index = 0; index < KeyWords.Length; ++index)
                {
                    if (KeyWords[index] != "")
                    {
                        str += KeyWords[index];
                    }
                }

                Console.WriteLine($"Name: {Name}\nAuthors: {Authors}\nKeyWords: {str}\nTheme: {Theme}\nPathToFile: {PathToFile}");
                Console.WriteLine("Press Enter to continue");
                Console.ReadKey();
            }

        }
        static void Main(string[] args)
        {
            BasicDocument InfoOfFile = new BasicDocument //материнский класс
            {
                Name = "Name",
                Authors = "Authors",
                Theme = "Theme",
                PathToFile = "C\\PathToFile\\Name",
                KeyWords = new string[] { "KeyWord1; ", "KeyWord2; ", "KeyWord3; " },
            };
            Console.WriteLine("This is a Basic InfoOfFile of documents");
            DocumentOutput(InfoOfFile);
            Console.WriteLine("Enter a number of File: ");
            Console.WriteLine("1. MSWord\n2. PDF\n3. MS MSExcel\n4. TXT\n5. HTML");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BasicDocument InfoOfFileWord = new Word //дочерние
                    {
                        FileInfo10 = "FileInfo10",
                        FileInfo11 = "FileInfo11",
                        FileInfo12 = "FileInfo12"
                    };
                    DocumentOutput(InfoOfFileWord);
                    break;
                case "2":
                    BasicDocument InfoOfFilePDF = new PDF
                    {
                        FileInfo6 = "FileInfo6",
                        FileInfo7 = "FileInfo7"
                    };
                    DocumentOutput(InfoOfFilePDF);
                    break;
                case "3":
                    BasicDocument InfoOfFileExcel = new MSExcelDocument
                    {
                        FileInfo1 = "FileInfo1",
                        FileInfo2 = "FileInfo2",
                        FileInfo3 = "FileInfo3",
                    };
                    DocumentOutput(InfoOfFileExcel);
                    break;
                case "4":
                    BasicDocument InfoOfFileTXT = new TXT
                    {
                        FileInfo8 = "FileInfo8",
                        FileInfo9 = "FileInfo9",
                    };
                    DocumentOutput(InfoOfFileTXT);
                    break;
                case "5":
                    BasicDocument InfoOfFileHTML = new HTML
                    {
                        FileInfo4 = "FileInfo4",
                        FileInfo5 = "FileInfo5",
                    };
                    DocumentOutput(InfoOfFileHTML);
                    break;
                default:
                    Console.WriteLine("Document not Found.");
                    break;
            }
        }
    }
}
