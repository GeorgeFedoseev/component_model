using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ex2_lib {

    public class CipherComp : Component {
        bool isDisposed;

        public CipherComp() {
            isDisposed = false;
        }

        ~CipherComp() {
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
            if (!isDisposed) {
                if (dispAll) {
                    isDisposed = false;
                }
                // освобождение управляемых ресурсов
                base.Dispose(dispAll);
            }
        }
    }
}
