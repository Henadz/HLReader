using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;

namespace HLReader.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase, IMainViewModel
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
            }
            else
            {
                ApllicationCloseCommand = new RelayCommand(ApplicationClose);
                ImportFeedsCommand = new RelayCommand(ImportFeeds);
                ExportFeedsCommand = new RelayCommand(ExportFeeds);
            }
        }

        private void ExportFeeds()
        {
            var w = new View.ImportFeeds();
            w.Show();
        }

        private void ImportFeeds()
        {
            throw new NotImplementedException();
        }

        private void ApplicationClose()
        {
            Application.Current.MainWindow.Close();
        }

        public RelayCommand ApllicationCloseCommand { get; set; }

        public RelayCommand ImportFeedsCommand { get; set; }

        public RelayCommand ExportFeedsCommand { get; set; }
    }
}