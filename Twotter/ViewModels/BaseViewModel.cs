﻿
using JetBrains.Annotations;
using System.ComponentModel;
using System.Runtime.CompilerServices;



namespace Twotter.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private bool _busy;
        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsBusy
        {
            get => _busy;
            set
            {
                if (_busy == value) return;
                _busy = value;
                OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}