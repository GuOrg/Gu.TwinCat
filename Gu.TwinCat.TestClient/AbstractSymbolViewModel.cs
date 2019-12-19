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
                if (this.type is null &&
                    value is { })
                {
                    if (value.Contains("_r"))
                    {
                        this.Type = typeof(float);
                    }
                    else if (value.Contains("_b"))
                    {
                        this.Type = typeof(bool);
                    }
                    else if (value.Contains("_i"))
                    {
                        this.Type = typeof(short);
                    }
                    else if (value.Contains("_di"))
                    {
                        this.Type = typeof(int);
                    }
                    else if (value.Contains("_udi"))
                    {
                        this.Type = typeof(uint);
                    }
                    else if (value.Contains("_a"))
                    {
                        this.Type = typeof(float[]);
                    }
                    else if (value.Contains("_s"))
                    {
                        this.Type = typeof(string);
                    }
                }
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
