using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmLightTestProject.Model
{
    public interface IDataService
    {
        List<Contact> GetContacts();

    }
}
