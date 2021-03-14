using System;
namespace Forgebase.Masterdata.Core.Entities
{
    public class Constants
    {
        public enum StatusIds
        {
            Created = 1,
            Modified,
            Approved,
            Communicated,
            Closed,
            Deleted,
            Partial,
            PendingApproval,
            Rejected
        }

        public enum ProcessIds
        {
            Incoming = 1,
            Forging,
            Annealing,
            CNC_Turning,
            Inspection,
            Packing,
            Dispatch
        }
        public enum PartType
        {
            IM = 1,
            OM,
        }
        public enum DispatchStatus
        {
            Created = 1,
            Approved = 2
        }

    }
}
