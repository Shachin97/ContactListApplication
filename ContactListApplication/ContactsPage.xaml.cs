namespace ContactListApplication;

public partial class ContactsPage : ContentPage
{

    public List<ContactGroup> contacts = new List<ContactGroup>();
    
    public ContactsPage()
	{
		InitializeComponent();

        contacts.Add(new ContactGroup("A", new List<Contacts>
          {
            new Contacts{Name = "Abby McMahon", ImageName ="Pic1.png", Email = "Email: AbbyMcMahon@outlook.com", PhoneNumber = "Phone: (123)542-1246", Description = "Description: We have one class together. Abby is a great friend."},
            new Contacts{Name = "Alex Matthews",ImageName ="Pic2.png", Email = "Email: AlexMcMahon@outlook.com", PhoneNumber = "Phone: (212)456-3415", Description = "Description: Alex is a great friend."},
            new Contacts{Name = "Andre Adams",ImageName ="Pic3.png", Email = "Email: AndreMcMahon@outlook.com", PhoneNumber = "Phone: (624)124-1241", Description = "Description: Andre is a great friend."},
            new Contacts{Name = "Abdul Gill", ImageName = "Pic4.png", Email = "Email: AbdulMcMahon@outlook.com", PhoneNumber = "Phone: (651)172-6345", Description = "Description: Abdul is a great friend."},
            new Contacts{Name = "Alec Smith", ImageName = "Pic1.png", Email = "Email: AlecMcMahon@outlook.com", PhoneNumber = "Phone: (325)456-9108", Description = "Description: Alec is a great friend."}


        }));
        contacts.Add(new ContactGroup("B", new List<Contacts>
        {

                new Contacts{Name = "Brandon Smith", ImageName="Pic2.png", Email = "Email: BrandonMcMahon@outlook.com", PhoneNumber = "Phone: (325)456-9108", Description = "Description: Brandon is a great friend."},
                new Contacts{Name = "Bailey Adams", ImageName="Pic3.png", Email = "Email: Bailey@outlook.com", PhoneNumber = "Phone: (423)456-1245", Description = "Description: Bailey is a great friend."},
                new Contacts{Name = "Blake Smith", ImageName="Pic4.png", Email = "Email: Blake@outlook.com", PhoneNumber = "Phone: (234)523-124", Description = "Description: Blake is a great friend."},
                new Contacts{Name = "Brock McMahon", ImageName="Pic1.png", Email = "Email: Brock@outlook.com", PhoneNumber = "Phone: (124)456-1461", Description = "Description: Brock is a great friend."},
                new Contacts{Name = "Brandyn Gill", ImageName="Pic2.png", Email = "Email: Brandyn@outlook.com", PhoneNumber = "Phone: (531)512-3511", Description = "Description: Brandyn is a great friend."}


        }));
        contacts.Add(new ContactGroup("C", new List<Contacts>
        {

                new Contacts{Name = "Carson Gill", ImageName = "Pic3.png", Email = "Email: CarsonM@outlook.com", PhoneNumber = "Phone: (325)456-9108", Description = "Description: Carson is a great friend."},
                new Contacts{Name = "Carly McMahon", ImageName = "Pic4.png", Email = "Email: Carly@outlook.com", PhoneNumber = "Phone: (325)456-9108", Description = "Description: Carly is a great friend."},
                new Contacts{Name = "Catalina  Matthews", ImageName = "Pic1.png", Email = "Email: Catalina@outlook.com", PhoneNumber = "Phone: (325)456-9108", Description = "Description: Cat is a great friend."},
                new Contacts{Name = "Cayla Smith", ImageName = "Pic2.png", Email = "Email: Cayla@outlook.com", PhoneNumber = "Phone: (325)456-9108", Description = "Description: Cayla is a great friend."},
                new Contacts{Name = "Cale McMahon", ImageName = "Pic3.png", Email = "Email: Cale@outlook.com", PhoneNumber = "Phone: (325)456-9108", Description = "Description: Cale is a great friend."}
        }));


        contacts.Add(new ContactGroup("D", new List<Contacts>
        {

                new Contacts{Name = "Dylan McMahon",  ImageName = "Pic4.png", Email = "Email: DylanMcMahon@outlook.com", PhoneNumber = "Phone: (325)456-9108", Description = "Description: Dylan is a great friend."},
                new Contacts{Name = "Dayton Smith", ImageName = "Pic1.png", Email = "Email: Dayton@outlook.com", PhoneNumber = "Phone: (242)456-2662", Description = "Description: Dayton is a great friend."},
                new Contacts{Name = "Daren Gill", ImageName = "Pic2.png", Email = "Email: Daren@outlook.com", PhoneNumber = "Phone: (126)456-3512", Description = "Description: Daren is a great friend."},
                new Contacts{Name = "Devan McMahon", ImageName = "Pic3.png", Email = "Email: Devan@outlook.com", PhoneNumber = "Phone: (161)456-6134", Description = "Description: Davan is a great friend."},
                new Contacts{Name = "Dean Matthews", ImageName = "Pic4.png", Email = "Email: Dean@outlook.com", PhoneNumber = "Phone: (168)416-1723", Description = "Description: Dean is a great friend."}
        }));

        contacts.Add(new ContactGroup("E", new List<Contacts>
        {
                new Contacts{Name = "Ethan Matthews", ImageName = "Pic1.png", Email = "Email: EthanMcMahon@outlook.com", PhoneNumber = "Phone: (461)455-6108", Description = "Description: Ethan is a great friend."},
                new Contacts{Name = "Emilano McMahon", ImageName="Pic2.png", Email = "Email: Emilano@outlook.com", PhoneNumber = "Phone: (515)456-9108", Description = "Description: Emilano is a great friend."},
                new Contacts{Name = "Eden Smith", ImageName="Pic3.png",Email = "Email: Eden@outlook.com", PhoneNumber = "Phone: (767)456-5341", Description = "Description: Eden is a great friend."},
                new Contacts{Name = "Elis McMahon",ImageName="Pic4.png", Email = "Email: Elis@outlook.com", PhoneNumber = "Phone: (614)426-9108", Description = "Description: Elis is a great friend."},
                new Contacts{Name = "Erick Gill",ImageName="Pic1.png", Email = "Email: Erick@outlook.com", PhoneNumber = "Phone: (356)262-3625", Description = "Description: Erick is a great friend."}

        }));



        ContactsCV.ItemsSource = contacts;

    }

    private void ContactsCV_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedContact = e.CurrentSelection.FirstOrDefault() as Contacts;
        if (selectedContact == null)
            return;

        Navigation.PushAsync(new ContactDetailsPage(selectedContact));
        ((CollectionView)sender).SelectedItem = null;

    }

   
}