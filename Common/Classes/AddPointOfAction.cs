using Common.Enum;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Classes
{
    public class AddPointOfAction : IAddPointOfAction
    {
        
        //Behövs Id för denna? Räcker med id för PointOfAction?
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; }
        public int PointOfActionId { get; }

        public string Description { get; }
        public string Category { get; }
        public string Accountable { get; }
        public string Project { get; }
        public ActionPointStatuses Status { get; }
        public DateTime ActionDate { get; }

        //För att kunna spara när handlingspunkten är avklarad
        public DateTime ActionDateDone { get; }

        public AddPointOfAction(int id, string description, string category, string project)
        {
            if (id < 0 || description == string.Empty || category == string.Empty || project == string.Empty)
                throw new AggregateException();

            Id = id;
            //Vet inte varför det inte funkar.....
            //PointOfActionId = pointOfAction.Id;
            Description = description;
            Category = category;
            Project = project;
            ActionDate = DateTime.Now;


        }


        public void FinishedPointOfAction(IPointOfAction pointOfAction)
        {
            throw new NotImplementedException();
        }
    }
}
