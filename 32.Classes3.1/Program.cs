using System;

namespace LineApplication
{
    class Sentences
    {
        private string sen1;
      

        public Sentences()
        {
            Console.WriteLine("this is fisrt sentence we  are in constructor");
        }
        public void setSen1(string one)
        {
            sen1 = one;
            Console.WriteLine(sen1);
        }
       

        static void Main(string[] args)
        {
            Sentences sentences = new Sentences();
            string mySentences = " now -> we called function";

            sentences.setSen1(mySentences);
            
            Console.WriteLine("and now -> we came back !!!");
            Console.ReadKey();
        }
    }
}