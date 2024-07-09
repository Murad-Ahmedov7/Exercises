//namespace Lesson_5._OOP
//{
#region Simple property misal(Lesson4 ders ucun)
//    internal class Person
//    {
//        // Private field to store the name
//        private string name1;

//        // Constructor to initialize the Name property
//        public Person(string name)
//        {
//            Name = name;
//        }

//        // Simple property
//        public string Name
//        {
//            get { return name1; }
//            set
//            {
//                if (value == "John")
//                {
//                    name1 = value;
//                }
//                else
//                {
//                    Console.WriteLine("False");
//                }
//            }
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Creating a new Person object with the name "John"
//            Person person = new Person("Johna");

//            // Accessing and printing the Name property
//            Console.WriteLine(person.Name); // Output: John
//        }
//    }
#endregion



////Single-// bildiyimiz inheritance
// 
//Multilevel-bir class diger class-a miras verir, o da diger class-a miras verir.

//Hierarchy- bir class-in bir nece class-a miras vermesi

//Multilevel niye yoxdu??????????????????????(tap ve yaz ve oyren recording)
//internal class Program
//{
//    static void Main(string[] args)
//    {

//    }
//}


//iki cur typescast operatoru var:
//is=>bool
//as=>Type?  ceviri bilse hemin tipde reference qaytarir,eger bilmese nullable type qaytarir.



// oop terifin yaz
//Encapsulation->Obyekt daxilinde olan field(deyisen) ve methodlarin(funksiyalarin) qorunmasidir.(field ve method class daxilinde kecerlidir)
//Polymorphism->bir funksiyanin ozunu muxtelif cur aparmasidir.
//Abstraction->classlari umumilesdirmek,mucerred anlayis yaratmaqdir.
//Inheritance->miras veren obyektin miras alan obyekte oz field ve methodlarini oturmesidir.

//Icerinde en az bir virtual methodu olan class polymorphism class-dir.
//Abstraction -absctarct  class-in obyektin yaratmaq olmur,ve icerisinde istilen field ve methodlari istifade etmek olar






//}




//ilk 15 deq tekrar
//15-20 arasi bax papkaya yazmaq proyekti
// auto propery olmadan yazmaq olmur??
///39 deq property field ferq
/////kohne dersden internal temasina bax
///
///42-46 arasi bax lazim olsa yaz.
///






//Esas suallar::
//top level statement??
//bir muellimin atdigi kitablar bax
//gitden istifade etmek
//39 deq property field ferq
//1ci movzuya bax
//heap ve stack tam basa dus(reference ve value type)
//galeride olan sekli sorus
//internal,static falan onlari oyren
//file ve papka yaratmagi oyren
//internal tam nedi bax
//magistr temasin sorus
//fileri duzelt visual studio ve papklalar
//access modifierler novun hamisini yaz

//class default olaraq nedi ve hemcinin icerdekiler
//51-1.13 arasi bir de bax(initalize list-e de bax)
//ve bu ikisi elaqelidi.

//heapde obyekt yaranda olan terifi sorus ve( Person temasi var idi 1.20 ve ya 1.52 de onu da sorus Muraddan)
//class-konstructorsuz muraciet olar???
//1.53?? yaz
//2.00?? 2.02?? yaz 

//2.08?-2-31??? yaz

// 5 movzu axirinda misala bax (ozun yazdigina da bax)


//main funksiyasi daxilinde args nedir????
//namespace diger faylda istifade ucun lazimdi??(bax sonraki derse?? ve ya evvel)
//static main de qeyd et niye yaziriq static



//------------------------------------------Exercise--------------------------------------

//HOMEWORK
//Cat :nickname, age, gender, Energy, Price, mealQuantity 
//Eat(); Sleep(); Play();
//CatHouse: Cats[], CatCount, AddCat, RemoveByNickname
//Petshop: CatHouses[], CatHouseCount
////Bizde Petshop var ve orda yalniz pishik evleri var ve her evde choxlu pishik var
////Sadece bize onlarin petshop oldugu zaman butun pishikleri idare etmek uchun sistem var , hansiki pishiklerin enerjileri var
//oynadiqca enerji itirirler, yatdiqda ve ya yemek yedikde enerjileri artir, amma pishikler elediki
//enerjileri 0 olan kimi yatmaga getmelidirler //ve pishikler yemek yedikce her defe chox az boyuyub deyerlerinirler ,(yeni price lari qalxir) Ve siz sistemde umumi ne qeder yemekle yedizdirildiklerini , umumi pishiklerin qiymetini hesablayin
//OZUNUZDEN ELAVELER EDIN MUTLEQ




