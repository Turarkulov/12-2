namespace _12_2
{
    public static class EmployeeCollection
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string SureName { get; set; }
        public static string JobTitle { get; set; }
        public static int Year { get; set; }
        public static void Filter()

        {
            try
            {
                string path = @"C:\Users\user\source\repos\12-2\12-2\input.txt";
                using (StreamReader reader = new StreamReader(path))
                {
                    string? line = reader.ReadLine();
                    string[] words = line.Split(new char[] { ' ' });
                    string poisk = Console.ReadLine();
                    string path1 = @"C:\Users\user\source\\repos\12-2\12-2\oux.txt";

                    while (line != null)
                    {
                        words = line.Split(new char[] { ' ' });
                        if (poisk.Contains(words[3]))
                        {

                            Id = int.Parse(words[0]);
                            Name = words[1];
                            SureName = words[2];
                            JobTitle = words[3];
                            Year = int.Parse(words[4]);
                            Console.WriteLine("{0,-6} | {1, -1} {2, -10} | {3, -9} | {4, -1}", Id, Name, SureName, JobTitle, Year);

                            using StreamWriter writer = new StreamWriter(path1, true);
                            writer.WriteLine("{0,-6} | {1, -1} {2, -10} | {3, -9} | {4, -1}", Id, Name, SureName, JobTitle, Year);

                        }

                        line = reader.ReadLine();
                        
                    }
                    
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Такой должности нет");
            }

        }


    }

}


