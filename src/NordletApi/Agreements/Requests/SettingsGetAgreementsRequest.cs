using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SettingsGetAgreementsRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
