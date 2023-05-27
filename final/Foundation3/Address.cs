using System;
class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _postalCode;
    private string _country;

    public Address(string streetAddress, string city, string state, string postalCode, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _postalCode = postalCode;
        _country = country;
    }
    public string GetAddress()
    {
        return $"{_streetAddress},{_city},{_state},{_postalCode},{_country}";
    }
}