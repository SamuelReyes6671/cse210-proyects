public class Address{
    private string _street;
    private string _city;
    private string _stateProvince;
    public string _country;


    public Address(string street, string city,string stateProvince,string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;

    }
    public bool IsInUSA()
    {
        return _country.ToLower()=="usa";

    }
    public string GetAddressString()
    {
        return $"{_street}\n{_city}, {_stateProvince}\n{_country}";
        
    }

}   