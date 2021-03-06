using System.Collections.Generic;
using TigerTix.Web.Data.Entities;

namespace TigerTix.Web.Data
{
    public interface IEventRepository
    {
        void DeleteEvent(Event ev);
        IEnumerable<Event> GetAllEvents();
        void SaveEvent(Event ev);
        void UpdateEvent(Event ev);
        bool SaveAll();
    }
}