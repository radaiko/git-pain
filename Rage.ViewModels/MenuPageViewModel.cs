using System;
using System.Reactive;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Rage.ViewModels;
using ReactiveUI;

namespace Rage.ViewModels
{

    public class MenuPageViewModel : ViewModelBase
    {

        public MenuPageViewModel()
        {
            
        }

        private void OpenSettings(){
            // TODO: create settings dialog
        }
        private void CloseApp(){
            Environment.Exit(0);
        }
    }
}