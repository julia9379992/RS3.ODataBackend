﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.RS_3
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Объект строит.
    /// </summary>
    //  *** Start programmer edit section *** (ОбъектСтроит CustomAttributes)

    //  *** End programmer edit section *** (ОбъектСтроит CustomAttributes)
    [AutoAltered()]
    [Caption("Объект строит")]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ОбъектСтроитE", new string[] {
            "Наименование as \'Наименование\'",
            "Адрес as \'Адрес\'"})]
    public class ОбъектСтроит : ICSSoft.STORMNET.DataObject
    {
        
        private string fНаименование;
        
        private string fАдрес;
        
        private IIS.RS_3.РазрешНаСтроит fРазрешение;
        
        //  *** Start programmer edit section *** (ОбъектСтроит CustomMembers)

        //  *** End programmer edit section *** (ОбъектСтроит CustomMembers)

        
        /// <summary>
        /// Наименование.
        /// </summary>
        //  *** Start programmer edit section *** (ОбъектСтроит.Наименование CustomAttributes)

        //  *** End programmer edit section *** (ОбъектСтроит.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                //  *** Start programmer edit section *** (ОбъектСтроит.Наименование Get start)

                //  *** End programmer edit section *** (ОбъектСтроит.Наименование Get start)
                string result = this.fНаименование;
                //  *** Start programmer edit section *** (ОбъектСтроит.Наименование Get end)

                //  *** End programmer edit section *** (ОбъектСтроит.Наименование Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (ОбъектСтроит.Наименование Set start)

                //  *** End programmer edit section *** (ОбъектСтроит.Наименование Set start)
                this.fНаименование = value;
                //  *** Start programmer edit section *** (ОбъектСтроит.Наименование Set end)

                //  *** End programmer edit section *** (ОбъектСтроит.Наименование Set end)
            }
        }
        
        /// <summary>
        /// Адрес.
        /// </summary>
        //  *** Start programmer edit section *** (ОбъектСтроит.Адрес CustomAttributes)

        //  *** End programmer edit section *** (ОбъектСтроит.Адрес CustomAttributes)
        [StrLen(255)]
        public virtual string Адрес
        {
            get
            {
                //  *** Start programmer edit section *** (ОбъектСтроит.Адрес Get start)

                //  *** End programmer edit section *** (ОбъектСтроит.Адрес Get start)
                string result = this.fАдрес;
                //  *** Start programmer edit section *** (ОбъектСтроит.Адрес Get end)

                //  *** End programmer edit section *** (ОбъектСтроит.Адрес Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (ОбъектСтроит.Адрес Set start)

                //  *** End programmer edit section *** (ОбъектСтроит.Адрес Set start)
                this.fАдрес = value;
                //  *** Start programmer edit section *** (ОбъектСтроит.Адрес Set end)

                //  *** End programmer edit section *** (ОбъектСтроит.Адрес Set end)
            }
        }
        
        /// <summary>
        /// мастеровая ссылка на шапку IIS.RS_3.РазрешНаСтроит.
        /// </summary>
        //  *** Start programmer edit section *** (ОбъектСтроит.Разрешение CustomAttributes)

        //  *** End programmer edit section *** (ОбъектСтроит.Разрешение CustomAttributes)
        [Agregator()]
        [NotNull()]
        public virtual IIS.RS_3.РазрешНаСтроит Разрешение
        {
            get
            {
                //  *** Start programmer edit section *** (ОбъектСтроит.Разрешение Get start)

                //  *** End programmer edit section *** (ОбъектСтроит.Разрешение Get start)
                IIS.RS_3.РазрешНаСтроит result = this.fРазрешение;
                //  *** Start programmer edit section *** (ОбъектСтроит.Разрешение Get end)

                //  *** End programmer edit section *** (ОбъектСтроит.Разрешение Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (ОбъектСтроит.Разрешение Set start)

                //  *** End programmer edit section *** (ОбъектСтроит.Разрешение Set start)
                this.fРазрешение = value;
                //  *** Start programmer edit section *** (ОбъектСтроит.Разрешение Set end)

                //  *** End programmer edit section *** (ОбъектСтроит.Разрешение Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ОбъектСтроитE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОбъектСтроитE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОбъектСтроитE", typeof(IIS.RS_3.ОбъектСтроит));
                }
            }
        }
    }
    
    /// <summary>
    /// Detail array of ОбъектСтроит.
    /// </summary>
    //  *** Start programmer edit section *** (DetailArrayDetailArrayOfОбъектСтроит CustomAttributes)

    //  *** End programmer edit section *** (DetailArrayDetailArrayOfОбъектСтроит CustomAttributes)
    public class DetailArrayOfОбъектСтроит : ICSSoft.STORMNET.DetailArray
    {
        
        //  *** Start programmer edit section *** (IIS.RS_3.DetailArrayOfОбъектСтроит members)

        //  *** End programmer edit section *** (IIS.RS_3.DetailArrayOfОбъектСтроит members)

        
        /// <summary>
        /// Construct detail array.
        /// </summary>
        /// <summary>
        /// Returns object with type ОбъектСтроит by index.
        /// </summary>
        /// <summary>
        /// Adds object with type ОбъектСтроит.
        /// </summary>
        public DetailArrayOfОбъектСтроит(IIS.RS_3.РазрешНаСтроит fРазрешНаСтроит) : 
                base(typeof(ОбъектСтроит), ((ICSSoft.STORMNET.DataObject)(fРазрешНаСтроит)))
        {
        }
        
        public IIS.RS_3.ОбъектСтроит this[int index]
        {
            get
            {
                return ((IIS.RS_3.ОбъектСтроит)(this.ItemByIndex(index)));
            }
        }
        
        public virtual void Add(IIS.RS_3.ОбъектСтроит dataobject)
        {
            this.AddObject(((ICSSoft.STORMNET.DataObject)(dataobject)));
        }
    }
}
