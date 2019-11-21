using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Projmvvm_FlowerOnline.Helpers;
using Projmvvm_FlowerOnline.Interface;
using Projmvvm_FlowerOnline.Models;

namespace Projmvvm_FlowerOnline.Repository
{
    public class HoaRepository : IHoaRepository
    {
        Database db;
        public HoaRepository()
        {
             db = new Database();
        }
        public bool Delete(Hoa h)
        {
            // throw new NotImplementedException();
            return db.DeleteHoa(h);
        }

        public ObservableCollection <Hoa> GetHoas()
        {
            List < Hoa > lsthoa= db.GetHoas();
            return new ObservableCollection<Hoa>(lsthoa);
        }

        public Hoa GetHoasById(int Mahoa)
        {
            Hoa h;
            h = db.GetHoasById(Mahoa);
            return h;
        }

        public ObservableCollection <Hoa> GetHoasByLoai(int Maloai)
        {
            List<Hoa> lsthoa = db.GetHoasByLoai(Maloai);
            return new ObservableCollection<Hoa>(lsthoa);
        }

        public bool Insert(Hoa h)
        {
            // throw new NotImplementedException();
            return db.InsertHoa(h);
        }

        public bool Update(Hoa h)
        {
            // throw new NotImplementedException();
            return db.UpdateHoa(h);
        }
    }
}
