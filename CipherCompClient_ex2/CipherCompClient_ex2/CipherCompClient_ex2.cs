using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CipherLib_ex2;
 
// то же самое, что и в 1 примере, только др using

namespace CipherCompClient_ex2 {
    class CipherCompClient_ex2 {
        static void Main(string[] args) {
            var cc = new CipherComp();
            var text = "This is a test.";
            Console.WriteLine(text);
            var cipherText = cc.Encode(text);
            Console.WriteLine(cipherText);
            var decodedText = cc.Decode(cipherText);
            Console.WriteLine(decodedText);
            cc.Dispose(); //  по привычке
            Console.Read();
        }
    }
}
