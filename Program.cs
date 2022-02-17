People people = new People("Daniel Joanol", 98312344, "Paseo de los Deportistas", "joanol@daniel.com", true);
Console.WriteLine(people);

public struct People{

    public People(string name, int phone, string address, string email, bool newClient){
        Name = name;
        Phone = phone;
        Address = address;
        Email = email;
        NewClient = newClient;
    }

    public string Name { get;}
    public int Phone { get;}
    public string Address { get;}
    public string Email { get;}
    public bool NewClient { get;}

    public override string ToString() => $"Name: {Name} - Phone: {Phone} - Address: {Address} - Email: {Email} - NewClient: {NewClient}";
}