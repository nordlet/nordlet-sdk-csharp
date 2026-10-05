using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record DebtRemindersPreviewPartnersRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
