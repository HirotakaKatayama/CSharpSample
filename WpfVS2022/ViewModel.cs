using Reactive.Bindings;

namespace WpfVS2022;

internal class ViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    public ReactivePropertySlim<string> Name { get; }

    public ViewModel()
    {
        Name = new ReactivePropertySlim<string>();
    }
}