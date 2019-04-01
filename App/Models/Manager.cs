namespace InheritanceDiner.Models
{
  class Manager : Supervisor
  {
    int PinCode { get; set; }
    public void TerminateEmployee()
    {

    }
    public void HireEmployee()
    {

    }
    public override void Discount()
    {
      System.Console.WriteLine("A 50% Discount!!");
    }
    public void Delegate()
    {
      System.Console.WriteLine("Do my work");
    }

    public Manager(string name, string id, int pin) : base(name, id)
    {
      PinCode = pin;
    }
  }
}