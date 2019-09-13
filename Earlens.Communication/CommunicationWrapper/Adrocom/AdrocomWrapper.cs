using Earlens.Communication;
using Earlens.DataModel;
using Earlens.ExceptionHandler;
using Interop.Adrocom3;
using Interop.Adrocom3MDAModule;
using Interop.Adrocom3SignaKlara3Hal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Communication
{
    public class AdrocomWrapper : IAdrocomWrapper
    {
        private bool _isConnected;

        /// <summary>
        /// Hardware Abstraction layer
        /// </summary>
        private SignaKlara3HAL HAL;

        /// <summary>
        /// Hearing Device
        /// </summary>
        private Device HearingAid;

       
       
        public AdrocomWrapper(Ear ear,AdrocomMode mode)
        {
            // Initialize alll adrocom components            
            CreateAdrocomObject(ear,mode);
        }
        
        private void CreateAdrocomObject(Ear ear, AdrocomMode mode)
        {
            HAL = new SignaKlara3HAL();

            HAL.SetEar((int)ear);

            HearingAid = new Device
            {
                Ear = (int)ear,

                HAL = (BaseHAL)HAL
            };

            HAL.CommSession.Programmer =  mode == AdrocomMode.Wired ? HAL.CommSession.ProgrammerList.FindByName("HI-PRO") : HAL.CommSession.ProgrammerList.FindByName("BLECom");            
        }

        public bool Connect()
        {   
            try
            {
                HearingAid.Connect();

                _isConnected = HearingAid.IsConnected();
            }
            catch(ConnectException ex)
            {
                _isConnected = false;
                Console.WriteLine(ex.Message);
                throw ex;
            }
            
            return _isConnected;
        }       

        public bool DisConnect()
        {
            try
            {
                HAL.CommSession.CloseComms();

                _isConnected = HearingAid.IsConnected();
            }
            catch(DisConnectException ex)
            {
                throw ex;
            }
            return _isConnected;
        }

        public bool IsConnected()
        {
            return _isConnected;
        }

        public void ConfigureAdrocom()
        {
            throw new NotImplementedException();
        }

        public List<byte> ReadMDA(int startAddress,int byteCount)
        {
            IMDAModule mDA = HearingAid.DeviceModules.FindByIID(typeof(IMDAModule).GUID) as IMDAModule;

            mDA.AcquireData();

            List<byte> mdData = new List<byte>();
            for (int i = startAddress; i < byteCount; i++)
            {
                mdData.Add(mDA.ByteData.Items[i]);
            }
            return mdData;
        }

        public List<byte> AcquireMDA()
        {
            // Acquire the data to populate the data structure
            IMDAModule mDA = HearingAid.DeviceModules.FindByIID(typeof(IMDAModule).GUID) as IMDAModule;

            mDA.AcquireData();
            List<byte> mdData = new List<byte>();
            for (int i = 0; i < mDA.ByteData.Count; i++)
            {
                mdData.Add(mDA.ByteData.Items[i]);
            }

            return mdData;
        }
    }
}
