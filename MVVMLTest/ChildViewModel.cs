using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLTest
{
    public class ChildViewModel : ViewModelBase
    {
        public ChildViewModel()
        {

            Messenger.Default.Register<Amessage>(this, (action) => ReceiveAMessage(action));
        }

        private void ReceiveAMessage(Amessage msg)
        {
            Console.WriteLine(msg);
        }
    }
}
