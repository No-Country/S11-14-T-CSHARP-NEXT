namespace HotelWiz.Back.Common.Enums;

public static class RoomType
{
    public static string Sencilla { get; } = nameof(Sencilla);
    public static string Doble { get; } = nameof(Doble);
    public static string Triple { get; } = nameof(Triple);
    public static string Familiar { get; } = nameof(Familiar);
    public static string King { get; } = nameof(King);
    public static string Master { get; } = nameof(Master);
    public static string Mini { get; } = nameof(Mini);
    public static string Presidencial { get; } = nameof(Presidencial);


}

public enum RoomTypes
{
    Sencilla = 1,
    Doble,
    Triple,
    Familiar,
    King,
    Master,
    Mini,
    Presidencial
}