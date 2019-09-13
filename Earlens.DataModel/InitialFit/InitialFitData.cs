using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.DataModel
{
    public abstract class InitialFitData
    {
        public DateTime CreateTime { get; set; }

        public DateTime ModifiedTime { get; set; }

        public double SiteIdMeasured { get; set; }

        public bool IsNewData { get; set; }

        public List<AudiometricDataPoint> DataPoint { get; set; }

        public InitialFitData()
        {

        }

        public void Clear()
        {

        }

        public void SetNewDateFlag(bool flag)
        {
            IsNewData = flag;
        }
        public bool GetNewDataFlag()
        {
            return IsNewData;
        }

        public abstract bool IsComplete();

        public abstract bool Compare();

        public abstract bool CompareAll();
    }
}
