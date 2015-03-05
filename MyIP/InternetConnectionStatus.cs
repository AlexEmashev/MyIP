using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MyIP
{
    /// <summary>
    /// Class returns Internet connection status.
    /// Call of property value returns actual state of connection.
    /// </summary>
    class InternetConnectionStatus
    {
        /// <summary>
        /// Enumeration for Win32 API method.
        /// </summary>
        [Flags]
        private enum InternetConnectionState : int
        {
            INTERNET_CONNECTION_MODEM = 0x1,
            INTERNET_CONNECTION_LAN = 0x2,
            INTERNET_CONNECTION_PROXY = 0x4,
            INTERNET_RAS_INSTALLED = 0x10,
            INTERNET_CONNECTION_OFFLINE = 0x20,
            INTERNET_CONNECTION_CONFIGURED = 0x40
        }

        #region Connection Properties.
        /// <summary>
        /// Returns status of internet connection. True if connected.
        /// </summary>
        public static bool IsInternetConnected
        {
            get { return Init(InternetConnectionState.INTERNET_CONNECTION_OFFLINE); }
        }
        /// <summary>
        /// Returns true if computer is connected over modem.
        /// </summary>
        public static bool IsUsingModem
        {
            get { return Init(InternetConnectionState.INTERNET_CONNECTION_MODEM); }
        }
        /// <summary>
        /// Returns true if computer is connected over LAN.
        /// </summary>
        public static bool IsUsingLAN
        {
            get { return Init(InternetConnectionState.INTERNET_CONNECTION_LAN); }
        }
        /// <summary>
        /// Returns true if internet connection uses proxy.
        /// </summary>
        public static bool IsUsingProxy
        {
            get { return Init(InternetConnectionState.INTERNET_CONNECTION_PROXY); }
        }
        /// <summary>
        /// Returns true if RAS is enabled.
        /// </summary>
        public static bool IsRasEnabled
        {
            get { return Init(InternetConnectionState.INTERNET_RAS_INSTALLED); }
        }
        #endregion

        /// <summary>
        /// Win32 API function wich returns internet connection status.
        /// </summary>
        /// <param name="lpdwFlags"></param>
        /// <param name="dwReserved"></param>
        /// <returns>True if connected.</returns>
        [DllImport("WININET", CharSet = CharSet.Auto)]
        static extern bool InternetGetConnectedState(ref InternetConnectionState lpdwFlags, int dwReserved);
        
        /// <summary>
        /// Initializes internet connection status.
        /// </summary>
        /// <param name="state">Which state is needed to return.</param>
        private static bool Init(InternetConnectionState state)
        {
            InternetConnectionState flags = 0;
            bool isInternetConnected = false;
            isInternetConnected = InternetGetConnectedState(ref flags, 0);

            if (state == InternetConnectionState.INTERNET_CONNECTION_OFFLINE)
                return isInternetConnected;
            else
                return (flags & state) != 0; // Example: 010101 & 010100 = 010100 != 0 = true; or 000001 & 010100 = 000000 != 0 = false.
        }
    }
}
