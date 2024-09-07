using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using TextToBrail.Models;
using TextToBrail.Sevices;

namespace TextToBrail.ViewModels;
public partial class CreateTextViewModel : ObservableObject
{
    public Action CloseAction { get; set; }

    [ObservableProperty]
    private string text;

    [RelayCommand]
    private void SaveText(object obj)
    {
        TextHandlerService.NewText = Text;
        CloseAction();
    }

    [RelayCommand]
    private void DeleteText() 
    {
        Text = string.Empty;
    }
}
