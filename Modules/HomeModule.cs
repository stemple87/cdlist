using Nancy;
using System.Collections.Generic;
using Cd.Objects;

namespace Artist
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/artists"] = _ =>{
        var allArtists = Artist.GetAll();
        return View["artists.cshtml", allArtists];
      };
      Get["/artists/new"] = _ => {
        return View["artist_form.cshtml"];
      };
      Post["/artists/{id}"] = parameters => {
        var newArtist = new Artist(Request.Form["artist-name"]);
        var allArtists = Artist.GetAll();
        return View["artists.cshtml", allArtists];
      };
    }
  }
}
