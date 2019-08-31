using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dropper.Dom.Models;

namespace DropperRepositorio.Interface
{
    public interface IFlowMeasurementRepositorio
    {
        IEnumerable<FLOW_MEASUREMENT> listAllFlowMeasurement();
    }
}
