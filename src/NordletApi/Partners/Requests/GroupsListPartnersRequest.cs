using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GroupsListPartnersRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
