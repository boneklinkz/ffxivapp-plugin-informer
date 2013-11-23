// FFXIVAPP.Plugin.Informer
// English.cs
// 
// Copyright © 2013 ZAM Network LLC

#region Usings

using System.Windows;

#endregion

namespace FFXIVAPP.Plugin.Informer.Localization
{
    public abstract class English
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context()
        {
            Dictionary.Clear();
            Dictionary.Add("informer_", "PLACEHOLDER");
            return Dictionary;
        }
    }
}
