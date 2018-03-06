using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEnumModel
{
    public class NamedEnumDto
    {
        public Enum EnumValue { get; set; }

        public int Id
        {
            get
            {
                return Convert.ToInt32(EnumValue);
            }
        }

        public string Name
        {
            get
            {
                return EnumValue.ToString();
            }
        }
    }
}
