using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLibrary
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "MonopolyService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    public class MonopolyService : IMonopolyService
    {
        public void GoToJail()
        {
            Console.WriteLine("Emanuel and Salih went to jail!");
        }
    }
}
