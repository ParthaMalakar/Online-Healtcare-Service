using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PatientRepo : IRepo<Patient, int, Patient>,IGetbyemailI<int, string>
    {
        HealthcareEntities1 db;
        internal PatientRepo()
        {
            db = new HealthcareEntities1();
        }
        public Patient Add(Patient obj)
        {
            db.Patients.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Patients.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Patient> Get()
        {
            return db.Patients.ToList();
        }

        public Patient Get(int id)
        {
            return db.Patients.Find(id);
        }

        public Patient Update(Patient obj)
        {
            var dbobbj = db.Patients.Find(obj.Id);
            db.Entry(dbobbj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public int GetByEmail(string id)
        {
            var data = (from a in db.Patients where a.Email == id select a).SingleOrDefault();
            
            return data.Id;
        }
    }
}
