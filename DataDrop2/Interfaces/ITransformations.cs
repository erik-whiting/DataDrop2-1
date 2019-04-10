using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataDrop2.Models;

namespace DataDrop2.Interfaces
{
    public interface ITransformations
    {
        object ToDataFormat(List<DataPoint> dataPoints);
    }
}
