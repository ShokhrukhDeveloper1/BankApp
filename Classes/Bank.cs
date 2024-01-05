using System;
using System.Collections;

namespace BankApp.Classes
{
  public class Bank
  {

    BankHisobRaqami bankHisobRaqami = new BankHisobRaqami(0);
    Xaridor xaridor = new Xaridor();


    public void MijozUnHisobOchish()
    {
      xaridor.XaridorMalumot();
      key1:
      Console.WriteLine("Hisob raqamini kiriting:");
      xaridor.MijozHisobRaqami = Convert.ToDecimal(Console.ReadLine());
      if(xaridor.MijozHisobRaqami.ToString().Length==20)
      {
        Console.WriteLine("Hisob raqamingiz yaratildi!");
      }
      else
      {
        Console.WriteLine("Mijoz hisobi 20 ta raqamdan iborat bo'lishi kerak!");goto key1;
      }
    }

    public void MijozHisobiYopish()
    {
      Console.WriteLine("Ushbu bo'lim logikasi hali o'ylanmoqda 🤷‍♂️😁");
    }

    public void PulOtkazish(ref decimal R1balans, ref decimal R2balans, ref decimal R3balans)
    {
      Console.WriteLine("Qaysi hisob raqamiga o'tkazmoqchisiz tartib raqamini tanlang: ");
      int k=1;
      foreach(string n in bankHisobRaqami.HisobRaqamlar)
      {
        Console.WriteLine(k+". "+n);
        k++;
      }
      string tanlash = Console.ReadLine();
      switch(tanlash)
      {
        case "1":
          Console.WriteLine("Qancha miqdorni o'tkazmoqchisiz:");
          decimal x=Convert.ToDecimal(Console.ReadLine());
          R1balans+=x;
          Console.WriteLine("Muvaffaqqiyatli jo'natildi.");
            break;
        case "2":
          Console.WriteLine("Qancha miqdorni o'tkazmoqchisiz:");
          decimal y=Convert.ToDecimal(Console.ReadLine());
          R2balans+=y;
          Console.WriteLine("Muvaffaqqiyatli jo'natildi.");
            break;
        case "3":
          Console.WriteLine("Qancha miqdorni o'tkazmoqchisiz:");
          decimal z=Convert.ToDecimal(Console.ReadLine());
          R3balans+=z;
          Console.WriteLine("Muvaffaqqiyatli jo'natildi.");
            break;
        default:
          Console.WriteLine("Hisob raqamlardan birini tanlang:");
            break;
      }
    }

    public void HisobKorish(ref decimal R1balans, ref decimal R2balans, ref decimal R3balans)
    {
      Console.WriteLine("Hisob raqamini tanlang:");
      int k=1;
      foreach(string n in bankHisobRaqami.HisobRaqamlar)
      {
        Console.WriteLine(k+". "+n);
        k++;
      }
      string tanlash = Console.ReadLine();
      switch(tanlash)
      {
        case "1":
          Console.WriteLine($"Hisobingizda: {R1balans} so'm bor ");
            break;
        case "2":
          Console.WriteLine($"Hisobingizda: {R2balans} so'm bor ");
            break;
        case "3":
          Console.WriteLine($"Hisobingizda: {R3balans} so'm bor ");
            break;
        default:
          Console.WriteLine("Hisob raqamlardan birini tanlang:");
            break;
      }
    }

  }
}