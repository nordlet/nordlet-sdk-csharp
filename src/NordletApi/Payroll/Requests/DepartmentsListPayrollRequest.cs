using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record DepartmentsListPayrollRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
