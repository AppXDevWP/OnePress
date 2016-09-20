using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePress
{
    public class Extensions
    {
        public static Uri ConvertStringToUri(string url)
        {
            try
            {
                return new Uri(url, UriKind.Absolute);
            }
            catch
            {
                throw new UriFormatException();
            }
        }
    }
}
