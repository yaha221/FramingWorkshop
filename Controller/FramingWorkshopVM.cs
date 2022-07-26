using System;
using FramingWorkshop.Models;
using FramingWorkshop.Controller;
using FramingWorkshop.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Runtime.CompilerServices;

namespace FramingWorkshop.Controller
{
    public class FramingWorkshopVM:INotifyPropertyChanged
    {
        FramingWorkshopContext db;
        //IEnumerable<Frame> frames;
        //IEnumerable<Cardboard> cardboards;
        //IEnumerable<Hanger> hangers;
        //IEnumerable<Periphery> peripheries;
        RelayCommand frameEditorCommand;

        //public IEnumerable<Frame> Frames
        //{
        //    get { return frames; }
        //}

        //public IEnumerable<Cardboard> Cardboards
        //{
        //    get { return cardboards; }
        //}

        //public IEnumerable<Hanger> Hangers
        //{
        //    get { return hangers; }
        //}

        //public IEnumerable<Periphery> Peripheries
        //{
        //    get { return peripheries; }
        //}

        public FramingWorkshopVM()
        {
            db = new FramingWorkshopContext();
            db.Frames.Load();
            //db.Hangers.Load();
            //db.Cardboards.Load();
            //db.Peripheries.Load();

        }

        public RelayCommand FrameEditorCommand
        {
            get
            {
                return frameEditorCommand ??
                    (frameEditorCommand = new RelayCommand(o => 
                    {
                        FrameWindow frameWindow = new FrameWindow();
                        frameWindow.Show();
                    }));        
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
