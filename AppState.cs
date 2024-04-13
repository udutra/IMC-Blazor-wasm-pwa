using IMC.Models;

namespace IMC;

public static class AppState
{
    public static List<ImcModel> History { get; set; } = [];
    public static event EventHandler<EventArgs> OnChanged;

    public static void NotifyChanges(object? sender, EventArgs? args)
    {
        OnChanged.Invoke(sender, args);
    }
}