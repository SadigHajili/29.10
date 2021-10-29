using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            #region task1 
            //Home ev1 = new Home(8, "Xirdalan");
            //ev1.telefon = "+994123425526";
            //ev1.unvan = "Heyder Aliyev 1";
            //Console.WriteLine(ev1.Myhome());
            #endregion
            MyMath sadiq = new Math();
            sadiq.MYMATH();
            
        }
    }
    public class Home
    {

        public string sheher;
        public byte otaq;
        public byte mertebe;
        public string unvan;
        public string telefon;

        public Home(byte otaq, string sheher)
        {
            this.otaq = otaq;
            this.sheher = sheher;
        }
        public string Myhome()
        {

            return $"Seher: {sheher}\nUnvan: {unvan}\nTelefon: {telefon}";


        }
    } 
    

    class MyMath
    {
        public void MYMATH(int eded, int quvvet)
        {
            for (int i = 0; i < quvvet; i++)
            {
                int x = 5;
                int y = 7;
                Console.WriteLine(Math.Max(x, y));
            }
        }
    }
}






