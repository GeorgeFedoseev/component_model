using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ex4_lib;


namespace ex6 {
    class UseContainer {
        static void Main(string[] args) {
            string str = "Using containers";
            Container cont = new Container();
            var cc = new CipherComp();
            var cc2 = new CipherComp();
            cont.Add(cc);
            cont.Add(cc2, "Second Component");
            Console.WriteLine(str);
            str = cc.Encode(str);
            Console.WriteLine(str);
            str = cc.Decode(str);
            Console.WriteLine(str);
            str = "One, two, three";
            Console.WriteLine(str);
            str = cc2.Encode(str);
            Console.WriteLine(str);
            str = cc2.Decode(str);
            Console.WriteLine(str);
            Console.WriteLine(cc2.Site.Name);
            cont.Dispose();

            Console.Read();
        }
    }
}
