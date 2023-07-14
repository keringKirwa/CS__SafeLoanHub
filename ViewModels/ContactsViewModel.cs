using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;

namespace LoginApp.ViewModels;

public class ContactsViewModel : ObservableObject
{
    public event PropertyChangedEventHandler PropertyChanged;

    private ObservableCollection<Contact> _contacts;
    

    private ObservableCollection<Contact> Contacts
    {
        get => _contacts;
        set
        {
            _contacts = value;
            OnPropertyChanged(nameof(Contacts));
        }
    }
    
    
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
    public void AddContact(Contact contact)
    {
        Contacts.Add(contact);
    }

    public void RemoveContact(Contact contact)
    {
        Contacts.Remove(contact);
    }
    
}