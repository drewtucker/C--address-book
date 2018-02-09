using System.Collections.Generic;
namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private int _phoneNumber;
    private Address _address;
    private static List<Contact> _contactInstances = new List<Contact> {};

    public Contact(string name, int phoneNumber, Address address)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _address = address;
    }

    
  }
}
