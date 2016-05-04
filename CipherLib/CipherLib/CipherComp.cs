using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

// 1 пример простого компонента
namespace CipherLib  {
    public class CipherComp : Component {
        
        public string Encode(string str) {
            var res = "";
            foreach (var c in str.ToCharArray()) { 
                res += (char)(c+1);
            }
            return res;
        }

        public string Decode(string str) {
            var res = "";
            foreach (var c in str.ToCharArray()) {
                res += (char)(c-1);
            }
            return res;
        }

    }
}
