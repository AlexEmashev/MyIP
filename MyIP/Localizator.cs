using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Data;

namespace MyIP
{
    [Serializable]
    public class Localizator
    {
        /// <summary>
        /// Current language.
        /// </summary>
        public string Language = "English";
        /// <summary>
        /// Name of the localisation resource file. Also current localization setting value.
        /// </summary>
        public string FileName = localizationsPath + Path.DirectorySeparatorChar + "english.xml";
        /// <summary>
        /// Language Code Identifier.
        /// </summary>
        public string LCID = "en-us"; // ToDo: In future, the app could load locale automatical, if such locale is exists.
        #region Interface
        // FormMyIP
        public string FormMyIP = "My IP";
        public string labelExternalIP = "External IP:";
        public string labelInternalIPs = "Internal IPs:";
        public string buttonRefresh = "Refresh";
        public string buttonRefreshTip = "Refresh IP data.";
        public string buttonCopy = "Copy to clipboard";
        public string buttonCopyTip = "Copy selected IP to clipboard.";
        public string buttonSettings = "Settings";
        public string buttonSettingsTip = "Show settings dialog.";
        public string buttonClose = "Close";
        public string buttonCloseTip = "Close the application.";

        // Form Settings
        public string FormSettings = "Settings";
        public string labelWebPage = "Web-page with IP:";
        public string labelNotion = @"The web-page that contains your IP address. Such page can be found on Internet " +
            "by request \"What is my IP\". By the default it's www.myexternalip.com/raw which "+
            "autor kindly allowed  to use the data from the resource in this app.";
        public string labelLanguage = "Language:";
        public string buttonOk = "Save";
        #endregion

        #region Messages
        public string ObtainingIP1 = "Obtaining IP";
        public string ObtainingIP2 = "Obtaining IP.";
        public string ObtainingIP3 = "Obtaining IP..";
        public string ObtainingIP4 = "Obtaining IP...";
        public string CopiedTip = "Copied";
        public string NoInternetConnection = "No internet connection.";
        public string IPNotFound = "IP not found.";
        public string NoServerAddress = "No server address. Please, check the settings.";
        public string NotSupportedURL = "Not supported URL. Please, check the settings.";
        public string NotEnoughRightsToGetIP = "Not enough rights to get the IP.";
        public string ProblemWithRemoteServer = "Problem with remote server.";
        public string ProblemWithProtocol = "Problem with protocol.";
        public string UnnableToConnectToTheServer = "Unnable to connect to the server.";
        public string ErrorOccuredIPFetch = "Error occured.";
        public string ErrorWhileGettingExternalIP = "Error while getting external IP";
        #endregion

        /// <summary>
        /// Path for localization files.
        /// </summary>
        private static string localizationsPath = "Localizations";

        /// <summary>
        /// Default constructor. Loads previous language if this possible.
        /// </summary>
        private Localizator()
        {
        }

        /// <summary>
        /// Returns localization object reference according the settings. If there is no such localization, returns default.
        /// </summary>
        /// <returns>Localization object reference.</returns>
        public static Localizator GetLocalization()
        {
            string path = Properties.Settings.Default.CurrentLocale;
            return GetLocalization(path);
        }

        /// <summary>
        /// Finds all localization files.
        /// </summary>
        /// <remarks>The path for localizations is "(app subfolder)/Localizations"</remarks>
        /// <returns>A key-value array, where key is a filename of localization and value is a language name.</returns>
        public static DataTable GetAvaliableLocalizations()
        {
            DataTable localizationsTable = new DataTable("Localizations");
            localizationsTable.Columns.Add("FileName", typeof(string));
            localizationsTable.Columns.Add("Language", typeof(string));

            if (!Directory.Exists(localizationsPath))
                return localizationsTable ;
            
            DirectoryInfo di = new DirectoryInfo(localizationsPath);

            FileInfo[] fi = di.GetFiles("*.xml", SearchOption.TopDirectoryOnly);
            
            foreach (FileInfo fileInfo in fi)
            {
                string language;
                string fileName;
                if (CheckLocalization(fileInfo.FullName, out fileName, out language))
                {
                    DataRow row = localizationsTable.NewRow();
                    row[0] = fileName; //Hack: Not FullName, cause this name is not the relative, but absolute.
                    row[1] = language;
                    localizationsTable.Rows.Add(row);
                }
            }

            return localizationsTable;
        }
        /// <summary>
        /// Checks localization file on consistency
        /// </summary>
        /// <param name="path">Path to localization file.</param>
        /// <param name="language">If localization file is valid, the name of localization language will returned. Otherwise empty string.</param>
        /// <returns>True if localization file is valid.</returns>
        private static bool CheckLocalization(string path,out string fileName, out string language)
        {
            language = String.Empty;
            fileName = String.Empty;

            Localizator loc = GetLocalization(path);

            if (loc == null)
                return false;

            language = loc.Language;
            fileName = loc.FileName;
            return true;
        }
        /// <summary>
        /// Reads localization file.
        /// </summary>
        /// <param name="path">Path to localization file.</param>
        /// <returns>Reference to localization object.</returns>
        public static Localizator GetLocalization(string path)
        {
            try
            {
                if (!File.Exists(path))
                    return new Localizator();

                XmlSerializer xmlSer = new XmlSerializer(typeof(MyIP.Localizator));
                StreamReader sr = new StreamReader(path);
                Localizator loc = (Localizator)xmlSer.Deserialize(sr);
                return loc;
            }
            catch (Exception exc)
            {
                return new Localizator();
            }
        }
        /// <summary>
        /// Saves localization object to file.
        /// </summary>
        /// <param name="localizator">Localization object reference.</param>
        public static void SaveLocalization(Localizator localizator)
        {
            try
            {
                if (!Directory.Exists(localizationsPath))
                    Directory.CreateDirectory(localizationsPath);

                XmlSerializer xmlSer = new XmlSerializer(typeof(Localizator));
                StreamWriter sw = new StreamWriter(localizator.FileName);
                xmlSer.Serialize(sw, localizator);
                sw.Close();
            }
            catch (Exception ex)
            {
               
            }
        }
    }
}
