using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Host.Interface
{
    public interface IHost 
    {
        bool SaveSession();

        void LoadSession();

        bool isNewAudiogram();

        void InvokeMeasurementModule();

        bool IsReferenceAudiogramAvailable();

        void ReadAudiogramData();

        bool IsPatientModuleConnected();
    }
}
