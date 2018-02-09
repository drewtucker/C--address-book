using System.Collections.Generic;
namespace AddressBook.Models
{
  public class Address
  {
    private string _street;
    private string _city;
    private string _state;
    private int _zipCode;

    public Address(string street, string city, string state, int zipCode)
    {
      _street = street;
      _city = city;
      _state = state;
      _zipCode = zipCode;
    }

    public string GetStreet()
    {
      return _street;
    }

    public void SetStreet()
    {
      _street = street;
    }

    public string GetCity()
    {
      return _city;
    }

    public void SetCity()
    {
      _city = city;
    }

    public string GetState()
    {
      return _state;
    }

    public void SetState()
    {
      _state = state;
    }

    public int GetZipCode()
    {
      return _zipCode;
    }

    public void SetZipCode()
    {
      _zipCode = zipCode;
    }
  }
}
