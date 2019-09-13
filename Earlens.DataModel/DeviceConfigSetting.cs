using Earlens.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Earlens.DataModel
{
    public class DeviceConfigSetting
    {
        public int AlertLevel { get; set; } // Alert levels can be from levels 60 dB SPL to 100 dB SPL with 5 dB steps

        public BatteryAlertType BatteryAlertType { get; set; }   // Battery alert type 0- melody 1- voice

        public int BeepFrequency { get; set; } // Beep Frequency can be  500 Hz , 750 , 1000, 1250, 1500, 1750, 2000

        // Rocker Switch configuration
        // 0 = {Short press up: Volume up, Short press down: Volume down, Long Press up:Next Prog, Long press down:Power off}
        // 1 = {Short press up: Volume up, Short press down: Volume down, Long Press up:Power off, Long press down:Power off}
        // 2 = {Short press up: Next Prog, Short press down: Previous Prog, Long Press up:Power off, Long press down:Power off}
        // 3 = {Short press up: No Action, Short press down: No Action, Long Press up:Power off, Long press down:Power off}
        public ButtonConfiguration ButtonConfig { get; set; }

        public bool IsDefaultVolumeAlertEnabled { get; set; } // Alert default volume with melody

        public bool IsFirstBatteryAlertEnabled { get; set; } // Battery 60 min remaining Alert

        public bool IsMinMaxVolumeAlertEnabled { get; set; } // Alert Volume Min Max with melody

        public bool IsPowerOffAlertEnabled { get; set; } // Power off alert with melody

        public bool IsPowerOnAlertEnabled { get; set; } // Power on alert with melody 

        public bool IsProgramChangeAlertEnabled { get; set; } // Alert Program change with Beep or Voice

        public bool IsSecondBatteryAlertEnabled { get; set; } // Battery 15 min remaining Alert

        public bool IsVolumeChangeAlertEnabled { get; set; } // Alert Volume change with beep

        public ProgramChangeAlert ProgramChangeAlertType { get; set; } // Type of Alert for program change with Beep or Voice

        // Volume Control AdjustmentRange
        public double VolumeAdjustmentRange { get; set; }

        // Volume Step Size
        public double VolumeStepSize { get; set; }

        public DeviceConfigSetting()
        {
            SetDefaults();
        }

        public DeviceConfigSetting(DeviceConfigSetting eldevcfgset)
        {
            VolumeAdjustmentRange = eldevcfgset.VolumeAdjustmentRange;
            VolumeStepSize = eldevcfgset.VolumeStepSize;
            ButtonConfig = eldevcfgset.ButtonConfig;
            AlertLevel = eldevcfgset.AlertLevel;
            BeepFrequency = eldevcfgset.BeepFrequency;
            IsPowerOnAlertEnabled = eldevcfgset.IsPowerOnAlertEnabled;
            IsPowerOffAlertEnabled = eldevcfgset.IsPowerOffAlertEnabled;
            IsFirstBatteryAlertEnabled = eldevcfgset.IsFirstBatteryAlertEnabled;
            IsSecondBatteryAlertEnabled = eldevcfgset.IsSecondBatteryAlertEnabled;
            BatteryAlertType = eldevcfgset.BatteryAlertType;
            IsVolumeChangeAlertEnabled = eldevcfgset.IsVolumeChangeAlertEnabled;
            IsMinMaxVolumeAlertEnabled = eldevcfgset.IsMinMaxVolumeAlertEnabled;
            IsDefaultVolumeAlertEnabled = eldevcfgset.IsDefaultVolumeAlertEnabled;
            IsProgramChangeAlertEnabled = eldevcfgset.IsProgramChangeAlertEnabled;
            ProgramChangeAlertType = eldevcfgset.ProgramChangeAlertType;
        }

        public void SetDefaults()
        {
            AlertLevel = 85;
            BatteryAlertType = BatteryAlertType.Voice;
            BeepFrequency = 1000;
            ButtonConfig = ButtonConfiguration.UseBoth;
            IsDefaultVolumeAlertEnabled = true;
            IsFirstBatteryAlertEnabled = true;
            IsMinMaxVolumeAlertEnabled = true;
            IsPowerOffAlertEnabled = true;
            IsPowerOnAlertEnabled = true;
            IsProgramChangeAlertEnabled = true;
            IsSecondBatteryAlertEnabled = true;
            IsVolumeChangeAlertEnabled = true;
            ProgramChangeAlertType = ProgramChangeAlert.Voice;
            VolumeAdjustmentRange = 12;
            VolumeStepSize = 3;
        }

    }
}
