using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ImageTest
{
    public class AppViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;


        private string test = "";

        public TestCommand TestCommand { get; set; }

        public AppViewModel()
        {
            TestCommand = new TestCommand(this);
        }

        public string Value
        {
            get
            {
                return test;
            }

            set
            {
                test = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(
                        this,
                        new PropertyChangedEventArgs("Value")
                    );
                }
            }
        }
    }
}
