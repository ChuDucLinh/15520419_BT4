using Projmvvm_FlowerOnline.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projmvvm_FlowerOnline.Helpers
{
    public  class Database
    {  string folder = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);
        public Database()
        {
            try
            {
                //tạo csdl
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    //tạo 2 bang
                    connection.CreateTable<Loaihoa>();
                    connection.CreateTable<Hoa>();      
                }
            }
            catch (SQLiteException ex)
            {
                //Log.Info("SQLiteEx", ex.Message);   
            }
        }
        #region "Xử lý Hoa"
        public List<Hoa> GetHoas()
        {
            try
            {
                using (var connection = new SQLiteConnection
                    (System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<Hoa>().ToList();
                }
            }
            catch (SQLiteException ex)
            {

                return null;
            }
        }
        public List<Hoa> GetHoasByLoai(int MaLoai)
        {
            try
            {
                using (var connection = new SQLiteConnection
                    (System.IO.Path.Combine(folder, "qlhoa.db")))
                {

                    var dsh = from lhs in connection.Table<Hoa>().ToList()
                              where lhs.Maloai == MaLoai
                              select lhs
                          ;
                    return dsh.ToList<Hoa>();
                }
            }
            catch (SQLiteException ex)
            {

                return null;
            }
        }
        public Hoa GetHoasById(int Mahoa)
        {
            try
            {
                using (var connection = new SQLiteConnection
                    (System.IO.Path.Combine(folder, "qlhoa.db")))
                {

                    var dsh = from lhs in connection.Table<Hoa>().ToList()
                              where lhs.Mahoa == Mahoa
                              select lhs
                          ;
                    return dsh.ToList<Hoa>().FirstOrDefault();
                }
            }
            catch (SQLiteException ex)
            {

                return null;
            }
        }
        public bool InsertHoa(Hoa h)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(h);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //   Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public bool UpdateHoa(Hoa h)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Update(h);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //   Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public bool DeleteHoa(Hoa h)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Delete(h);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //   Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        #endregion
        #region "Loại Hoa"
        public List<Loaihoa> GetLoaihoas()
        {
            try
            {
                using (var connection = new SQLiteConnection
                    (System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    return connection.Table<Loaihoa>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                //Log.Info("SQLiteEx", ex.Message);
                return null;
            }
        }
        public Loaihoa GetLoaihoaByid(int Maloai)
        {
            try
            {
                using (var connection = new SQLiteConnection
                    (System.IO.Path.Combine(folder, "qlhoa.db")))
                {

                    var dsh = from lhs in connection.Table<Loaihoa>().ToList()
                              where lhs.Maloai == Maloai
                              select lhs
                          ;
                    return dsh.ToList<Loaihoa>().FirstOrDefault();
                }
            }
            catch (SQLiteException ex)
            {

                return null;
            }
        }
        public bool InsertLoaihoa(Loaihoa lh)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Insert(lh);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //   Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public bool UpdateLoaihoa(Loaihoa h)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Update(h);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //   Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public bool DeleteLoaihoa(Loaihoa h)
        {
            try
            {
                using (var connection = new
                    SQLiteConnection(System.IO.Path.Combine(folder, "qlhoa.db")))
                {
                    connection.Delete(h);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                //   Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        #endregion
    }
}
