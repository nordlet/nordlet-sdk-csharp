using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ReorderRulesCheckInventoryRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
