namespace InheritanceDiner.Models
{
  class Server
  {
    public string Name { get; set; }
    public string Id { get; set; }

    public void ClockIn()
    {

    }

    public void ClockOut()
    {

    }

    public void CreateTicket()
    {

    }

    public Server(string name, string id)
    {
      Name = name;
      Id = id;
    }
  }
}