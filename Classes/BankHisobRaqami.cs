using System;

namespace BankApp.Classes
{
  public class BankHisobRaqami
  {

    Xaridor xaridor = new Xaridor();

    public decimal Balans { get; set; }
    public decimal DepozitMuddati { get; set; }

    public BankHisobRaqami(decimal balance)
    {
      Balans = balance;
    }

    private string[] raqamlar = {"34565678678934562345","90783645273648572635","26374857364518273948"};
    public string[] HisobRaqamlar
    {
      get
      {
        return raqamlar;
      }
      set
      {
        raqamlar = value;
      }
    }

    public void DepozitQoyish()
    {

      Console.WriteLine("Depozit valyutasi Milliy valyuta so'mda. Foiz stavkasi 23%");

      Console.WriteLine("Hisob raqamingiz bormi?\n1. Ha 2. Yo'q");
      string natija = Console.ReadLine();
      switch(natija)
      {
        case "1":
          key2:
          Console.WriteLine("Hisob raqamingizni kiriting:");
          xaridor.MijozHisobRaqami = Convert.ToDecimal(Console.ReadLine());
          if(xaridor.MijozHisobRaqami.ToString().Length==20)
          {
            Console.WriteLine("Rahmat ma'lumotlaringiz saqlandi!");
            Console.WriteLine("12 oydan 36 oygacha depozitlarni qo'yishingiz mumkin! Qancha muddatga qo'ymoqchisiz?");
            DepozitMuddati=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("hisoblashni hohlaysizmi:\n1. Ha 2. Yo'q");
            string hisoblash = Console.ReadLine();
            switch(hisoblash)
            {
              case "1":
                decimal foizi = Balans*23/100;
                decimal oyiga = foizi/12;
                Console.WriteLine($"{DepozitMuddati} oydan keyin balansingiz {Balans+(DepozitMuddati*oyiga)} so'm bo'ladi");
                  break;
              case "2":
                Console.WriteLine("Bizning bankdan foydalanganiz uchun rahmat!");
                  break;
              default:
                Console.WriteLine("Ikki raqamdan birini kiriting!");
                  break;
            }
          }
          else
          {
            Console.WriteLine("Hisob raqam 20 ta raqamdan iborat bo'lishi kerak!"); goto key2;
          }
            break;
        case "2":
          Console.WriteLine("\"Hisob raqam ochish\" bo'limini tanlashingiz kerak!");
            break;
      }

    }


    public void pul_yechib_olish(ref decimal R1balans, ref decimal R2balans, ref decimal R3balans)
    {
      Console.WriteLine("O'zingiz hisob raqamingizni tanlang: ");
      int k=1;
      foreach(string n in HisobRaqamlar)
      {
        Console.WriteLine(k+". "+n);
        k++;
      }
      key:
      string tanlash = Console.ReadLine();
      switch(tanlash)
      {
        case "1":
          Console.WriteLine($"Balansingiz miqdori: {R1balans} so'm qancha yechib olishni xohlaysiz:");
          decimal x = Convert.ToDecimal(Console.ReadLine());
          R1balans-=x;
          Console.WriteLine($"Xisobingizda {R1balans} so'm qoldi.");
            break;
        case "2":
          Console.WriteLine($"Balansingiz miqdori: {R2balans} so'm qancha yechib olishni xohlaysiz:");
          decimal y = Convert.ToDecimal(Console.ReadLine());
          R2balans-=y;
          Console.WriteLine($"Xisobingizda {R2balans} so'm qoldi.");
            break;
        case "3":
          Console.WriteLine($"Balansingiz miqdori: {R3balans} so'm qancha yechib olishni xohlaysiz:");
          decimal z = Convert.ToDecimal(Console.ReadLine());
          R3balans-=z;
          Console.WriteLine($"Xisobingizda {R3balans} so'm qoldi.");
            break;
        default:
          Console.WriteLine("Hisob raqamlardan birini tanlang:"); goto key;
      }

    }



  }
}
