using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.Controller
{
    public interface IHostController
    {
        /// <summary>
        /// Connect to Audiogram Host
        /// </summary>
        /// <returns></returns>
        bool ConnectHost();

        /// <summary>
        /// Is Host Connected
        /// </summary>
        /// <returns></returns>
        bool IsConnected();

        /// <summary>
        /// Load Audiogram from connected host
        /// </summary>
        /// <returns></returns>
        bool LoadAudiogram();

        /// <summary>
        /// Save the Fitting Date to the connected host
        /// </summary>
        /// <returns></returns>
        bool SaveFitting();

        /// <summary>
        /// Load Latest session from the connected host
        /// </summary>
        /// <returns></returns>
        bool LoadFitting();

        /// <summary>
        /// Load Selected session from the connected host
        /// </summary>
        /// <returns></returns>
        bool LoadSelectedFitting();

        /// <summary>
        /// Launch the audiogram module with connected patient audiogram data
        /// </summary>
        /// <returns></returns>
        bool InvokeAudiogramModule();

        /// <summary>
        /// Get Create time of audiogram with reference id
        /// </summary>
        /// <param name="referenceId"></param>
        /// <returns></returns>
        bool GetAudiogramCreateTime(int referenceId);

        /// <summary>
        /// Get Modified time of audiogram with reference id
        /// </summary>
        /// <param name="referenceId"></param>
        /// <returns></returns>
        bool GetAudiogramModifiedTime(int referenceId);
    }
}
