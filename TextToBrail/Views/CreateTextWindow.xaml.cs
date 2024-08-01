using Microsoft.UI.Xaml;
using System;
using TextToBrail.ViewModels;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TextToBrail;
/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class CreateTextWindow : Window
{
    public CreateTextViewModel ViewModel { get; set; }
    public CreateTextWindow()
    {
        this.InitializeComponent();
        ViewModel = new CreateTextViewModel();
        if (ViewModel.CloseAction == null)
            ViewModel.CloseAction = new Action(this.Close);
    }

}
