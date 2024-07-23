using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Configuration
{
    internal static class AppConfiguration
    {
        public static string DrinksPath => Path.Combine(
            Directory.GetCurrentDirectory(),
            "Drinks.Xml"
            );
    }
}
