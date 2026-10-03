using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1LedgerStatementRowsSchemesRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
