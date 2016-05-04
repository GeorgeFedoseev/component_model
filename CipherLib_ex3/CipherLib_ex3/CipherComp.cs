using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.IO;

namespace CipherLib_ex3 {
    public class CipherComp : Component{
        static int userID = 0;
        int id;
        bool isDisposed;

        FileStream log;

        public CipherComp() {
            isDisposed = false;

            try {
                log = new FileStream("CipherLog" + userID + ".txt", FileMode.Create);
                id = userID++;
            }
            catch (FileNotFoundException e) {
                Console.WriteLine(e);
                log = null;
            }
        }


        ~CipherComp() {
            Console.WriteLine("Деструктор для компонента "+ id);
            Dispose(false);
        }

        public string Encode(string str) {
            var res = "";
            foreach (var c in str.ToCharArray()) {
                res += (char)(c + 1);
            }
            return res;
        }

        public string Decode(string str) {
            var res = "";
            foreach (var c in str.ToCharArray()) {
                res += (char)(c - 1);
            }
            return res;
        }

        protected override void Dispose(bool dispAll) {
            Console.WriteLine("Dispose("+dispAll+") для компонента "+id);

            if (!isDisposed) {
                if (dispAll) {
                    Console.WriteLine("Закрытие файла лога для компонента "+id);
                    log.Close();
                    isDisposed = true;
                }

                base.Dispose(dispAll);
            }
        }


    }
}
