// FFXIVAPP.Plugin.Informer
// French.cs
// 
// Copyright © 2013 ZAM Network LLC

#region Usings

using System.Windows;

#endregion

namespace FFXIVAPP.Plugin.Informer.Localization
{
    public abstract class French
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context()
        {
            Dictionary.Clear();
            Dictionary.Add("informer_", "*PH*");
            return Dictionary;
        }
    }
}
