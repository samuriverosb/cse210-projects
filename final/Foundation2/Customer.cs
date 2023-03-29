using System;

public class Customer
{
	private string _name;
	private Address _address;

	public string GetName()
	{
		return _name;
	}
	public void SetName(string name)
	{
		_name = name;
	}
	public Address GetAddress()
	{
		return _address;
	}

	public Customer(string name, Address address)
	{
		_name = name;
		_address = address;
	}

	public bool American()
	{
		return _address.IsAmerican();
	}
}