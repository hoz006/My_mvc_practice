using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Service.Utils
{
    public static class CommonHelper
    {
        public static string GenGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
