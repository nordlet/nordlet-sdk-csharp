using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AssetsInputVatAssetsResponseDisposalReason.AssetsInputVatAssetsResponseDisposalReasonSerializer)
)]
[Serializable]
public readonly record struct AssetsInputVatAssetsResponseDisposalReason : IStringEnum
{
    public static readonly AssetsInputVatAssetsResponseDisposalReason Sold = new(Values.Sold);

    public static readonly AssetsInputVatAssetsResponseDisposalReason Scrapped = new(
        Values.Scrapped
    );

    public static readonly AssetsInputVatAssetsResponseDisposalReason WrittenOff = new(
        Values.WrittenOff
    );

    public AssetsInputVatAssetsResponseDisposalReason(string value)
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
    public static AssetsInputVatAssetsResponseDisposalReason FromCustom(string value)
    {
        return new AssetsInputVatAssetsResponseDisposalReason(value);
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
        AssetsInputVatAssetsResponseDisposalReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetsInputVatAssetsResponseDisposalReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AssetsInputVatAssetsResponseDisposalReason value) =>
        value.Value;

    public static explicit operator AssetsInputVatAssetsResponseDisposalReason(string value) =>
        new(value);

    internal class AssetsInputVatAssetsResponseDisposalReasonSerializer
        : JsonConverter<AssetsInputVatAssetsResponseDisposalReason>
    {
        public override AssetsInputVatAssetsResponseDisposalReason Read(
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
            return new AssetsInputVatAssetsResponseDisposalReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsInputVatAssetsResponseDisposalReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsInputVatAssetsResponseDisposalReason ReadAsPropertyName(
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
            return new AssetsInputVatAssetsResponseDisposalReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsInputVatAssetsResponseDisposalReason value,
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
