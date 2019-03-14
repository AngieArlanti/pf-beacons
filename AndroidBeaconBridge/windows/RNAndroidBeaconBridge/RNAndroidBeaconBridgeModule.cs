using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Android.Beacon.Bridge.RNAndroidBeaconBridge
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNAndroidBeaconBridgeModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNAndroidBeaconBridgeModule"/>.
        /// </summary>
        internal RNAndroidBeaconBridgeModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNAndroidBeaconBridge";
            }
        }
    }
}
