using System.Collections.Generic;

namespace Cd.Objects
{
  public class Artist
{
  private static List<Artist> _artists = new List<Artist>{};
  private string _name;
  private int _id;
  private List<Cd> _cds= new List<Cd> {};

  public Artist(string artistname)
  {
    _name = artistname;
    _artists.add(this);
    _id = artists.Count;
    _cds = new List<Cd>{};
  }

  public string GetName()
  {
    return _name;
  }

  public int GetId()
  {
    return _id;
  }

  public List<cds> GetCds()
  {
    return _cds;
  }

  public static List<Artist> GetAll()
  {
    return _artists;
  }

  public static Artist Find(int searchId)
  {
    return _instances[searchId - 1];
  }
}
}
