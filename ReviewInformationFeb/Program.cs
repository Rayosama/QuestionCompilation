using System;

namespace ReviewInformationFeb
{
    class Scopes
    {
        public int GlobalVariable;
        public void newMethod()
        {
            GlobalVariable = 5;
            int localVariable = GlobalVariable;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Scopes s = new Scopes();
            s.GlobalVariable = 10;
            s.newMethod();
            Console.WriteLine(s.GlobalVariable);
        }
    }
}
