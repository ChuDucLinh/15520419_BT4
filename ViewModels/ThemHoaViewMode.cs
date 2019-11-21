using System;
using System.Collections.Generic;
using System.Text;
using Projmvvm_FlowerOnline.Models;
using System.ComponentModel;
using Projmvvm_FlowerOnline.Interface;
using Projmvvm_FlowerOnline.Repository;
using Xamarin.Forms;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Projmvvm_FlowerOnline.ViewModels
{
  public  class ThemHoaViewMode : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }
        
        public ICommand AddHoa { get; private set; }
        public ILoaihoaRepository loaihoaRepository;
        public IHoaRepository hoaRepository;
        private ObservableCollection<Loaihoa> loaihoas;
        private ObservableCollection<Hoa> dshoa;
        private Loaihoa loaihoa;
        private Hoa hoa;
        public ThemHoaViewMode()
        {
            loaihoaRepository = new LoaihoaRepository();
            hoaRepository = new HoaRepository();
            loaihoas = loaihoaRepository.GetLoaihoas();
            dshoa = hoaRepository.GetHoas();
            loaihoa = new Loaihoa();
            hoa = new Hoa();
            AddHoa = new Command(InsertHoa);
        }
        public ObservableCollection<Loaihoa> Loaihoas
        {
            get { return loaihoas; }
            set { loaihoas = value;
                RaisePropertyChanged("Loaihoas");
            }

        }
        public Loaihoa LoaihoaChon
        {
            get { return loaihoa; }
            set { loaihoa = value;
                hoa.Maloai = loaihoa.Maloai;
                LayHoaTheoLoai();
                RaisePropertyChanged("LoaihoaChon");
            }
        }
        void LayHoaTheoLoai()
        {
            if (LoaihoaChon != null && LoaihoaChon.Maloai > 0)
                DSHOA = hoaRepository.GetHoasByLoai(LoaihoaChon.Maloai);
            else
                DSHOA = hoaRepository.GetHoas();
        }
        public Hoa Hoamoi
        {
            get { return hoa;}
            set { hoa = value;
                RaisePropertyChanged("LoaihoaChon");
            }

        }
        public ObservableCollection<Hoa> DSHOA
        {
            get { return dshoa; }
            set { dshoa = value;
                RaisePropertyChanged("DSHOA");
            }
        }
        public   void InsertHoa()
        {
             hoaRepository.Insert(hoa);
        }
    }
}
