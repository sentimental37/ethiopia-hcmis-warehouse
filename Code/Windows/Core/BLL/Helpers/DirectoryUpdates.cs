
// Generated by MyGeneration Version # (1.3.0.3)

using System;
using DAL;

namespace BLL
{
	public class DirectoryUpdateStatus : _DirectoryUpdateStatus
	{
        public DirectoryUpdateStatus()
		{
            
		}

        /// <summary>
        /// Gets the last version number updated from the directory Services
        /// </summary>
        /// <returns></returns>
        public static int? GetLastVersion(string syncType)
        {
            DirectoryUpdateStatus du = new DirectoryUpdateStatus();
            du.Where.Name.Value = syncType;
            du.Query.Load();
            if (du.RowCount == 0)
            {
                du.AddNew();
                du.Name = syncType;
                du.Save();
            }
            if (du.IsColumnNull("LastVersion"))
                return null;
            return du.LastVersion;
        }

        /// <summary>
        /// Saves the last  Version Number 
        /// </summary>
        /// <param name="lastVersion"></param>
        public static void SaveLastVersion(string syncType, int lastVersion)
        {
            DirectoryUpdateStatus du = new DirectoryUpdateStatus();
            du.Where.Name.Value = syncType;
            du.Query.Load();
            if (du.RowCount > 0)
            {
                du.LastVersion = lastVersion;
                du.LastUpdated = DateTimeHelper.ServerDateTime;
                du.Save();
            }
        }

        /// <summary>
        /// Gets the status of Directory Servie Update.
        /// if the directory service is updated atleast once, it returns the date.
        /// </summary>
        /// <returns></returns>
        public static string GetLastUpdateTime()
        {
            DirectoryUpdateStatus du = new DirectoryUpdateStatus();
            du.LoadAll();
            if (du.RowCount > 0 && !du.IsColumnNull("LastUpdated"))
            {
                return du.LastUpdated.ToString();
            }
            else
            {
                return "Never Updated";
            }
        }
    }
}