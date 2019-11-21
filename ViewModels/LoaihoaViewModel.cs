using Projmvvm_FlowerOnline.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Projmvvm_FlowerOnline.Interface;
using Projmvvm_FlowerOnline.Repository;
using System.Windows.Input;
using Xamarin.Forms;

namespace Projmvvm_FlowerOnline.ViewModels
{
    public class LoaihoaViewModel : INotifyPropertyChanged
    {
        private Loaihoa loaihoa;
        ObservableCollection<Loaihoa> loaihoalist;
        public ILoaihoaRepository loaihoaRepository;
        public ICommand AddLoaiHoa { get; private set; }
        public ICommand UpdateLoaiHoa { get; private set; }
        public ICommand DeleteLoaiHoa { get; private set; }
        public ICommand SelectLoaihoa { get; private set; }
        public LoaihoaViewModel()
            {
            loaihoaRepository = new LoaihoaRepository();
            LoadLoaihao();
            AddLoaiHoa = new Command(Insert);
            UpdateLoaiHoa = new Command(Update, CanExe);
            DeleteLoaiHoa = new Command(Delete, CanExe);
            SelectLoaihoa = new Command(ChonLoaiHoa);
            loaihoa = new Loaihoa();
            }

        private void ChonLoaiHoa()
        {
            
        }

        private void Delete()
        {
            loaihoaRepository.Delete(Loaihoa);
            LoadLoaihao();
        }

        private bool CanExe()
        {
            if (Loaihoa == null || Loaihoa.Maloai == 0)
                return false;
            else
                return true;
        }

        private void Update()
        {
            loaihoaRepository.Update(Loaihoa);
            LoadLoaihao();
        }

        public Loaihoa Loaihoa
        {
            get { return loaihoa; }
            set { loaihoa = value;
                RaisePropertyChanged("Loaihoa");
                ((Command)UpdateLoaiHoa).ChangeCanExecute();
                
            }
        }
        private void Insert()
        {
            loaihoaRepository.Insert(loaihoa);
            LoadLoaihao();
        }

        public int Maloai {
            get {return loaihoa.Maloai ; }
            set {loaihoa.Maloai=value ;
                RaisePropertyChanged("Maloai");
            }
        }
        public string Tenloai { get { return loaihoa.Tenloai; }
            set {
                loaihoa.Tenloai = value;
                RaisePropertyChanged("Tenloai");
            } }
        
      
        public ObservableCollection<Loaihoa> Loaihoalist
        {
            get { return loaihoalist; }
            set {
                loaihoalist = value;
                RaisePropertyChanged("Loaihoalist");
            }
        }
        void LoadLoaihao()
        {
            Loaihoalist = loaihoaRepository.GetLoaihoas();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
        }

    }
}