using Lesson_5._OOP;

namespace Lesson_5._OOP
{
    public class Cat
    {
        public string nickname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public int Energy { get; set; }
        public int Price { get; set; }
        public int mealQuantity { get; set; }


        public Cat()
        {

        }

        public Cat(string nickname, int age, string gender, int Energy, int Price, int mealQuantity)
        {
            this.nickname = nickname;
            this.age = age;
            this.gender = gender;
            this.Energy = Energy;
            this.Price = Price;
            this.mealQuantity = mealQuantity;
        }

        public void Showinfo()
        {
            Console.WriteLine($"nickname:{nickname}   age:{age}   gender:{gender}    Energy:{Energy}   Price: {Price}  mealQuantity: {mealQuantity} ");
        }
    



        public void Eat()
        {

            int EatCount = 0;


            
            if (Energy >= 100)
            {
                Console.WriteLine("Enerji 100 den cox ola bilmez");
                Energy = 100;
                Thread.Sleep(1150);
            }
            else if (Energy == 0)
            {
                Console.WriteLine("Pisik yatmalidir");
                Thread.Sleep(1200);
                Console.Clear();
                Sleep();
            }
            else
            {
                Console.WriteLine("Pisiyin yemek yedi");
                EatCount++;
                Price += 10;
                Energy += 10;
                Thread.Sleep(1150);

            }
            Thread.Sleep(600);
            Console.Clear();




        }
      

        public void Play()
        {
           

            if (Energy == 0)
            {
                Console.WriteLine("Pisik yatmalidir");
             
                Console.Clear();
                Sleep();
            }
            else
            {
                Energy -= 10;
                Console.WriteLine("Pisik oyun oynadi");
    

            }
            Thread.Sleep(1150);
            Console.Clear();



        }

        public void Sleep()
        {
            
          

            if (Energy >= 100)
            {
                Console.WriteLine("Enerji 100 den cox ola bilmez");
                Energy = 100;
                Thread.Sleep(1150);

            }

            else
            {
                Console.WriteLine("Pisik yatdi");
                Energy += 10;
                Thread.Sleep(1150);

            }

           
            Console.Clear();


        }





    }

    public class CatHouse
    {
        public List<Cat> Cats { get; set; }
        public int CatCount;

        public CatHouse()
        {

        }
        public CatHouse(List<Cat> allCats, int catCount)
        {
            Cats = allCats;
            CatCount = catCount;

        }
       



    }

    public class Petshop
    {
        public List<CatHouse> Cathouses { get; set; }
        public int CathouseCount;

        public Petshop(List<CatHouse> allcathouses, int cathouseCount)
        {
            Cathouses = allcathouses;
            CathouseCount = cathouseCount;
        }

        public void Showcathouses()
        {

            Console.WriteLine(Cathouses);

        }

        public void ShowTotalPriceOfCats()
        {
            int totalPrice = 0;
            for (int i = 0; i < Cathouses.Count; i++)
            {
                for (int j = 0; j < Cathouses[i].Cats.Count; j++)
                {
                    totalPrice += Cathouses[i].Cats[j].Price;
                }
            }
            Console.WriteLine($"Total price of all cats: {totalPrice}");
        }

    




    }
}




