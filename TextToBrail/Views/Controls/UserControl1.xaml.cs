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
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TextToBrail.Views.Controls;
public sealed partial class UserControl1 : UserControl
{
    public bool IsConvex1
    {
        get => (bool)GetValue(IsConvex1Property);
        set => SetValue(IsConvex1Property, value);
    }
    public bool IsConvex2
    {
        get => (bool)GetValue(IsConvex2Property);
        set => SetValue(IsConvex2Property, value);
    }
    public bool IsConvex3
    {
        get => (bool)GetValue(IsConvex3Property);
        set => SetValue(IsConvex3Property, value);
    }
    public bool IsConvex4
    {
        get => (bool)GetValue(IsConvex4Property);
        set => SetValue(IsConvex4Property, value);
    }
    public bool IsConvex5
    {
        get => (bool)GetValue(IsConvex5Property);
        private set => SetValue(IsConvex5Property, value);
    }
    public bool IsConvex6
    {
        get => (bool)GetValue(IsConvex6Property);
        private set => SetValue(IsConvex6Property, value);
    }

    static readonly DependencyProperty IsConvex1Property = DependencyProperty.Register(
        nameof(IsConvex1),
        typeof(bool),
        typeof(UserControl1),
        new PropertyMetadata(default(bool)));

    static readonly DependencyProperty IsConvex2Property = DependencyProperty.Register(
        nameof(IsConvex2),
        typeof(bool),
        typeof(UserControl1),
        new PropertyMetadata(default(bool)));

    static readonly DependencyProperty IsConvex3Property = DependencyProperty.Register(
        nameof(IsConvex3),
        typeof(bool),
        typeof(UserControl1),
        new PropertyMetadata(default(bool)));

    static readonly DependencyProperty IsConvex4Property = DependencyProperty.Register(
        nameof(IsConvex4),
        typeof(bool),
        typeof(UserControl1),
        new PropertyMetadata(default(bool)));

    static readonly DependencyProperty IsConvex5Property = DependencyProperty.Register(
        nameof(IsConvex5),
        typeof(bool),
        typeof(UserControl1),
        new PropertyMetadata(default(bool)));

    static readonly DependencyProperty IsConvex6Property = DependencyProperty.Register(
        nameof(IsConvex6),
        typeof(bool),
        typeof(UserControl1),
        new PropertyMetadata(default(bool)));
   
    public bool IsLoggedIn { get; set; }
    public short[] Items
    {
        get => (short[])GetValue(ItemsProperty);
        set => SetValue(ItemsProperty, value);
    }
   
    static readonly DependencyProperty ItemsProperty = DependencyProperty.Register(
        nameof(Items),
        typeof(short[]),
        typeof(UserControl1),
        new PropertyMetadata(null, new PropertyChangedCallback(OnItemsChanged)));

    public UserControl1()
    {
        this.InitializeComponent();
    }

    private static void OnItemsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is not UserControl1 labelControl) return;

        if (e.NewValue is not short[] collection) return;

        labelControl.first.IsChecked = Convert.ToBoolean(collection[0]);
        labelControl.second.IsChecked = Convert.ToBoolean(collection[1]);
        labelControl.third.IsChecked = Convert.ToBoolean(collection[2]);
        labelControl.fourth.IsChecked = Convert.ToBoolean(collection[3]);
        labelControl.fifth.IsChecked = Convert.ToBoolean(collection[4]);
        labelControl.sixth.IsChecked = Convert.ToBoolean(collection[5]);
    }
}
