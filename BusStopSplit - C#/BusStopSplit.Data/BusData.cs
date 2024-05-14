using BusStopSplit.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

//Kod koji prikazuje kako su se prije razvrstavali autobusi, postoji još u projektu kako bi članovi povjerenstva mogli vidjeti kako je kod napredovao

namespace BusStopSplit.Data
{
    public interface IBusData
    {
        IEnumerable<BusProperties> GetAll();
    }

    public class InMemoryBusData : IBusData
    {
        readonly List<BusProperties> busProperties;

        public InMemoryBusData()
        {
            busProperties = new List<BusProperties>()
            {
                new BusProperties { Id = 1, Name = "STARINE HNK", Network = BusNetwork.Zone2},
                new BusProperties { Id = 6, Name = "KILA - HNK", Network = BusNetwork.Zone1},
                new BusProperties { Id = 7, Name = "ŽNJAN - ZVONČAC - ŽNJAN", Network = BusNetwork.Zone1},
                new BusProperties { Id = 8, Name = "ŽNJAN - TRŽNICA - ZVONČAC - TRŽNICA - ŽNJAN", Network = BusNetwork.Zone1},
                new BusProperties { Id = 9, Name = "RAVNE NJIVE - TR.LUKA - RAVNE NJIVE", Network = BusNetwork.Zone1},
                new BusProperties { Id = 15, Name = "DUILOVO - ŽNJAN - TR. LUKA - DUILOVO", Network = BusNetwork.Zone1},
                new BusProperties { Id = 16, Name = "NINČEVIĆI - HNK - NINČEVIĆI", Network = BusNetwork.Zone2},
                new BusProperties { Id = 18, Name = "BRNIK - HNK - BRNIK", Network = BusNetwork.Zone1},
                new BusProperties { Id = 35, Name = "SPLIT - KOPRIVNO", Network = BusNetwork.Zone3},
                new BusProperties { Id = 37, Name = "SPLIT - AIRPORT - TROGIR", Network = BusNetwork.Zone4},
                new BusProperties { Id = 60, Name = "SPLIT - OMIŠ - RAVNIČKI MOST", Network = BusNetwork.Zone4}
            };
        }

        public IEnumerable<BusProperties> GetAll()
        {
            return from b in busProperties
                   orderby b.Id
                   select b;
        }
    }
}
