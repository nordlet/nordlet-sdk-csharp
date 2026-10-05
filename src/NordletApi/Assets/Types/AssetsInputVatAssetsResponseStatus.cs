using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AssetsInputVatAssetsResponseStatus.AssetsInputVatAssetsResponseStatusSerializer)
)]
[Serializable]
public readonly record struct AssetsInputVatAssetsResponseStatus : IStringEnum
{
    public static readonly AssetsInputVatAssetsResponseStatus Active = new(Values.Active);

    public static readonly AssetsInputVatAssetsResponseStatus FullyDepreciated = new(
        Values.FullyDepreciated
    );

    public static readonly AssetsInputVatAssetsResponseStatus Disposed = new(Values.Disposed);

    public AssetsInputVatAssetsResponseStatus(string value)
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
    public static AssetsInputVatAssetsResponseStatus FromCustom(string value)
    {
        return new AssetsInputVatAssetsResponseStatus(value);
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

    public static bool operator ==(AssetsInputVatAssetsResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AssetsInputVatAssetsResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AssetsInputVatAssetsResponseStatus value) => value.Value;

    public static explicit operator AssetsInputVatAssetsResponseStatus(string value) => new(value);

    internal class AssetsInputVatAssetsResponseStatusSerializer
        : JsonConverter<AssetsInputVatAssetsResponseStatus>
    {
        public override AssetsInputVatAssetsResponseStatus Read(
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
            return new AssetsInputVatAssetsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsInputVatAssetsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsInputVatAssetsResponseStatus ReadAsPropertyName(
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
            return new AssetsInputVatAssetsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsInputVatAssetsResponseStatus value,
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
        public const string Active = "active";

        public const string FullyDepreciated = "fully_depreciated";

        public const string Disposed = "disposed";
    }
}
