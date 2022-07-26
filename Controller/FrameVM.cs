using System;
using FramingWorkshop.Models;
using FramingWorkshop.Controller;
using FramingWorkshop.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Runtime.CompilerServices;

namespace FramingWorkshop
{
    internal class FrameVM:ViewModel
    {
        FramingWorkshopContext db;
        RelayCommand addCommand;
        RelayCommand editCommand;
        RelayCommand deletCommand;
        IEnumerable<Frame> frames;

        public IEnumerable<Frame> Frames
        {
            get { return frames; }
            set => Set(ref frames, value);

        }

        public FrameVM()
        {
            db = new FramingWorkshopContext();
            db.Frames.Load();
            Frames = db.Frames.Local.ToBindingList();
        }

        public RelayCommand AddCommand
        {
            get 
            {
                return addCommand ??
                    (addCommand = new RelayCommand((o) =>
                    {
                        FrameWindow frameWindow = new FrameWindow(new Frame());
                        if (frameWindow.ShowDialog() == true)
                        {
                            Frame frame = frameWindow.Frame;
                            db.Frames.Add(frame);
                            db.SaveChanges();
                        }
                    }));
            }
        }

        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ??
                    (editCommand = new RelayCommand((selectedItem) =>
                    {if (selectedItem == null) return;
                        Frame frame = selectedItem as Frame;
                        Frame fr = new Frame()
                        {
                            Id = frame.Id,
                            Title = frame.Title,
                            Correction = frame.Correction,
                            Price = frame.Price,
                            AmountClip = frame.AmountClip
                        };
                        FrameWindow frameWindow = new FrameWindow(fr);
                        if(frameWindow.ShowDialog() == true)
                        {
                            frame = db.Frames.Find(frameWindow.Frame.Id);
                            if(frame != null)
                            {
                                frame.Title = frameWindow.Frame.Title;
                                frame.Price = frameWindow.Frame.Price;
                                frame.Correction = frameWindow.Frame.Correction;
                                frame.AmountClip = frameWindow.Frame.AmountClip;
                                db.Entry(frame).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                        }
                    }));
            }
        }

        public RelayCommand DeleteCommand
        {
            get
            {
                return deletCommand ??
                    (deletCommand = new RelayCommand((selectedItem) =>
                    {
                        if (selectedItem == null) return;
                        Frame frame = selectedItem as Frame;
                        db.Frames.Remove(frame);
                        db.SaveChanges();
                    }));
            }
        }

    }
}
