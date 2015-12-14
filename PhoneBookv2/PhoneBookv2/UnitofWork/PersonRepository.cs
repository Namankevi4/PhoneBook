using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBookv2.UnitofWork
{
    public class PersonRepository: IRepository<Person>
    {
        private readonly PhoneBookContext _model;

        public PersonRepository(PhoneBookContext db)
        {
            _model = db;
        }

        public IEnumerable<Person> GetAll()
        {
            return _model.People;
        }

        public void Load()
        {
            _model.People.Load();
        }

        public BindingList<Person> Binding()
        {
            return _model.People.Local.ToBindingList();
        }

        public Person Get(int id)
        {
            return _model.People.Find(id);
        }

        public void Create(Person item)
        {
            _model.People.Add(item);
        }

        public void Update(Person item)
        {
            _model.Entry(item).State = EntityState.Modified;
        }
        
        public void Delete(int id)
        {
            var p = _model.People.Find(id);
            if (p != null)
            {
                _model.People.Remove(p);
            }
        }
    }
}
