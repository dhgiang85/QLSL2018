using System;


namespace QLSL2018.Data.Interfaces
{
    public interface IEventTracking
    {
        string ContactName { set; get; }

        string OperatorName { set; get; }

        string Details { get; set; }

        bool Processed { set; get; }


        DateTime DateCreated { set; get; }

        DateTime DateOccured { set; get; }

        DateTime DateProcessed { set; get; }

    }
}
