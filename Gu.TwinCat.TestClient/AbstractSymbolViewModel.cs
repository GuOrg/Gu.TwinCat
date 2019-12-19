namespace Gu.TwinCat.TestClient
{
    using System;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public abstract class AbstractSymbolViewModel : INotifyPropertyChanged
    {
        private string? name;
        private Type? @type;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string? Name
        {
            get => this.name;
            set
            {
                if (value == this.name)
                {
                    return;
                }

                this.name = value;
                this.OnPropertyChanged();
            }
        }

        public Type? Type
        {
            get => this.type;
            set
            {
                if (ReferenceEquals(value, this.type))
                {
                    return;
                }

                this.type = value;
                this.OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
