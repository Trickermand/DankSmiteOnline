using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gaiController
{

    public enum GodType
    {
        Mage,
        Guardian,
        Hunter,
        Assassin,
        Warrior
    }


    public class God
    {
        public string name;
        public GodType godType;
        public string fileName;

        public God(string _name, GodType _godType, string fileName)
        {
            this.name = _name;
            this.godType = _godType;
        }

        public God(string _name, string _godType, string _fileName)
        {
            this.name = _name;
            this.godType = GodTypeFromString(_godType);
            this.fileName = _fileName;
        }

        private GodType GodTypeFromString(string godTypeAsString)
        {
            if (godTypeAsString.Equals("mage", StringComparison.CurrentCultureIgnoreCase))
                return GodType.Mage;
            else if (godTypeAsString.Equals("guardian", StringComparison.CurrentCultureIgnoreCase))
                return GodType.Guardian;
            else if (godTypeAsString.Equals("hunter", StringComparison.CurrentCultureIgnoreCase))
                return GodType.Hunter;
            else if (godTypeAsString.Equals("assassin", StringComparison.CurrentCultureIgnoreCase))
                return GodType.Assassin;
            else
                return GodType.Warrior;
        }

    }
}
