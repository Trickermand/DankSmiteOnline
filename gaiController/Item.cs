using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gaiController
{
    public class Item
    {
        public string name;
        public string itemColor;
        public bool isMag;
        public bool isPhy;
        public bool isKatana;
        
        public Item(string name, string itemColor, bool isMag, bool isPhy, bool isKatana)
        {
            this.name = name;
            this.itemColor = itemColor;
            this.isMag = isMag;
            this.isPhy = isPhy;
            this.isKatana = isKatana;
        }

    }
    
}

