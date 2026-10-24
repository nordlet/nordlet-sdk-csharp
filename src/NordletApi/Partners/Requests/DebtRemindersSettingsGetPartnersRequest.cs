using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record DebtRemindersSettingsGetPartnersRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
