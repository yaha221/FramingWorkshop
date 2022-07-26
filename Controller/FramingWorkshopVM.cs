using FramingWorkshop.Models;
using FramingWorkshop.View;
using System.Data.Entity;

namespace FramingWorkshop.Controller
{
    internal class FramingWorkshopVM:ViewModel
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
    }
}
