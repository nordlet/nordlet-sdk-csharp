using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record QueueListReviewRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
