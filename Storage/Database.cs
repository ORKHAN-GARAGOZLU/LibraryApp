using LibraryApp.Library;
using LibraryApp.Storage.IIdentity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Storage
{
    [Serializable]
    public class Database
    {
        public GenericStore<Authors> Author { get; set; }
        public GenericStore<Books> Book { get; set; }
    }
}
