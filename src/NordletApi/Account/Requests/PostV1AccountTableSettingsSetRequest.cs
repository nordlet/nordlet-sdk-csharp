using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountTableSettingsSetRequest
{
    [JsonPropertyName("tableKey")]
    public required string TableKey { get; set; }

    [JsonPropertyName("columns")]
    public IEnumerable<string>? Columns { get; set; }

    [JsonPropertyName("pageSize")]
    public double? PageSize { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
