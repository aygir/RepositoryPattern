using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Ornek
{
   public class TESTDB
    {
        public static Irepository<tablo1> _tablo1 = new tablo1Repository();
        public static Irepository<tablo2> _tablo2 = new tablo2Repository();
        
        public IEnumerable<String> onlyVAR1()
        {
            var var1Listesi = _tablo1.List.Select(x => x.var1);
            return var1Listesi;
        }
       
        
    }
}
