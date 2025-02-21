﻿using DataLayer_POS.Interfaces;
using POS_DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_POS.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public POS_Model _context = null;
        public DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new POS_Model();
            table = _context.Set<T>();
        }
        public GenericRepository(POS_Model _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            //table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Detach(T obj)
        {
            _context.Entry(obj).State=EntityState.Detached;;
        }
    }
}