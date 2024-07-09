//using System.Text;

//namespace Lesson_11._Stream
//{
//    internal class Program
//    {

//Stream bir axindir.Steam baytlarla oxumaq,yazmaq ve diger funksiyalar ucun istifade olunur.

//MemoryStream=> ramda stream(melumat yazir ve oxuyur) yaradir. stringstream ile istifade olunur.
//FileStream=> file=a melumat yazmaq ve oxumaq ucun istifade olunur.
//NetworkStream=>webden melumat yazmaq ve oxumaq ucundur.
//AdapterStream
//StreamWriter,StreamReader
//BinaryReader,BinaryWriter

//File- static classdir.faylların yaradılması,  silinməsi, və açılması ve emelliyatlar ucun istifade olunan class-dir.

//FileInfo-File haqqinda umumi melumat bilmek ucundur.

//Path-File ve Folderlarin locationdur


//Directory-static classdir. papkalarin yaradılması,  silinməsi, və açılması ve emelliyatlar ucun istifade olunan class-dir.
//DirectoryInfo-Papka haqqinda umumi melumat bilmek  ucundur.

//bu ucunun base class-a stream-dir.



//Biz hec bir yer bildirmedikde default olaraq excel file olan papkada yaranir.(((?????)
//    static void Main(string[] args)
//    {
//        var data = "Hello World";
//        var fs = new FileStream(path: @"C:\Users\User\Desktop\some.txt", mode: FileMode.Create, access: FileAccess.Write);

//        var bytes = Encoding.UTF8.GetBytes(data);//UTF8-Ascii-de olmayan elemtler olduguna gore istifade olunur.
//        try
//        {
//            fs.Write(bytes, 0, bytes.Length);
//            fs.Flush();//Flush methodu file-a yazir.
//            fs.Close(); // Stream baglanir

//        }

//        catch (Exception)
//        {

//        }

//        finally {//finally- exception olsa da, olmasa da isleyir.

//            fs.Dispose(); //stream ramdan silinir(????????)

//            //Dispose yazdiqda close ehtiyac olmur cunki oz icinde cagirilir.
//            //D//Dispose yazdiqda flush da eyni qaydada
//        }


//    }
//}
//}

//36 deq(using bax ve yaz)
//47 misal
//50deq-1.07( json ve basqa bax ve yaz)

//1.07-1.20(file-dan file kocurtme bax ve yaz)




//try catch throw duzgun istifade
//file filestream hansi yazmaq

//calismada file yazma json ile???

//fs.Dispose() sorus;




#region Exercise
//Istifadechi birinci defe run edibse 
//adini, cekisini daxil edecek. 
//// 16.06.2024
//// Dundelik Norma: 4 Lt
//// Bugun: 0.7 lt
//// 1. Su ich => ne qeder su ichdiyini daxil edir
//// 2. Tarixche(History) 
//// 3. Gunu Bitir => Tebrikler siz gundelik meqsede chatmisiz. | Chox az su ichmisiz diqqetli olun
//// 4. Chixish

//// 2. Tarixche(History)  => Taxir: ichdiyi su miqdari
//			    13.06.2024: 0.7lt
//			    14.06.2024: 1.4lt
#endregion



//qeydler json serialize etdikde parametrik kostruktor yazilmir.

//filedan oxuyanda json deserialize olunur.

//Exits olan hisseni sorus(read all text)

//Run olduqda bir defe isleyecek(control panel (initalize olan )




using Lesson_11._Stream.Services;

class Progam()
{
    static void Main(String[] args)
    {
        var panel = new ControlPanel();
        panel.Start();

        

}
}
