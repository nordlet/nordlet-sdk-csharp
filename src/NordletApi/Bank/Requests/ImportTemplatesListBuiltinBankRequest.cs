using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ImportTemplatesListBuiltinBankRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
