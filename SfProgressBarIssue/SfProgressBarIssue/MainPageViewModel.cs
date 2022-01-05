using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Windows.Input;

namespace SfProgressBarIssue;

public class MainPageViewModel : BaseViewModel
{
    private int progress;
    public int Progress
    {
        get => progress;
        set => SetProperty(ref progress, value);
    }

    public ICommand IncreaseProgressCommand { get; }

    public MainPageViewModel()
    {
        IncreaseProgressCommand = new Command(OnIncreaseProgessCommandExecuted);
    }

    private void OnIncreaseProgessCommandExecuted(object obj)
    {
        if (Progress < 3)
        {
            Progress++;
        }
    }
}
