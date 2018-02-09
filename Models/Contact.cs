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

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public int GetPhoneNumber()
    {
      return _phoneNumber;
    }

    public void SetPhoneNumber(int newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }

    public Address GetAddress()
    {
      return _address;
    }

    public void SaveContact()
    {
      _contactInstances.Add(this);
    }

    public static List<Contact> AllContacts()
    {
      return _contactInstances;
    }

    public static void ClearAll()
    {
      _contactInstances.Clear();
    }


  }
}
