using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public enum Permission
    {
        NONE = 0x0,
        NETTOYAGE = 0x1,
        CUISINE = 0x2,
        RESERVATION = 0x4,
        MANAGER = 0x8,
        ALL = 0xf
    }
}
