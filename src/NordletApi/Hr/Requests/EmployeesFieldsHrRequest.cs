using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EmployeesFieldsHrRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
