using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba05041
{
    public interface Interface1
    {
        void Excute(object par);
        bool CanExcute(object par);
        event EventHandler CanExcuteChanged;
    }
}
