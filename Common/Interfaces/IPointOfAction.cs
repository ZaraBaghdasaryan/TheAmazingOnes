using Common.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
    public interface IPointOfAction
    {
        public int Id { get; }
        public string Description { get; }
        public string Category { get; }
        public string Accountable { get; }
        public string Project { get; }
        public ActionPointStatuses Status { get; }
        public DateTime ActionDate { get; }
    }
}
