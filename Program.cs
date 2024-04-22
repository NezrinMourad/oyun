



#region


using System.Collections;
using System.ComponentModel.Design;

{
    //string ad = ($"Nail");
    //string soyad = ($"Ibrahimova");
    //string ekran = ("Salam Xos geldiniz !");
    //Console.WriteLine(ad);
    //Console.WriteLine(soyad);
    //Console.WriteLine(ekran);
}

#endregion



#region Task 3

//Console.WriteLine("Yasinizi qeyd edin");
//int yas = Convert.ToInt32(Console.ReadLine());


////if (yas < 18)
//{
//    Console.WriteLine("yeniyetme");
//}else if(yas>= 18 || yas <=35)
//{
//  Console.WriteLine("Genx");

//} else if (yas<=35|| yas<=55)
//{
//    Console.WriteLine("Ortayasli");
//} else if(yas>=55)
//{
//    Console.WriteLine("Yasli");
//}




#endregion



#region task1

//Console.WriteLine("1den 20ye qeder reqemleri qeyd et 13 17 19 istisna:");

//for (int i = 0; i <= 20; i++)
//{
//    if (i == 13 || i == 17 || i == 19)
//    {
//        continue;
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//}


#endregion


#region task3

//    Console.WriteLine("Tempuraturu daxil edin");
//    int temp = Convert.ToInt32(Console.ReadLine());
//if (temp < 10)
//{
//    Console.WriteLine("Soyuqdur");
//}
//else if (temp >= 10 && temp <= 20)
//{
//    Console.WriteLine("Orta tempurator");
//}
//else if (temp >= 20&& temp<=60)
//    Console.WriteLine("Istidir");

#region
//oyub
//evvelceden bir soz teyin edin
//ve istifadeci sozu tapmaga calissin
//istifadecinin 5 haqqi olsun tapsa"Tebrikler dogru soz"
//eger duzgun tapmasa "Meglub oldunuz soz bu idi"
#endregion

#region
string duzCavab = "Lupa";
int sayi = 1;
do
{
    string ist = Console.ReadLine();
    if (ist == duzCavab)
    {
        Console.WriteLine("Tebrikler dogru cavab");
        break;
    }
    else if (sayi == 5)
    {
        Console.WriteLine("Meglub oldunuz");
    }
    else
    {
        sayi++;
    }Console.WriteLine("Yeniden cehd edin");

} while (sayi <= 5);
#endregion
#endregion