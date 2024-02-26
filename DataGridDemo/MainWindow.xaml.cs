using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DataGridDemo.Models;
using MahApps.Metro.Controls;

namespace DataGridDemo;

public partial class MainWindow : MetroWindow, INotifyPropertyChanged
{
    public ObservableCollection<Person> Persons { get; set; }
    
    public MainWindow()
    {
        Persons = new ObservableCollection<Person>()
        {
            new Person()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "<EMAIL>",
                IsDeleted = false,
                DateOfBirth = new DateTime(1985, 1, 1),
                Gender = Gender.Male
            },
            new Person()
            {
                Id = 2,
                FirstName = "John",
                LastName = "Doe",
                Email = "<EMAIL>",
                IsDeleted = true,
                DateOfBirth = new DateTime(1985, 1, 1),
                Gender = Gender.Male
            },
            new Person()
            {
                Id = 3,
                FirstName = "John",
                LastName = "Doe",
                Email = "<EMAIL>",
                IsDeleted = false,
                DateOfBirth = new DateTime(1985, 1, 1),
                Gender = Gender.Female
            },
            new Person()
            {
                Id = 4,
                FirstName = "John",
                LastName = "Doe",
                Email = "mailto:mail@mail.ru",
                IsDeleted = false,
                DateOfBirth = new DateTime(1985, 1, 1),
                Gender = Gender.Male
            },
        };
        
        InitializeComponent();
    }
    
    #region INotifyPropertyChanged
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
    #endregion
}