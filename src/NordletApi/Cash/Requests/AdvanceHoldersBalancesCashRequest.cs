using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AdvanceHoldersBalancesCashRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
