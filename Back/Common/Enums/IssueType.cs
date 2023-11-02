﻿namespace HotelWiz.Back.Common.Enums
{
    public enum IssueType
    {
        //public static string Done { get; } = nameof(Done);
        //public static string ToDo { get;  }=nameof(ToDo);
        //public static string Cancelled { get; } = nameof(Cancelled);
        //public static string InProgress { get; } = nameof(InProgress);


        ToDo,
        InProgress,
        Done,
        Cancelled,

    };

    public enum IssueCategory
    {
        Requerimiento = 1,
        Daño,
    }

    public enum IssueArea
    {
        Baño = 1,
        Habitacion,
        Cama,
    }
}
