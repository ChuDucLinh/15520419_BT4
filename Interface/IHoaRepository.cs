using Projmvvm_FlowerOnline.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Projmvvm_FlowerOnline.Interface
{
  public  interface IHoaRepository
    {
        ObservableCollection <Hoa> GetHoas();
        ObservableCollection<Hoa> GetHoasByLoai(int Maloai);
       Hoa GetHoasById(int Mahoa);
        bool Insert(Hoa h);
        bool Update(Hoa h);
        bool Delete(Hoa h);

    }
}
