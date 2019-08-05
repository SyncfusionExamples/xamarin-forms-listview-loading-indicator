using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sample
{
    public class ViewModel:INotifyPropertyChanged
    {
        #region Fields

        public ObservableCollection<Model> ContactInfo { get; set; }
        private bool isLoading = false;

        string[] CustomerNames = new string[] {
          "Object-Oriented Programming in C#",
            "C# Code Contracts",
            "Machine Learning Using C#",
            "Neural Networks Using C#",
            "Visual Studio Code",
            "Android Programming",
            "iOS Succinctly",
            "Visual Studio 2015",
            "Xamarin.Forms",
            "Windows Store Apps",
            "Agile Software Development",
            "Assembly Language",
            "Cryptography in .NET",
            "Entity Framework Code First",
            "Localization for .NET",
            "Developing Windows Services",
            "Data Structures",
            "Objective-C",
            "SciPy Programming",
            "Python Succinctly",
            "Object-Oriented Programming in C#",
            "C# Code Contracts",
            "Machine Learning Using C#",
            "Neural Networks Using C#",
            "Visual Studio Code",
            "Visual Studio 2015",
            "Xamarin.Forms",
            "Windows Store Apps",
            "Agile Software Development",
            "Assembly Language",
            "Cryptography in .NET",
            "Entity Framework Code First",
            "Localization for .NET",
            "Developing Windows Services",
            "Data Structures",
            "Objective-C",
            "SciPy Programming",
            "Python Succinctly",
              "Agile Software Development",
            "Assembly Language",
            "Cryptography in .NET",
            "Entity Framework Code First",
            "Localization for .NET",
            "Developing Windows Services",
            "Data Structures",
            "Objective-C",
            "SciPy Programming",
            "Python Succinctly"
        };

        string[] ContactNumber = new string[] {
            "Object-oriented programming is the de facto programming paradigm for many programming languages Microsoft Visual Studio 2015 is the new version of the widely-used integrated development environment for building modern.",
                "Code Contracts provide a way to convey code assumptions in your .NET applications, Neural networks are an exciting field of software development used to calculate outputs from input data.",
                   "Object-oriented programming is the de facto programming paradigm for many programming languages Microsoft Visual Studio 2015 is the new version of the widely-used integrated development environment for building modern.",
                "Code Contracts provide a way to convey code assumptions in your .NET applications, Neural networks are an exciting field of software development used to calculate outputs from input data.",
                "You’ll learn several different approaches to applying machine learning to data analysis.",
                "Neural networks are an exciting field of software development used to calculate outputs from input data.",
                "It is a powerful tool for editing code and serves as a complete environment for end-to-end programming.",
                "In Android Programming Succinctly, Ryan Hodson provides a useful overview of the Android application lifecycle.",
                "iOS Succinctly is for developers looking to step into the sometimes frightening world of iPhone and iPad app development.",
                "Microsoft Visual Studio 2015 is the new version of the widely-used integrated development environment for building modern.",
                "Xamarin.Forms creates mappings from its C# classes and controls directly to the native platform APIs and controls.",
                "Windows Store apps present a radical shift in Windows development, With Windows Store Apps by John Garland.",
                "Learning new development processes can be difficult, but switching to Agile doesn’t need to be complicated.",
                "Assembly language is as close to writing machine code as you can get without writing in pure hexadecimal.",
                "Cryptography is used throughout software to protect all kinds of information, from emails, to passwords to credit card data.",
                "Follow author Ricardo Peres as he introduces the newest development mode for Entity Framework, Code First.",
                "Learn to write applications that support different languages and cultures, with an emphasis on .NET development.",
                "Learn the basics of Windows Services and how to develop and deploy basic apps with Author by José Roberto Olivas Mendoza.",
                "Data Structures is your concise guide to skip lists, hash tables, heaps, priority queues, AVL trees.",
                "Objective-C is the only book you need for getting started with Objective-C—the primary language.",
                "James McCaffrey’s SciPy Programming offers readers a quick, thorough grounding in knowledge of the Python.",
                "Author Jason Cannon will guide to learn to use the Python language to create programs of all kinds.",
                "Learning new development processes can be difficult, but switching to Agile doesn’t need to be complicated.",
                "Assembly language is as close to writing machine code as you can get without writing in pure hexadecimal.",
                "Cryptography is used throughout software to protect all kinds of information, from emails, to passwords to credit card data.",
                "Follow author Ricardo Peres as he introduces the newest development mode for Entity Framework, Code First.",
                "Learn to write applications that support different languages and cultures, with an emphasis on .NET development.",
                "Learn the basics of Windows Services and how to develop and deploy basic apps with Author by José Roberto Olivas Mendoza.",
                "Data Structures is your concise guide to skip lists, hash tables, heaps, priority queues, AVL trees.",
                "Objective-C is the only book you need for getting started with Objective-C—the primary language.",
                "James McCaffrey’s SciPy Programming offers readers a quick.",
                "Author Jason Cannon will guide to learn to use the Python language to create programs of all kinds to use the Python language to create programs of all kinds."
        };

        #endregion

        #region Properties

        public bool IsLoading
        {
            get { return isLoading; }
            set
            {
                this.isLoading = value;
                OnPropertyChanged("IsLoading");
            }
        }

        #endregion

        #region Constructor

        public ViewModel()
        {
            ContactInfo = new ObservableCollection<Model>();
            GenerateItems();
        }

        #endregion

        #region Private Methods

        private async void GenerateItems()
        {

            IsLoading = true;
            await Task.Delay(5000);
            for (int i = 0; i < 30; i++)
            {
                var contact = new Model(CustomerNames[i], ContactNumber[i]);
                ContactInfo.Add(contact);
            }
            IsLoading = false;
        }

        #endregion

        #region Interface Methods

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion

       
    }
}
