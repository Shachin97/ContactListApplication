namespace ContactListApplication;

public partial class ContactDetailsPage : ContentPage
{
	public ContactDetailsPage(Contacts person)
	{
		InitializeComponent();

		imageContact.Source = person.ImageName;
		lblName.Text = person.Name;
        lblEmail.Text = person.Email;
        lblPhone.Text = person.PhoneNumber;
		lblDescription.Text = person.Description;


    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}