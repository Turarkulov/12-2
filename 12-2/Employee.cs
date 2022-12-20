namespace _12_2
{
    public static class Employee
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
        public static string SureName { get; set; }
        public static string JobTitle { get; set; }
        public static int Year { get; set; }
       
        public static void GetText()

        {
            try
            {

                string path = @"C:\Users\user\source\repos\12-2\12-2\input.txt";
                using (StreamReader reader = new StreamReader(path))
                {
                    Console.WriteLine("Список сотрудников:");
                    Console.WriteLine();
                    Console.WriteLine(" Номер |         ФИО       | Должность | Год");
                    Console.WriteLine(new string('-', 50));

                    string? line = reader.ReadLine();
                    string [] words = line.Split(new char[] { ' ' });

                    while (line != null)
                    {
                        words = line.Split(new char[] { ' ' });

                        Id = int.Parse(words[0]);
                        Name = words[1];
                        SureName = words[2];
                        JobTitle = words[3];
                        Year = int.Parse(words[4]);

                        Console.WriteLine("{0,-6} | {1, -1} {2, -10} | {3, -9} | {4, -1}", Id, Name, SureName, JobTitle, Year);

                        line = reader.ReadLine();

                    }

                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден");
            }

        }

    }
}
