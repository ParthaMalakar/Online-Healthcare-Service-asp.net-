﻿using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class HospitalRepo : IRepo<Hospital, int, Hospital>
    {

        HealthcareEntities db;
        internal HospitalRepo()
        {
            db = new HealthcareEntities();
        }
        public Hospital Add(Hospital obj)
        {
            db.Hospitals.Add(obj);
            if (db.SaveChanges() > 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            var dbobj = Get(id);
            db.Hospitals.Remove(dbobj);
            return db.SaveChanges() > 0;
        }

        public List<Hospital> Get()
        {
            return db.Hospitals.ToList();
        }

        public Hospital Get(int id)
        {
            return db.Hospitals.Find(id);
        }

        public Hospital Update(Hospital obj)
        {
            var dbobbj = db.Hospitals.Find(obj.Id);
            db.Entry(dbobbj).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
