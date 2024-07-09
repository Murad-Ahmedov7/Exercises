
using Lesson_11._Stream.Models;
using System.Text.Json;


namespace Lesson_11._Stream.Services
{
    internal class ControlPanel
    {
        public User User1 { get; set; } // User User1 =new User() ile ona gore yazmiriq ki biz sonradan o prosesi yazacaqyiq

        public ControlPanel()
        {

            Initalize();
        }

        private void Initalize()
        {
            if (File.Exists("user.json"))
            {
                string json = File.ReadAllText("user.json");
                User1 = JsonSerializer.Deserialize<User>(json);
            }
            if (User1 is null)
            {
                Console.WriteLine("Name: ");
                var name = Console.ReadLine();
                Console.WriteLine("Weight:");
                double.TryParse(Console.ReadLine(), out double weight);
                User1 = new User()
                {
                    CurrentDate = DateTime.Now,
                    Name = name,
                    Weight=weight,
                    CurrentLitr = 0,
                    History = new List<HistoryItem>()
                };

            }
        }
        public void SaveChanges()
        {
            var json = JsonSerializer.Serialize(User1);
            File.WriteAllText("user.json", json);
        }

        public void EndDate()
        {
            if (User1 is null)
            {
                throw new Exception("User is not found");
            }
            else
            {
                var item = new HistoryItem(User1.CurrentDate.ToString("dd.MM.yyyy"), User1.CurrentLitr);
                User1.History.Add(item);

                User1.CurrentDate = User1.CurrentDate.AddDays(1);
                User1.CurrentLitr = 0;
            }
        }

        public void DrinkWater()
        {
            if (User1 is null)
            {
                throw new Exception("User is not found");
            }
            Console.Clear();
            Console.WriteLine("Icilecek suyun miqdarini daxil edin: ");
            double.TryParse(Console.ReadLine(), out double litr);
            User1.CurrentLitr += litr;
        }

        public void ShowHistory()
        {
            if (User1 is null)
            {
                throw new Exception("User is not found");
                Console.Clear();
            }
            Console.WriteLine("Date      |Litr");

            foreach (var item in User1.History)
            {
                Console.WriteLine($"{item.Date} | {item.Litr}");
            }

        }

        public void ChoiceMenu()
        {
            Console.WriteLine("0.Cixis et");
            Console.WriteLine("1.Su Ic");
            Console.WriteLine("2.Yaddasi Goster");
            Console.WriteLine("3.Gunu bitir");
            
        }

        public void Start()
        {
            //for (int i = 0; i < 2; i++)
            //{
            //    DrinkWater();
            //    DrinkWater();
            //    DrinkWater();
            //    EndDate();
            //}
            //ShowHistory();
            //SaveChanges();
            while (true)
            {
                Console.Clear();

                ChoiceMenu();

                Console.WriteLine("Seciminizi edin ");
                string a = Console.ReadLine();



                int choice = Convert.ToInt32(a);



                if (choice == 1)
                {

                    DrinkWater();
                    Thread.Sleep(2000);


                }


                else if (choice == 2)
                {

                    ShowHistory();
                    Thread.Sleep(2000);


                }



                else if (choice == 3)
                {

                    EndDate();
                    SaveChanges();
                    Thread.Sleep(2000);



                }


                else
                {
                    throw new Exception("Seciminiz yanlisdir");
                }
            }







        }



    }

}
