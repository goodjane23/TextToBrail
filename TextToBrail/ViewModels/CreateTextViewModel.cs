using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using TextToBrail.Models;

namespace TextToBrail.ViewModels;
public partial class CreateTextViewModel : ObservableObject
{
    public Action CloseAction { get; set; }

    [ObservableProperty]
    private string text;

    [RelayCommand]
    private void SaveText(object obj)
    {
        TextHandler.NewText = Text;
        CloseAction();
    }

    [RelayCommand]
    private void DeleteText() 
    {
        Text = string.Empty;
    }
}
