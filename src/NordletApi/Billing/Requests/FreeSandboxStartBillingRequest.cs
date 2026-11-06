using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record FreeSandboxStartBillingRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
