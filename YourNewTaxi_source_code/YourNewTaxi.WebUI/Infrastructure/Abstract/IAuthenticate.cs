using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourNewTaxi.WebUI.Infrastructure.Abstract
{
    public interface IAuthenticate
    {
        bool Authenticate(string username, string password);
    }
}
