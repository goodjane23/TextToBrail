using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TextToBrail.Models;
using TextToBrail.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TextToBrail;
/// <summary>
/// An empty window that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainWindow : Window
{
    public MainViewModel ViewModel{ get; set; }

    public MainWindow()
    {
        this.InitializeComponent();
        ViewModel = new MainViewModel();
    }

    private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (symbolList.SelectedIndex != dotsList.SelectedIndex)
            symbolList.SelectedIndex = dotsList.SelectedIndex;
    }

    private void symbolList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (dotsList.SelectedIndex != symbolList.SelectedIndex) 
            dotsList.SelectedIndex = symbolList.SelectedIndex;
    }
}
