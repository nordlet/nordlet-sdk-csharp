using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AssetsGetAssetsResponseDisposalReason.AssetsGetAssetsResponseDisposalReasonSerializer)
)]
[Serializable]
public readonly record struct AssetsGetAssetsResponseDisposalReason : IStringEnum
{
    public static readonly AssetsGetAssetsResponseDisposalReason Sold = new(Values.Sold);

    public static readonly AssetsGetAssetsResponseDisposalReason Scrapped = new(Values.Scrapped);

    public static readonly AssetsGetAssetsResponseDisposalReason WrittenOff = new(
        Values.WrittenOff
    );

    public AssetsGetAssetsResponseDisposalReason(string value)
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
    public static AssetsGetAssetsResponseDisposalReason FromCustom(string value)
    {
        return new AssetsGetAssetsResponseDisposalReason(value);
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

    public static bool operator ==(AssetsGetAssetsResponseDisposalReason value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AssetsGetAssetsResponseDisposalReason value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AssetsGetAssetsResponseDisposalReason value) =>
        value.Value;

    public static explicit operator AssetsGetAssetsResponseDisposalReason(string value) =>
        new(value);

    internal class AssetsGetAssetsResponseDisposalReasonSerializer
        : JsonConverter<AssetsGetAssetsResponseDisposalReason>
    {
        public override AssetsGetAssetsResponseDisposalReason Read(
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
            return new AssetsGetAssetsResponseDisposalReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsGetAssetsResponseDisposalReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsGetAssetsResponseDisposalReason ReadAsPropertyName(
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
            return new AssetsGetAssetsResponseDisposalReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsGetAssetsResponseDisposalReason value,
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
