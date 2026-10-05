using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record MembersListAccountRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
