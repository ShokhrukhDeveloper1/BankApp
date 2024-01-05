using System;

namespace BankApp.Classes
{
  public class Xaridor
  {

    public string Ism { get; set; }
    private decimal mijozHisobRaqami;
    public decimal MijozHisobRaqami
    {
      get
      {
        return mijozHisobRaqami;
      }
      set
      {
        mijozHisobRaqami=value;
      }
    }
    public string seriya { get; set; }

    public void XaridorMalumot()
    {
      Console.WriteLine("F.I.SH ni kiriting:");
      Ism = Console.ReadLine();
      Console.WriteLine("Pasport seriya va raqamini kiriting:");
      seriya = Console.ReadLine();
    }



  }
}