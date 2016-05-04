using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CipherLib;

namespace CipherLibComponentTest {
    class Program {
        static void Main(string[] args) {
            var c = new CipherComp();

            var source_str = "Test string";
            print(source_str);
            var encoded_str = c.Encode(source_str);
            print(encoded_str);
            var decoded_str = c.Decode(encoded_str);
            print(decoded_str);

            Console.WriteLine("Test: " + (decoded_str == source_str ? "OK" : "FAILED"));

            Console.ReadKey();
        }

        static void print(string str) {
            Console.WriteLine(str);
        }
    }
}
