using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Core.Enum
{
    public enum ToDoListType
    {
        [Description("A级")]
        LevelA = 0,

        [Description("B级")]
        LevelB = 1,

        [Description("C级")]
        LevelC = 2,
    }
}
