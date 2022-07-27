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
        #region Багет

        IEnumerable<Frame> frames;
        /// <summary> Багет </summary>
        public IEnumerable<Frame> Frames
        {
            get { return frames; }
            set => Set(ref frames, value);

        }
        #endregion

        #region Загрузка сущности "Багет" из БД

        FramingWorkshopContext db;
        public FrameVM()
        {
            db = new FramingWorkshopContext();
            //db.Frames.Load();
            //Frames = db.Frames.Local.ToBindingList();
        }
        #endregion

        #region Команда добавления багета в БД

        RelayCommand addCommand;
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
        #endregion

        #region Команда редактирования багета

        RelayCommand editCommand;
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
        #endregion

        #region Команда удаления багета из БД

        RelayCommand deletCommand;
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
        #endregion

    }
}
