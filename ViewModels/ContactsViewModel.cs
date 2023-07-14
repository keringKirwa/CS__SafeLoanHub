using System.Collections.ObjectModel;
using System.ComponentModel;
using LoginApp.Models;


namespace LoginApp.ViewModels;

public sealed class ContactsViewModel : INotifyPropertyChanged
{
    private ObservableCollection<ApplicationContact> _appContacts;

    public ObservableCollection<ApplicationContact> ApplicationContacts
    {
        get => _appContacts; 
        set
        {
            _appContacts = value;
            OnPropertyChanged(nameof(Contacts));
        }
    }
    
    public void AddContact(ApplicationContact contact)
    {
        ApplicationContacts.Add(contact);
    }

    public void RemoveContact(ApplicationContact contact)
    {
        ApplicationContacts.Remove(contact);
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
