namespace MyLibrarySpace.Interop;

/// <summary>
/// Сосредоточение доступа ко времени в проекте
/// </summary>
public sealed class Clock : IClock
{
    private readonly DateTime? _fixedTime;

    /// <inheritdoc/>
    public DateTime Now => _fixedTime ?? DateTime.Now;

    /// <inheritdoc/>
    public DateTime Today => _fixedTime?.Date ?? DateTime.Today;

    public Clock(DateTime? dateTime = null)
    {
        _fixedTime = dateTime;
    }
}