using Projmvvm_FlowerOnline.Helpers;
using Projmvvm_FlowerOnline.Interface;
using Projmvvm_FlowerOnline.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Projmvvm_FlowerOnline.Repository
{
    public class LoaihoaRepository : ILoaihoaRepository
    {
        Database db;
        public LoaihoaRepository()
            {
            db = new Database();
        }
        public bool Delete(Loaihoa h)
        {
            return db.DeleteLoaihoa(h);
        }

        public Loaihoa GetLoaihoaById(int Maloai)
        {
            return db.GetLoaihoaByid(Maloai);
        }

        public ObservableCollection<Loaihoa> GetLoaihoas()
        {
            return new ObservableCollection<Loaihoa>( db.GetLoaihoas());
        }

        public bool Insert(Loaihoa h)
        {
            return db.InsertLoaihoa(h);
        }

        public bool Update(Loaihoa h)
        {
            return db.UpdateLoaihoa(h);
        }
    }
}
