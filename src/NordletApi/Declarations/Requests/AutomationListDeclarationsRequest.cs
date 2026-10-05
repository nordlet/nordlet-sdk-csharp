using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AutomationListDeclarationsRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
