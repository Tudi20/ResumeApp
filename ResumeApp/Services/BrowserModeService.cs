using Microsoft.JSInterop;
using System.Globalization;

namespace ResumeApp.Services;
public class BrowserModeService
{
    private readonly IJSRuntime _jsRuntime;
    public BrowserModeService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }
    public async Task SetDarkModeAsync(bool darkMode)
    {
        await _jsRuntime.InvokeVoidAsync("ui", "mode", darkMode ? "dark" : "light");
    }

    public async Task<bool> GetDarkModeAsync()
    {
        var mode = await _jsRuntime.InvokeAsync<string>("ui", "mode");
        Console.WriteLine(mode);
        return mode == "dark";
    }

    public async Task<bool> GetDarkModePreferenceAsync()
    {
        return await _jsRuntime.InvokeAsync<bool>("IsDarkMode");
    }

    public async Task ToggleDarkModeAsync()
    {
        await SetDarkModeAsync(!await GetDarkModeAsync());
    }

    public async Task CallUiAsync(string action)
    {
        await _jsRuntime.InvokeVoidAsync("ui", action);
    }
}