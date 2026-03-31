namespace GrangerCove.Communication.Email.Abstractions;

public sealed class EmailMessage
{
    public required IReadOnlyList<string> To { get; init; }

    public IReadOnlyList<string>? Cc { get; init; }
    public IReadOnlyList<string>? Bcc { get; init; }

    public required string Subject { get; init; }

    public required string Body { get; init; }

    public bool IsHtml { get; init; } = true;

    /// <summary>
    /// Optional override. Defaults to configured value (support@grangercove.com)
    /// </summary>
    public string? FromAddress { get; init; }
}