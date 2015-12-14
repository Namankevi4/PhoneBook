using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneBookv2.UnitofWork;
namespace PhoneBookv2
{
    public class Unit_of_Work: IUnit_of_work
    {
        private readonly PhoneBookContext _model = new PhoneBookContext();

        private PersonRepository _personRepository;
        private PhoneRepository _phoneRepository;

        public PersonRepository Persons => _personRepository ?? (_personRepository = new PersonRepository(_model));
        public PhoneRepository Phones => _phoneRepository ?? (_phoneRepository = new PhoneRepository(_model));

        public void Save()
        {
            _model.SaveChanges();
        }

        private bool _disposed = false;

        

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _model.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
