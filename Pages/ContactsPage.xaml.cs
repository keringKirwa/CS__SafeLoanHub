using LoginApp.Models;
using LoginApp.ViewModels;

namespace LoginApp.Pages;

public partial class ContactsPage : ContentPage
{
    public ContactsPage(ContactsViewModel contactsViewModel)
    {
        InitializeComponent();
        OnSetUpViewModelData(contactsViewModel);
        BindingContext = contactsViewModel;
        
    }

    private void Login_Button_OnClicked(object sender, EventArgs e)
    {
        
        throw new NotImplementedException();
    }
    private static void OnSetUpViewModelData(ContactsViewModel contactsViewModel)
    {
        contactsViewModel.ApplicationContacts.Add(new ApplicationContact
        {
            EmailAddress = "kelvinkering@gmail.com",
            Name = "kelvin kering",
            PhoneNumber = "+254636364848"
        });
        
        contactsViewModel.ApplicationContacts.Add(new ApplicationContact
        {
            EmailAddress = "felix@gmail.com",
            Name = "Felix Omwenga",
            PhoneNumber = "+254693933844"
        });
    }
}