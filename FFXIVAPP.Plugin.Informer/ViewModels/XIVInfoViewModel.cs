// FFXIVAPP.Plugin.Informer
// XIVInfoViewModel.cs
// 
// Copyright © 2013 ZAM Network LLC

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;
using FFXIVAPP.Common.Core.Memory;

namespace FFXIVAPP.Plugin.Informer.ViewModels
{
    public class XIVInfoViewModel : INotifyPropertyChanged
    {
        #region Property Bindings

        private static XIVInfoViewModel _instance;
        private ObservableCollection<EnmityEntry> _agroEntries;
        private ObservableCollection<ActorEntity> _currentMonsters;
        private ObservableCollection<ActorEntity> _currentNPCs;
        private ObservableCollection<ActorEntity> _currentPCs;
        private ActorEntity _currentTarget;
        private ActorEntity _currentUser;
        private ObservableCollection<EnmityEntry> _enmityEntries;
        private ActorEntity _focusTarget;
        private ActorEntity _mouseOverTarget;
        private ActorEntity _previousTarget;

        public static XIVInfoViewModel Instance
        {
            get { return _instance ?? (_instance = new XIVInfoViewModel()); }
            set { _instance = value; }
        }

        public ActorEntity CurrentUser
        {
            get { return _currentUser ?? (_currentUser = new ActorEntity()); }
            set
            {
                _currentUser = value;
                RaisePropertyChanged();
            }
        }

        public ActorEntity CurrentTarget
        {
            get { return _currentTarget ?? (_currentTarget = new ActorEntity()); }
            set
            {
                _currentTarget = value;
                RaisePropertyChanged();
            }
        }

        public ActorEntity MouseOverTarget
        {
            get { return _mouseOverTarget ?? (_mouseOverTarget = new ActorEntity()); }
            set
            {
                _mouseOverTarget = value;
                RaisePropertyChanged();
            }
        }

        public ActorEntity FocusTarget
        {
            get { return _focusTarget ?? (_focusTarget = new ActorEntity()); }
            set
            {
                _focusTarget = value;
                RaisePropertyChanged();
            }
        }

        public ActorEntity PreviousTarget
        {
            get { return _previousTarget ?? (_previousTarget = new ActorEntity()); }
            set
            {
                _previousTarget = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<EnmityEntry> EnmityEntries
        {
            get { return _enmityEntries ?? (_enmityEntries = new ObservableCollection<EnmityEntry>()); }
            set
            {
                _enmityEntries = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<EnmityEntry> AgroEntries
        {
            get { return _agroEntries ?? (_agroEntries = new ObservableCollection<EnmityEntry>()); }
            set
            {
                _agroEntries = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<ActorEntity> CurrentNPCs
        {
            get { return _currentNPCs ?? (_currentNPCs = new ObservableCollection<ActorEntity>()); }
            set
            {
                _currentNPCs = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<ActorEntity> CurrentMonsters
        {
            get { return _currentMonsters ?? (_currentMonsters = new ObservableCollection<ActorEntity>()); }
            set
            {
                _currentMonsters = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<ActorEntity> CurrentPCs
        {
            get { return _currentPCs ?? (_currentPCs = new ObservableCollection<ActorEntity>()); }
            set
            {
                _currentPCs = value;
                RaisePropertyChanged();
            }
        }

        #endregion

        #region Declarations

        public Timer InfoTimer = new Timer(100);

        public bool IsProcessing { get; set; }

        #endregion

        public XIVInfoViewModel()
        {
            InfoTimer.Elapsed += InfoTimerOnElapsed;
            InfoTimer.Start();
        }

        private void InfoTimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            if (IsProcessing)
            {
                return;
            }
            IsProcessing = true;
            // do stuff if you have too
            IsProcessing = false;
        }

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }

        #endregion
    }
}
