
namespace Serde;

internal readonly record struct TypeOptions
{
    public bool DenyUnknownMembers { get; init; } = false;
    public MemberFormat MemberFormat { get; init; } = MemberFormat.None;
}

// Keep in sync with copy in serde
internal enum MemberFormat : byte
{
    /// <summary>
    /// Use the original name of the member.
    /// </summary>
    None,
    /// <summary>
    /// "PascalCase"
    /// </summary>
    PascalCase,
    /// <summary>
    /// "camelCase"
    /// </summary>
    CamelCase
}