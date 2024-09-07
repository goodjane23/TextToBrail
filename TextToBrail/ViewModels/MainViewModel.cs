using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows;
using TextToBrail.Models;
using TextToBrail.Sevices;
using Windows.Storage;
using Windows.Storage.Pickers;
using WinRT.Interop;

namespace TextToBrail.ViewModels;
public partial class MainViewModel : ObservableObject
{
    #region Fields

    private string fileContent;

    #endregion Fields

    #region Properties

    [ObservableProperty]
    private string currentText;

    [ObservableProperty]
    private short[] letter;

    public ObservableCollection<Letter> Letters { get; set; }

    #endregion Properties

    #region Ctor

    public MainViewModel()
    {
       
    }

    #endregion Ctor

    #region Commands

    [RelayCommand]
    private void CreateNewFile()
    {
        CreateTextWindow createTextWindow = new();
        createTextWindow.Activate();
        _ = TextHandlerService.GetInstance();
        TextHandlerService.Notify += TextUpdate;
    }
    
    [RelayCommand]
    private async Task OpenFile()
    {
        try
        {
            var openPicker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.Thumbnail,
                SuggestedStartLocation = PickerLocationId.Desktop
            };

            openPicker.FileTypeFilter.Add(".txt");
            var hwnd = WindowNative.GetWindowHandle(App.MainWnd);
            InitializeWithWindow.Initialize(openPicker, hwnd);

            var storageFile = await openPicker.PickSingleFileAsync();

            if (storageFile is null)
                return;

            fileContent = await FileIO.ReadTextAsync(storageFile);
            Letters = new ObservableCollection<Letter>(await TextParsingConverter.ConvertTextAsync(fileContent));
            
            CurrentText = fileContent;
            OnPropertyChanged(nameof(Letters));
        }
        catch (Exception)
        {
            throw;
        }
    }

    #endregion Commands

    #region Methods
    private async void TextUpdate(string text)
    {
        CurrentText = text;
        try
        {
            Letters = new ObservableCollection<Letter>(await TextParsingConverter.ConvertTextAsync(text));
        }
        catch (Exception)
        {
            MessageBox.Show("Символ не найден. Конвертация прервана");
        }

        OnPropertyChanged(nameof(Letters));
    }

    #endregion Methods
}
