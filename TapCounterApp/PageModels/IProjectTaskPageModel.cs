using CommunityToolkit.Mvvm.Input;
using TapCounterApp.Models;

namespace TapCounterApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}