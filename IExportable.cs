using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple
{
    public interface IExportable
    {
        string ExportToString();
        string ExportToCsv();
        string ExportToJSON();
    }
}
