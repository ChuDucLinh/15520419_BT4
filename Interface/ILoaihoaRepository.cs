using Projmvvm_FlowerOnline.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Projmvvm_FlowerOnline.Interface
{
   public interface ILoaihoaRepository
    {
        ObservableCollection<Loaihoa> GetLoaihoas();
        Loaihoa GetLoaihoaById(int Maloai);
        bool Insert(Loaihoa h);
        bool Update(Loaihoa h);
        bool Delete(Loaihoa h);
    }
}
