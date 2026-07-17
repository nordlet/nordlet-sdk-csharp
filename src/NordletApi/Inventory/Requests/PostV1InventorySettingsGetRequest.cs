using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1InventorySettingsGetRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
