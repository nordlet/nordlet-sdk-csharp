using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record StatusesListPartnersRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
