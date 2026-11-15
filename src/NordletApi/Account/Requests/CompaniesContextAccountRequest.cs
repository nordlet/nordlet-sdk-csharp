using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CompaniesContextAccountRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
