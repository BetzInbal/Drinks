using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Models
{
    internal record Drink(
        string name,
        double Suger,
        double Coffee,
        double Cocoa,
        double Milk,
        double Price
        )
    {
    }
}
