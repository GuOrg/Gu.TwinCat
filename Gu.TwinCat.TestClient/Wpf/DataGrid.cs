namespace Gu.TwinCat.TestClient
{
    using System;
    using System.Windows;
    using System.Windows.Controls;

    public static class DataGrid
    {
        public static readonly DependencyProperty CellEditModeProperty = DependencyProperty.RegisterAttached(
            "CellEditMode",
            typeof(bool),
            typeof(DataGrid),
            new FrameworkPropertyMetadata(
                default(bool),
                FrameworkPropertyMetadataOptions.Inherits,
                OnCellEditModeChanged));

        private static readonly DependencyProperty ListenerProperty = DependencyProperty.RegisterAttached(
            "Listener",
            typeof(Listener),
            typeof(DataGrid),
            new PropertyMetadata(
                default(Listener),
                (o, e) => (e.OldValue as IDisposable)?.Dispose()));

        public static void SetCellEditMode(DependencyObject element, bool value)
        {
            element.SetValue(CellEditModeProperty, value);
        }

        public static bool GetCellEditMode(DependencyObject element)
        {
            return (bool)element.GetValue(CellEditModeProperty);
        }

        private static void OnCellEditModeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is System.Windows.Controls.DataGrid dataGrid)
            {
#pragma warning disable CA2000 // Dispose objects before losing scope
                dataGrid.SetValue(ListenerProperty, Equals(true, e.NewValue) ? new Listener(dataGrid) : null);
#pragma warning restore CA2000 // Dispose objects before losing scope
            }
        }

        private sealed class Listener : IDisposable
        {
            private readonly System.Windows.Controls.DataGrid dataGrid;
            private bool disposed;
            private DataGridRow? editRow;

            internal Listener(System.Windows.Controls.DataGrid dataGrid)
            {
                dataGrid.CellEditEnding += this.OnCellEditEnding;
                dataGrid.CurrentCellChanged += this.OnCurrentCellChanged;
                this.dataGrid = dataGrid;
            }

            public void Dispose()
            {
                if (this.disposed)
                {
                    return;
                }

                this.disposed = true;
                this.dataGrid.CellEditEnding -= this.OnCellEditEnding;
                this.dataGrid.CurrentCellChanged -= this.OnCurrentCellChanged;
            }

            private void OnCurrentCellChanged(object sender, EventArgs e)
            {
                if (this.editRow is { IsEditing: true } &&
                    sender is System.Windows.Controls.DataGrid dataGrid)
                {
                    _ = dataGrid.CommitEdit(DataGridEditingUnit.Row, exitEditingMode: false);
                }

                this.editRow = null;
            }

            private void OnCellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
            {
                if (e.EditAction == DataGridEditAction.Commit)
                {
                    this.editRow = e.Row;
                }
            }
        }
    }
}
