using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Classes
{
    public class DayEvent
    {
        public int DayEventId { get; set; }
        public string Note { get; set; }
        public DateTime EventDate { get; set; } = new DateTime(1990, 1, 1);

        public DateTime FromDate { get; set; } = new DateTime(1990, 1, 1);
        public DateTime ToDate { get; set; } = new DateTime(1990, 1, 1);
        public string DateValue { get; set; }
        public string DayName { get; set; }
        public string Message { get; set; }
        //public string Safety { get; set; }

        public SQLMO SQLMO { get; set; } //Association 

        public int SQLMO_Id { get; set; } //Foreign Key 

        public ActionsOfTheDay ActionsOfTheDay { get; set; } //Association 

        public int Actions_Id { get; set; } //Foreign Key  

        #region SQLMO 
        public Safety Safety { get; set; } //Association 

        public int Safety_Id { get; set; } //Foreign Key  

        public Delivery Delivery { get; set; } //Association 

        public int Delivery_Id { get; set; } //Foreign Key 

        public Material Material { get; set; } //Association 

        public int Material_Id { get; set; } //Foreign Key 

        public Quality Quality { get; set; } //Association 

        public int Quality_Id { get; set; } //Foreign Key

        public Tidy Tidy { get; set; } //Association 

        public int Tidy_Id { get; set; } //Foreign Key
        #endregion

    }
} 
 