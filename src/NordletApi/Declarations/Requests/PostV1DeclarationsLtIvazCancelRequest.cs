using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtIvazCancelRequest
{
    [JsonPropertyName("entries")]
    public IEnumerable<PostV1DeclarationsLtIvazCancelRequestEntriesItem> Entries { get; set; } =
        new List<PostV1DeclarationsLtIvazCancelRequestEntriesItem>();

    [JsonPropertyName("persist")]
    public bool? Persist { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
