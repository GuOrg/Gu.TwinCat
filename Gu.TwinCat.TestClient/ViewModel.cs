namespace Gu.TwinCat.TestClient
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Windows.Input;
    using TwinCAT.Ads;

    public sealed class ViewModel : IDisposable, INotifyPropertyChanged
    {
        private bool disposed;
        private string? netId;
        private int port;
        private object? readValue;
        private object? writeValue;
        private string? subscribeSymbol;
        private Subscription<float, float>? subscription;

        public ViewModel()
        {
            this.ConnectCommand = new RelayCommand(_ => this.TryCatch(() => this.AdsClient.Connect(this.netId!, this.port)));
            this.DisconnectCommand = new RelayCommand(_ => this.TryCatch(() => this.AdsClient.Disconnect()));

            this.ReadCommand = new RelayCommand(
                _ => this.TryCatch(() => this.ReadValue = this.ReadSymbol.Read(this.AdsClient)),
                _ => this.AdsClient.IsConnected && this.ReadSymbol.Name is { } && this.ReadSymbol.Type is { });

            this.WriteCommand = new RelayCommand(
                _ => this.TryCatch(() => this.WriteSymbol.Write(this.AdsClient, this.writeValue)),
                _ => this.AdsClient.IsConnected && this.WriteSymbol.Name is { } && this.WriteSymbol.Type is { });

            this.SubscribeCommand = new RelayCommand(
                _ => this.TryCatch(() => this.Subscription = this.AdsClient.Subscribe(ReadFromAdsSymbol.Single(this.subscribeSymbol), AdsTransMode.OnChange, AdsTimeSpan.FromMilliseconds(100))),
                _ => this.AdsClient.IsConnected && this.subscribeSymbol is { });

            this.ClearExceptionsCommand = new RelayCommand(_ => this.Exceptions.Clear(), _ => this.Exceptions.Count > 0);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public AdsClient AdsClient { get; } = new AdsClient();

        public ICommand ConnectCommand { get; }

        public ICommand DisconnectCommand { get; }

        public ICommand ReadCommand { get; }

        public ICommand WriteCommand { get; }

        public ICommand SubscribeCommand { get; }

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

        public SymbolViewModel ReadSymbol { get; } = new SymbolViewModel();

        public object? ReadValue
        {
            get => this.readValue;
            set
            {
                if (ReferenceEquals(value, this.readValue))
                {
                    return;
                }

                this.readValue = value;
                this.OnPropertyChanged();
            }
        }

        public SymbolViewModel WriteSymbol { get; } = new SymbolViewModel();

        public object? WriteValue
        {
            get => this.writeValue;
            set
            {
                if (ReferenceEquals(value, this.writeValue))
                {
                    return;
                }

                this.writeValue = value;
                this.OnPropertyChanged();
            }
        }

        public string? SubscribeSymbol
        {
            get => this.subscribeSymbol;
            set
            {
                if (value == this.subscribeSymbol)
                {
                    return;
                }

                this.subscribeSymbol = value;
                this.OnPropertyChanged();
            }
        }

        public Subscription<float, float>? Subscription
        {
            get => this.subscription;
            private set
            {
                if (ReferenceEquals(value, this.subscription))
                {
                    return;
                }

                this.subscription?.Dispose();
                this.subscription = value;
                this.OnPropertyChanged();
            }
        }

        public void Dispose()
        {
            if (this.disposed)
            {
                return;
            }

            this.disposed = true;
            this.AdsClient.Dispose();
            this.subscription?.Dispose();
        }

        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void TryCatch(Action action)
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
    }
}
