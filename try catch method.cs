using System;
namespace myconsoleapplication
{
    class souvik
    {
        public delegate void Souvikdeligate(string name);
        public delegate void Multideligate(int x, int y);
        public void Multi(int x, int y)
        {
            Console.WriteLine(x * y);

        }
        public void name(string name)
        {
            Console.WriteLine("my name is" + " " + name);

        }
        static void Main(string[] args)
        {
            souvik d = new souvik();
            Souvikdeligate obj1 = new Souvikdeligate(d.name);
            Multideligate obj2 = new Multideligate(d.Multi);
            obj1("Souvik");
            obj2(10, 20);

        }

    }

}
