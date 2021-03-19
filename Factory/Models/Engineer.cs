using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int EngineerId { get; set; }
    public string Name { get; set; }
    public int HourlyRate { get; set; }
    public DateTime HireDate { get; set; }
    public string PhoneNumber { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}