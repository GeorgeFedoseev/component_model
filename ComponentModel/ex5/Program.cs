using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ex4_lib;

namespace ex5 {
    class ex5 {
        static void Main(string[] args) {
            using (var cc = new CipherComp()) {                
                var text = "The using statement";                
                var cipherText = cc.Encode(text);
                Console.WriteLine(cipherText);
                var decodedText = cc.Decode(cipherText);
                Console.WriteLine(decodedText);                
            }

            Console.Read();
        }
    }
}
