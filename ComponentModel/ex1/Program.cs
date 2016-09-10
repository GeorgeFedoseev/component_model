using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CipherLib;

//  1 пример - клиент
namespace ex1 {

    class ex1 {
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
