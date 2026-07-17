using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PayrollSchedulesListRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
