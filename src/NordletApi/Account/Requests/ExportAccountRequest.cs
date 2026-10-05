using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ExportAccountRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
