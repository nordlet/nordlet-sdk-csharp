using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvitesListAccountRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
