using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record VatProrataListDeclarationsRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
