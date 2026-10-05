using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record StatementRowsSchemesLedgerRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
