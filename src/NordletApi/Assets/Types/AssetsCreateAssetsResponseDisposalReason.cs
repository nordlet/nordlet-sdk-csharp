using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AssetsCreateAssetsResponseDisposalReason.AssetsCreateAssetsResponseDisposalReasonSerializer)
)]
[Serializable]
public readonly record struct AssetsCreateAssetsResponseDisposalReason : IStringEnum
{
    public static readonly AssetsCreateAssetsResponseDisposalReason Sold = new(Values.Sold);

    public static readonly AssetsCreateAssetsResponseDisposalReason Scrapped = new(Values.Scrapped);

    public static readonly AssetsCreateAssetsResponseDisposalReason WrittenOff = new(
        Values.WrittenOff
    );

    public AssetsCreateAssetsResponseDisposalReason(string value)
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
    public static AssetsCreateAssetsResponseDisposalReason FromCustom(string value)
    {
        return new AssetsCreateAssetsResponseDisposalReason(value);
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

    public static bool operator ==(
        AssetsCreateAssetsResponseDisposalReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetsCreateAssetsResponseDisposalReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AssetsCreateAssetsResponseDisposalReason value) =>
        value.Value;

    public static explicit operator AssetsCreateAssetsResponseDisposalReason(string value) =>
        new(value);

    internal class AssetsCreateAssetsResponseDisposalReasonSerializer
        : JsonConverter<AssetsCreateAssetsResponseDisposalReason>
    {
        public override AssetsCreateAssetsResponseDisposalReason Read(
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
            return new AssetsCreateAssetsResponseDisposalReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsCreateAssetsResponseDisposalReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsCreateAssetsResponseDisposalReason ReadAsPropertyName(
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
            return new AssetsCreateAssetsResponseDisposalReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsCreateAssetsResponseDisposalReason value,
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
