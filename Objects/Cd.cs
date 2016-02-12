using Nancy;
using System.Collections.Generic;
using Cd.Objects;

namespace Cd.Objects
{
  public class Cd
  {
      private string _title;
      private static List<Cd> _instances = new List<Cd> {};

    public Cd (string title)
    {
      _title = title;
      _instances.Add(this);
    }

    public string GetName()
    {
      return _title;
    }
    public string SetName()
    {
      _title = title;
    }

    public static List<Cd> GetAll()
    {
      return _instances;
    }
  }
}
