using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CipherLib_ex3;

namespace CipherCompClient_ex3 {
    class CipherCompClient_ex3 {
        static void Main(string[] args) {
            var cc = new CipherComp();
            var text = "Testing";
            Console.WriteLine(text);
            var cipherText = cc.Encode(text);
            Console.WriteLine(cipherText);
            var decodedText = cc.Decode(cipherText);
            Console.WriteLine(decodedText);

            text = "Components are powerful.";
            Console.WriteLine(text);
            cipherText = cc.Encode(text);
            Console.WriteLine(cipherText);
            decodedText = cc.Decode(cipherText);
            Console.WriteLine(decodedText);

            cc.Dispose();

            Console.Read();
        }
    }
}
