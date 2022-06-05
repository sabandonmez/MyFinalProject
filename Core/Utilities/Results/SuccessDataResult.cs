using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        //Bunlar Versiyonlar
        public SuccessDataResult(T data,string message):base(data,true,message)
        { 
            //İster data ve mesaj ver
        }
        public SuccessDataResult(T data):base(data,true)
        {
            //İster sadece data ver
        }

        // Bu alttakiler çok fazla kullanılmaz.
        public SuccessDataResult(string message):base(default,true,message)
        {
            //İster sadece mesaj ver
        }
        public SuccessDataResult():base(default,true)
        {
            //İstersen hiçbirşey verme
        }
    }
}
