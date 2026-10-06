using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record RunsCreatePayrollRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    [JsonPropertyName("includeNatura")]
    public bool? IncludeNatura { get; set; }

    [JsonPropertyName("grossOverrides")]
    public IEnumerable<RunsCreatePayrollRequestGrossOverridesItem>? GrossOverrides { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<RunsCreatePayrollRequestLinesItem>? Lines { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("payDate")]
    public DateOnly? PayDate { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
