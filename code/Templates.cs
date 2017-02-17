using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Feature.Events
{
  public struct Templates
  {
    public struct Event
    {
      public static readonly ID ID = new ID("{A3AB6626-250D-44BE-AAED-58B6709B2974}");
      public struct Fields
      {
        public static readonly ID Title = new ID("{1E54C0F4-DABD-4170-9A15-6E961D5C9B51}");
        public static readonly ID Description = new ID("{B8A9919A-D1C7-4A19-99D0-5DF6487EC0CE}");
        public static readonly ID Date = new ID("{CBE19EB7-1945-4469-95A0-E3B0228BCFFA}");
        public static readonly ID Venue = new ID("{BE0311AE-D63A-44A4-A200-5A9414C9425C}");
        public static readonly ID VenueAddress = new ID("{9FAFE359-0256-4986-8D9E-80A785525B25}");
      }
    }
  }