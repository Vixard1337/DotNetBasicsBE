namespace DotNetBasicsBE.Application;

public class AppStateService
{
    private readonly List<string> _logs = [];

    public string Language { get; private set; } = "PL";
    public bool IsDarkTheme { get; private set; }
    public IReadOnlyList<string> Logs => _logs;

    public event Action? Changed;

    public void SetLanguage(string language)
    {
        if (Language == language)
        {
            return;
        }

        Language = language;
        AddLog($"Language changed to {language}");
    }

    public string T(string pl, string en) => Language == "PL" ? pl : en;

    public void ToggleTheme()
    {
        IsDarkTheme = !IsDarkTheme;
        AddLog($"Theme changed to {(IsDarkTheme ? "Dark" : "Light")}");
    }

    public void AddLog(string message)
    {
        _logs.Insert(0, $"[{DateTime.Now:HH:mm:ss}] {message}");
        if (_logs.Count > 200)
        {
            _logs.RemoveAt(_logs.Count - 1);
        }

        Changed?.Invoke();
    }
}
