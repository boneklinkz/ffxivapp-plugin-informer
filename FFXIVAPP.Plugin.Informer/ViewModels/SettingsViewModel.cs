﻿// FFXIVAPP.Plugin.Informer
// SettingsViewModel.cs
// 
// Copyright © 2013 ZAM Network LLC

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FFXIVAPP.Plugin.Informer.ViewModels
{
    internal sealed class SettingsViewModel : INotifyPropertyChanged
    {
        #region Property Bindings

        private static SettingsViewModel _instance;

        public static SettingsViewModel Instance
        {
            get { return _instance ?? (_instance = new SettingsViewModel()); }
        }

        #endregion

        #region Declarations

        #endregion

        #region Loading Functions

        #endregion

        #region Utility Functions

        #endregion

        #region Command Bindings

        #endregion

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }

        #endregion
    }
}
