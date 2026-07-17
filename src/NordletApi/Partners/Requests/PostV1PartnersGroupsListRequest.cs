using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PartnersGroupsListRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
