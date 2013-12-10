// FFXIVAPP.Plugin.Informer
// French.cs
// 
// Copyright © 2013 ZAM Network LLC

using System.Windows;

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
            Dictionary.Add("informer_PLACEHOLDER", "*PH*");
            Dictionary.Add("informer_PlayerTabHeader", "Player");
            Dictionary.Add("informer_AgroTabHeader", "Agro");
            Dictionary.Add("informer_TargetsTabHeader", "Targets");
            Dictionary.Add("informer_TargetEnmityTabHeader", "Target Enmity");
            Dictionary.Add("informer_CurrentPlayerHeader", "Current Player");
            Dictionary.Add("informer_CurrentAgroHeader", "Current Agro");
            Dictionary.Add("informer_CurrentTargetHeader", "Current Target");
            Dictionary.Add("informer_FocusTargetHeader", "Focus Target");
            Dictionary.Add("informer_MouseOverTargetHeader", "MouseOver Target");
            Dictionary.Add("informer_PreviousTargetHeader", "Previous Target");
            Dictionary.Add("informer_NameLabel", "Name:");
            Dictionary.Add("informer_LevelLabel", "Level:");
            Dictionary.Add("informer_HPLabel", "HP:");
            Dictionary.Add("informer_MPLabel", "MP:");
            Dictionary.Add("informer_TPLabel", "TP:");
            Dictionary.Add("informer_GPLabel", "GP:");
            Dictionary.Add("informer_CPLabel", "CP:");
            Dictionary.Add("informer_StatusCountLabel", "Status Count:");
            Dictionary.Add("informer_EnmityHeader", "Enmity");
            Dictionary.Add("informer_NameHeader", "Name");
            Dictionary.Add("informer_EnmityPercentHeader", "Enmity %");
            return Dictionary;
        }
    }
}
