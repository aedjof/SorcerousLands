using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SorcerousLands
{
    internal class кнопка_без_синего: Button
    {
        public кнопка_без_синего() {
            this.SetStyle(ControlStyles.Selectable, false);
        }
    }
}
