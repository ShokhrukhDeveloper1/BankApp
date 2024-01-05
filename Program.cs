using System;
using BankApp.Classes;

internal class Program
{
  private static void Main(string[] args)
  {

    Xaridor xaridor = new Xaridor();
    BankHisobRaqami bankHisobRaqami2 = new BankHisobRaqami(0);
    Bank bank = new Bank();

    decimal r1balans = 50000000;
    decimal r2balans = 70000000;
    decimal r3balans = 25000000;

    Console.WriteLine("Xush kelibsiz!\nQuyidagi xizmat ko'rsatish bo'limlaridan birini tanlang:\n");
    key1:
    Console.WriteLine("\t1. Depozit qo'yish\n\t2. Pul yechib olish"
    +"\n\t3. Hisob raqam ochish\n\t4. Hisobni yopish\n\t5. Pul o'tkazish\n\t6. Hisobni ko'rish\n\t7. Chiqish");


    string tanlash = Console.ReadLine();
    switch(tanlash)
    {
      case "1":
        xaridor.XaridorMalumot();
        Console.WriteLine("Balansingizni kiriting:");
        decimal balance = Convert.ToDecimal(Console.ReadLine());
        BankHisobRaqami bankHisobRaqami = new BankHisobRaqami(balance);
        bankHisobRaqami.DepozitQoyish();
        Console.WriteLine("Yana qanday amal bajarishni xohlaysiz:"); goto key1;
      case "2":
        bankHisobRaqami2.pul_yechib_olish(ref r1balans, ref r2balans, ref r3balans);
        Console.WriteLine("Yana qanday amal bajarishni xohlaysiz:"); goto key1;
      case "3":
        bank.MijozUnHisobOchish();
        Console.WriteLine("Yana qanday amal bajarishni xohlaysiz:"); goto key1;
      case "4":
        bank.MijozHisobiYopish();
        Console.WriteLine("Yana qanday amal bajarishni xohlaysiz:"); goto key1;
      case "5":
        bank.PulOtkazish(ref r1balans, ref r2balans, ref r3balans);
        Console.WriteLine("Yana qanday amal bajarishni xohlaysiz:"); goto key1;
      case "6":
        bank.HisobKorish(ref r1balans, ref r2balans, ref r3balans);
        Console.WriteLine("Yana qanday amal bajarishni xohlaysiz:"); goto key1;
      case "7":
        Console.WriteLine("Tashrifingiz uchun rahmat!");
          break;
    }



  }
}