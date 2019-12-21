namespace Gu.TwinCat.TestClient
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;

    public sealed class ViewModel : IDisposable, INotifyPropertyChanged
    {
        private bool disposed;
        private string? netId;
        private int port = 851;

        public ViewModel()
        {
            this.ConnectCommand = new RelayCommand(_ => this.TryCatch(() => this.AdsClient.Connect(this.netId!, this.port)));
            this.DisconnectCommand = new RelayCommand(_ => this.TryCatch(() => this.AdsClient.Disconnect()));
            this.ClearExceptionsCommand = new RelayCommand(_ => this.Exceptions.Clear(), _ => this.Exceptions.Count > 0);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public AdsClient AdsClient { get; } = new AdsClient(new AdsClientAutoReconnectSettings(null, TimeSpan.FromMilliseconds(1000), InactiveSymbolHandling.Throw));

        public ICommand ConnectCommand { get; }

        public ICommand DisconnectCommand { get; }

        public ICommand ClearExceptionsCommand { get; }

        public ObservableCollection<Exception> Exceptions { get; } = new ObservableCollection<Exception>();

        public string? NetId
        {
            get => this.netId;
            set
            {
                if (value == this.netId)
                {
                    return;
                }

                this.netId = value;
                this.OnPropertyChanged();
            }
        }

        public int Port
        {
            get => this.port;
            set
            {
                if (value == this.port)
                {
                    return;
                }

                this.port = value;
                this.OnPropertyChanged();
            }
        }

        public ObservableCollection<ReadSymbolViewModel> ReadSymbols { get; } = new ObservableCollection<ReadSymbolViewModel>();

        public ObservableCollection<WriteSymbolViewModel> WriteSymbols { get; } = new ObservableCollection<WriteSymbolViewModel>();

        public ObservableCollection<SubscribeSymbolViewModel> SubscribeSymbols { get; } = new ObservableCollection<SubscribeSymbolViewModel>();

        public void Dispose()
        {
            if (this.disposed)
            {
                return;
            }

            this.disposed = true;
            this.AdsClient.Dispose();
            foreach (var subscribeSymbol in this.SubscribeSymbols)
            {
                subscribeSymbol.Dispose();
            }
        }

        public void TryCatch(Action action)
        {
            try
            {
                action();
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception e)
#pragma warning restore CA1031 // Do not catch general exception types
            {
                this.Exceptions.Add(e);
            }
        }

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
