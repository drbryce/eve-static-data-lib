using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace StaticDataHelper
{
  public class DB
  {
    private StaticDataHelper.Model.StaticDataContext db;

    public DB()
    {
      db = new StaticDataHelper.Model.StaticDataContext();
    }

    public List<StaticDataHelper.Model.MapRegions> getMapRegions()
    {
      var query = from regions in db.MapRegions orderby regions.RegionId select regions;
      List<StaticDataHelper.Model.MapRegions> results = new List<StaticDataHelper.Model.MapRegions>();
      foreach (var region in query)
      {
        results.Add(region);
      }

      return results;
    }
    public string getTypeName(long typeID)
    {
      var query = db.InvTypes.Single(iType => iType.TypeId.Equals(typeID));
      //Model.InvTypes results = new StaticDataHelper.Model.InvTypes();

      return query.TypeName;
    }


  }
}

// example
// StaticDataHelper.DB staticData = new StaticDataHelper.DB();
// staticData.getMapRegions().ForEach(o => Console.WriteLine(o.RegionName) );

