using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace SorcerousLands
{
    internal class игра
    {
        public string название { get; set; }
        JObject игры;
        public игра(string название) {
            this.название = название;
            игры = new JObject("./games.json");
        }
    }
}
