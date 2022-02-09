using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLTest
{
    public class MainViewModel : ViewModelBase
    {

        public RelayCommand<string> triggerCommand { get; set; }
        public MainViewModel()
        {
            triggerCommand = new RelayCommand<string>(Trigger, (string txt)=>true);
        }



        public void Trigger(string txt)
        {
            var msg = new Amessage() { TheText = "TEST TEXT" };
            Messenger.Default.Send<Amessage>(msg);
        }
    }
}
