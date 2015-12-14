using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookv2.UnitofWork;
namespace PhoneBookv2
{
    public interface IUnit_of_work: IDisposable
    {
        PersonRepository Persons { get; }
        PhoneRepository Phones { get; }
        void Save();

        void Dispose(bool disposing);

        void Dispose();
    }
}
