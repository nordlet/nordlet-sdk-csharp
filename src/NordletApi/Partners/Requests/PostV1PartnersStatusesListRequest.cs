using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PartnersStatusesListRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
