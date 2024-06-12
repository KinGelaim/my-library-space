namespace MyLibrarySpace.Interop;

/// <summary>
/// Интерфейс для сосредоточения доступа ко времени в проекте
/// </summary>
public interface IClock
{
    /// <summary>
    /// Сейчас
    /// </summary>
    DateTime Now { get; }

    /// <summary>
    /// Сегодня
    /// </summary>
    DateTime Today { get; }
}