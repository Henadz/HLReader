using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLReader.ViewModel
{
    public interface IMainViewModel
    {
        RelayCommand ApllicationCloseCommand { get; set; }
        RelayCommand ImportFeedsCommand { get; set; }
        RelayCommand ExportFeedsCommand { get; set; }
    }
}
