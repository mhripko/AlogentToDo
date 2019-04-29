using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlogentToDo
{
    internal class SystemInformationService : ISystemInformationService
    {
        public bool IsHighContrastColourScheme { get { return SystemInformation.HighContrast; } }
    }

    internal interface ISystemInformationService
    {
        bool IsHighContrastColourScheme { get; }
    }
}
