using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestTask2
{
    /// <summary>
    /// Interaction logic for FamilyDataChange.xaml
    /// </summary>
    public partial class FamilyDataChange : Window, INotifyPropertyChanged
    {
        private string familyName;
        private string parameterName;
        public string FamilyName 
        { 
            get { return familyName; }
            set
            {
                familyName = FamilyName;
                OnPropertyChanged("FamilyName");
            }
        }
        public string ParameterName
        {
            get { return parameterName; }
            set
            {
                parameterName = ParameterName;
                OnPropertyChanged("ParameterName");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
