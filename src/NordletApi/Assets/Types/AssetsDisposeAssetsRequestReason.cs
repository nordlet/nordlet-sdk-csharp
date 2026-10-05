using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(AssetsDisposeAssetsRequestReason.AssetsDisposeAssetsRequestReasonSerializer))]
[Serializable]
public readonly record struct AssetsDisposeAssetsRequestReason : IStringEnum
{
    public static readonly AssetsDisposeAssetsRequestReason Sold = new(Values.Sold);

    public static readonly AssetsDisposeAssetsRequestReason Scrapped = new(Values.Scrapped);

    public static readonly AssetsDisposeAssetsRequestReason WrittenOff = new(Values.WrittenOff);

    public AssetsDisposeAssetsRequestReason(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static AssetsDisposeAssetsRequestReason FromCustom(string value)
    {
        return new AssetsDisposeAssetsRequestReason(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(AssetsDisposeAssetsRequestReason value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AssetsDisposeAssetsRequestReason value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AssetsDisposeAssetsRequestReason value) => value.Value;

    public static explicit operator AssetsDisposeAssetsRequestReason(string value) => new(value);

    internal class AssetsDisposeAssetsRequestReasonSerializer
        : JsonConverter<AssetsDisposeAssetsRequestReason>
    {
        public override AssetsDisposeAssetsRequestReason Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new AssetsDisposeAssetsRequestReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsDisposeAssetsRequestReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsDisposeAssetsRequestReason ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new AssetsDisposeAssetsRequestReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsDisposeAssetsRequestReason value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Sold = "sold";

        public const string Scrapped = "scrapped";

        public const string WrittenOff = "written_off";
    }
}
