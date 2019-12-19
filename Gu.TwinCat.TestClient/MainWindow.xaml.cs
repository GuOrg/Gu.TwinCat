namespace Gu.TwinCat.TestClient
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void OnCanReadExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (sender is Button button &&
                button.DataContext is ReadSymbolViewModel { Name: { }, Type: { } } &&
                this.DataContext is ViewModel { AdsClient: { IsConnected: true } })
            {
                e.CanExecute = true;
            }

            e.Handled = true;
        }

        private void OnReadExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (sender is Button button &&
                button.DataContext is ReadSymbolViewModel { Name: { }, Type: { } } symbolVm &&
                this.DataContext is ViewModel { AdsClient: { IsConnected: true } client } viewModel)
            {
                viewModel.TryCatch(() => symbolVm.Read(client));
            }
        }

        private void OnCanWriteExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (sender is Button button &&
                button.DataContext is WriteSymbolViewModel { Name: { }, Type: { } } &&
                this.DataContext is ViewModel { AdsClient: { IsConnected: true } })
            {
                e.CanExecute = true;
            }

            e.Handled = true;
        }

        private void OnWriteExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (sender is Button button &&
                button.DataContext is WriteSymbolViewModel { Name: { }, Type: { } } symbolVm &&
                this.DataContext is ViewModel { AdsClient: { IsConnected: true } client } viewModel)
            {
                viewModel.TryCatch(() => symbolVm.Write(client));
            }
        }

        private void OnCanSubscribeExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (sender is Button button &&
                button.DataContext is SubscribeSymbolViewModel { Name: { }, Type: { }, Subscription: null } &&
                this.DataContext is ViewModel { AdsClient: { IsConnected: true } })
            {
                e.CanExecute = true;
            }

            e.Handled = true;
        }

        private void OnSubscribeExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (sender is Button button &&
                button.DataContext is SubscribeSymbolViewModel { Name: { }, Type: { } } symbolVm &&
                this.DataContext is ViewModel { AdsClient: { IsConnected: true } client } viewModel)
            {
                viewModel.TryCatch(() => symbolVm.Subscribe(client));
            }
        }

        private void OnCanUnsubscribeExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            if (sender is Button button &&
                button.DataContext is SubscribeSymbolViewModel { Name: { }, Type: { }, Subscription: { } } &&
                this.DataContext is ViewModel { AdsClient: { IsConnected: true } })
            {
                e.CanExecute = true;
            }

            e.Handled = true;
        }

        private void OnUnsubscribeExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            if (sender is Button button &&
                button.DataContext is SubscribeSymbolViewModel { Name: { }, Type: { } } symbolVm &&
                this.DataContext is ViewModel { AdsClient: { IsConnected: true } } viewModel)
            {
                viewModel.TryCatch(() => symbolVm.Unsubscribe());
            }
        }
    }
}
