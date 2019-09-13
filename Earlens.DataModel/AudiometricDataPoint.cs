using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Domain
{
    [Serializable]
    public class AudiometricDataPoint
    {
        public double Value { get; set; }
        public AudiometricDataPointType DataPointType { get; set; }
        public bool IsRecalibrationRequired { get; set; }

        public AudiometricDataPoint()
        {
            this.Clear();
        }

        public AudiometricDataPoint(double value, AudiometricDataPointTypes dataPointType)
        {
            this.Value = value;
            this.DataPointType = dataPointType;
        }

        public string DisplayString
        {
            get
            {
                return (this.DataPointType == AudiometricDataPointTypes.Unmeasured) ? string.Empty : this.Value.ToString();
            }
        }

        public bool IsMeasured
        {
            get
            {
                return this.DataPointType != AudiometricDataPointTypes.Unmeasured;
            }
        }

        public virtual void Clear()
        {
            this.Value = 0;
            this.DataPointType = AudiometricDataPointTypes.Unmeasured;
        }

        public void MarkMeasured()
        {
            this.DataPointType = AudiometricDataPointTypes.Unmasked;
        }
    }
}
