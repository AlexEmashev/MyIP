using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.Runtime.Remoting.Messaging;
using System.IO;
using System.Text.RegularExpressions;

namespace MyIP
{
    /// <summary>
    /// Class provides information concerning local and external IP addresses.
    /// </summary>
    class IPs
    {
        /// <summary>
        /// Returns local IP addresses.
        /// </summary>
        /// <returns>Array of IPs in strings</returns>
        public string[] GetLocalIPs()
        {
            try
            {
                string hostName = Dns.GetHostName();
                IPAddress[] ipadresses = Dns.GetHostAddresses(hostName);
                string[] listOfLocalIPs = new string[ipadresses.Length];

                for (int i = 0; i < ipadresses.Length; i++)
                {
                    listOfLocalIPs[i] = ipadresses[i].ToString();
                }

                return listOfLocalIPs;
            }
            catch (Exception exc)
            {
                string[] error = {exc.Message, exc.Source};
                return error;
            }
        }

        /// <summary>
        /// Runs asynchronous to fetch the external IP address.
        /// </summary>
        /// <param name="callBackMethod">Callback method reference. That method will be executed after this one will be completed.
        /// <remarks> To get the IP information use AsyncDelegate property on result object which is AsyncResult type. Property returns reference on 
        /// ExternalIPDelegate. After getting the delegate run EndInvoke method to get return value which is ExternalIPInfo type.</param>
        /// </remarks>
        public void GetExternalIP(AsyncCallback callBackMethod)
        {
            // Run asynchronous method to get the IP.
            ExternalIPDelegate externalIPDelegate = new ExternalIPDelegate(FetchExternalIP);  
            externalIPDelegate.BeginInvoke(callBackMethod,null);
            
        }
        /// <summary>
        /// Delegate for asynchoronous method call.
        /// </summary>
        /// <returns>Info of external IP address.</returns>
        public delegate ExternalIPInfo ExternalIPDelegate();
        /// <summary>
        /// Asynchronous method which gets the IP from external resource.
        /// </summary>
        private ExternalIPInfo FetchExternalIP()
        {
            if (!InternetConnectionStatus.IsInternetConnected)
            {
                return new ExternalIPInfo(ExternalIPInfo.State.NoConnection, true, Program.Localisation.NoInternetConnection);
            }

            // Trying to get the information from remote server.
                     
            try
            {
                UriBuilder ub = new UriBuilder(MyIP.Properties.Settings.Default.ExternalIPSource);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(ub.Uri);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream inputStream = resp.GetResponseStream();
                string data = new StreamReader(inputStream).ReadToEnd(); // Data wich can contain the IP.
                //data = "3FFF:FFFF:FFFF:FFFF:FFFF:FFFF:FFFF:FFFF";
                string ipString = ParseIP(data);

                if (ipString == string.Empty)
                {
                    return new ExternalIPInfo(ExternalIPInfo.State.IPNotFound, true, Program.Localisation.IPNotFound);
                }

                return new ExternalIPInfo(ExternalIPInfo.State.Successful, true, ipString);
            }
            catch (System.ArgumentNullException exc)
            {
                return new ExternalIPInfo(ExternalIPInfo.State.PageNotFound, true, Program.Localisation.NoServerAddress);
            }
            catch (System.NotSupportedException exc)
            {
                return new ExternalIPInfo(ExternalIPInfo.State.PageNotFound, true, Program.Localisation.NotSupportedURL);
            }
            catch (System.Security.SecurityException exc)
            {
                return new ExternalIPInfo(ExternalIPInfo.State.UnknownError, true, Program.Localisation.NotEnoughRightsToGetIP);
            }
            catch (WebException exc)
            {
                return new ExternalIPInfo(ExternalIPInfo.State.PageNotFound, true, Program.Localisation.ProblemWithRemoteServer);
            }
            catch (ProtocolViolationException exc)
            {
                return new ExternalIPInfo(ExternalIPInfo.State.UnknownError, true, Program.Localisation.ProblemWithProtocol);
            }
            catch (Exception exc)
            {
                return new ExternalIPInfo(ExternalIPInfo.State.UnknownError, true, Program.Localisation.ErrorOccuredIPFetch);
            }
        }

        /// <summary>
        /// Parses IP from string in parameter <paramref name="data"/>. (IPv4 and IPv6 are supported).
        /// </summary>
        /// <param name="data"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        private string ParseIP(string data)
        {
            // First, parses the IPv4.
            string pattern = @"(?<!\d)(((00\d)|(0\d{1,2})|(\d{1,2})|(1\d{2})|(2[0-4]\d)|(25[0-5]))\.){3}((00\d)|(0\d{1,2})|(\d{1,2})|(1\d{2})|(2[0-4]\d)|(25[0-5]))";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(data);
            if (!match.Success) // Trying to parse IPv6
            {
                pattern = @"((^|:)([0-9a-fA-F]{0,4})){1,8}$";
                regex = new Regex(pattern);
                match = regex.Match(data);
            }

            return match.Value;
        }
    }

    /// <summary>
    /// Class-container for IP information. That comes from GetExternalIP method.
    /// </summary>
    class ExternalIPInfo
    {
        /// <summary>
        /// State of operation.
        /// </summary>
        public enum State { NoConnection, PageNotFound, IPNotFound, UnknownError, Successful }

        State operationState;
        /// <summary>
        /// Returns state of operation. If "Successful" then Value have the IP infromation. 
        /// If not, the information concerning of problem.
        /// </summary>
        public State OperationState
        {
            get { return operationState; }
            set { operationState = value; }
        }

        bool isCompleted;
        /// <summary>
        /// true if operation is completed.
        /// </summary>
        public bool IsCompleted
        {
            get { return isCompleted; }
            set { isCompleted = value; }
        }

        string result;
        /// <summary>
        /// If operation was successful returns the external IP, if not the information concerning of problem.
        /// </summary>
        public string Result
        {
            get { return result; }
            set { result = value; }
        }
        /// <summary>
        /// Constructor of class.
        /// </summary>
        /// <param name="state">State of operation.</param>
        /// <param name="isCompleted">true if completed.</param>
        /// <param name="result">Information concerning the operation or IP if operation was successful.</param>
        public ExternalIPInfo(State state, bool isCompleted, string result)
        {
            this.operationState = state;
            this.isCompleted = isCompleted;
            this.result = result;
        }
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ExternalIPInfo()
        {
            operationState = State.UnknownError;
            isCompleted = false;
            result = "";
        }
    }
}
