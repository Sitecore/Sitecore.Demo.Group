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
      public static readonly ID ID = new ID("{0579062E-E184-4A84-8A03-CC3E16CFF381}");
      public struct Fields
      {
        public static readonly ID Title = new ID("{CE6B8B5D-B529-4E26-B90B-A76E9C868912}");
        public static readonly ID Description = new ID("{EC9020BE-8498-4DAC-8689-9B2E492F126F}");
        public static readonly ID Date = new ID("{E925DD56-7BEC-4637-B970-565846396F58}");
        public static readonly ID Venue = new ID("{707544E3-A602-45FD-83DB-A4EB6D6CC8D4}");
        public static readonly ID VenueAddress = new ID("{828B4347-732A-4C7C-B8BA-2968720DCC5F}");
      }
    }
  }
}