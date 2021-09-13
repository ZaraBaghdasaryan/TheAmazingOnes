using Common.Enum;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Classes
{
    public class PointOfAction : IPointOfAction
    {
        //Med bara get (inga set) så kan vi tilldela ett värde en gång från construktorn, men kan inte tilldela värden efter det
        public int Id { get; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Accountable { get; set; }
        public string Project { get; set; }
        public ActionPointStatuses Status { get; set; }
        public DateTime ActionDate { get; set; }

        public PointOfAction(int id, string description, string category, string accountable, string project, ActionPointStatuses status, DateTime actionDate)
        {
            //Måste skicka in dessa värden för att kunna skapa en handlingspunkt
            Id = id;
            Description = description;
            Category = category;
            Accountable = accountable;
            Project = project;
            Status = status;
            ActionDate = actionDate;
        }
    }
}