internal class Program
{
    static void Main(string[] args)
    {
        List<Cat> allCats = new List<Cat>();
        List<Cat> allCats2 = new List<Cat>();

        Cat c1 = new Cat("cat1", 3, "male", 50, 4, 5);
        Cat c2 = new Cat("cat2", 7, "female", 100, 14, 31);
        Cat c3 = new Cat("cat3", 1, "male", 100, 4, 1);
        Cat c4 = new Cat("cat4", 5, "male", 100, 7, 22);
        Cat c5 = new Cat("cat5", 5, "female", 100, 7, 312);


        allCats.Add(c1);
        allCats.Add(c2);

        allCats2.Add(c3);
        allCats2.Add(c4);
        allCats2.Add(c5);


        List<CatHouse> allcathouses = new List<CatHouse>();

        CatHouse catHouse1 = new CatHouse(allCats, allCats.Count);

        CatHouse catHouse2 = new CatHouse(allCats2, allCats2.Count);

        allcathouses.Add(catHouse1);
        allcathouses.Add(catHouse2);


        Petshop petshop1 = new Petshop(allcathouses, allcathouses.Count);



        while (true)
        {


            Console.WriteLine("Seciminizi edin:");
            Console.WriteLine("1.Eat");
            Console.WriteLine("2.Play");
            Console.WriteLine("3.Sleep");
            Console.WriteLine("4.System");
            int choice = Convert.ToInt32(Console.ReadLine());



            void ShowAllCats()
            {
                for (int i = 0; i < petshop1.CathouseCount; i++)
                {
                    for (int j = 0; j < petshop1.Cathouses[i].Cats.Count; j++)
                    {

                        petshop1.Cathouses[i].Cats[j].Showinfo();

                    }

                }
            }



            Console.Clear();
            if (choice == 1)
            {
                ShowAllCats();


                Console.WriteLine("Pisiyi secin:");

                int choice2 = Convert.ToInt32(Console.ReadLine());

                if (choice2 == 1)
                {

                    petshop1.Cathouses[0].Cats[choice2 - 1].Eat();

                }
                else if (choice2 == 2)
                {
                    petshop1.Cathouses[0].Cats[choice2 - 1].Eat();


                }

                else if (choice2 == 3)
                {
                    petshop1.Cathouses[1].Cats[choice2 - 3].Eat();


                }

                else if (choice2 == 3)
                {
                    petshop1.Cathouses[1].Cats[choice2 - 3].Eat();


                }

                else if (choice2 == 4)
                {
                    petshop1.Cathouses[1].Cats[choice2 - 3].Eat();


                }

                else if (choice2 == 5)
                {
                    petshop1.Cathouses[1].Cats[choice2 - 3].Eat();


                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Yeniden daxil edin");
                }



            }

            else if (choice == 2)
            {
                ShowAllCats();


                Console.WriteLine("Pisiyi secin:");

                int choice2 = Convert.ToInt32(Console.ReadLine());

                if (choice2 == 1)
                {

                    petshop1.Cathouses[0].Cats[choice2 - 1].Play();





                }
                else if (choice2 == 2)
                {
                    petshop1.Cathouses[0].Cats[choice2 - 1].Play();



                }

                else if (choice2 == 3)
                {
                    petshop1.Cathouses[1].Cats[choice2 - 3].Play();



                }

                else if (choice2 == 3)
                {
                    petshop1.Cathouses[1].Cats[choice2 - 3].Play();



                }

                else if (choice2 == 4)
                {
                    petshop1.Cathouses[1].Cats[choice2 - 3].Play();



                }

                else if (choice2 == 5)
                {
                    petshop1.Cathouses[1].Cats[choice2 - 3].Play();



                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Yeniden daxil edin");
                }
            }

            else if (choice == 3)
            {
                ShowAllCats();


                Console.WriteLine("Pisiyi secin:");

                int choice2 = Convert.ToInt32(Console.ReadLine());

                if (choice2 == 1)
                {

                    petshop1.Cathouses[0].Cats[choice2 - 1].Sleep();





                }
                else if (choice2 == 2)
                {
                    petshop1.Cathouses[0].Cats[choice2 - 1].Sleep();




                }

                else if (choice2 == 3)
                {
                    petshop1.Cathouses[0].Cats[choice2 - 1].Sleep();




                }

                else if (choice2 == 3)
                {
                    petshop1.Cathouses[0].Cats[choice2 - 1].Sleep();




                }

                else if (choice2 == 4)
                {
                    petshop1.Cathouses[0].Cats[choice2 - 1].Sleep();




                }

                else if (choice2 == 5)
                {
                    petshop1.Cathouses[0].Cats[choice2 - 1].Sleep();




                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Yeniden daxil edin");
                }
            }

            else if (choice == 4)
            {
                petshop1.ShowTotalPriceOfCats();
                Thread.Sleep(1250);
                Console.Clear();

            }

        }










    }


}




