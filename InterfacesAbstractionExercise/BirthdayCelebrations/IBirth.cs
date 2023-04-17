using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public interface IBirth
    {
        bool ValidateYear(int year);
        DateTime Birthday { get; }
    }
}
