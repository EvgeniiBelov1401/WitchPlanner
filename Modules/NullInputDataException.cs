using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitchPlanner.Modules
{
    public class NullInputDataException: Exception
    {
        public override string? Message { get; } = "Заполните все данные...";
    }
}
