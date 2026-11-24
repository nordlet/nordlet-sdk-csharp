using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AssetsCreateFromPurchaseAssetsResponseStatus.AssetsCreateFromPurchaseAssetsResponseStatusSerializer)
)]
[Serializable]
public readonly record struct AssetsCreateFromPurchaseAssetsResponseStatus : IStringEnum
{
    public static readonly AssetsCreateFromPurchaseAssetsResponseStatus Active = new(Values.Active);

    public static readonly AssetsCreateFromPurchaseAssetsResponseStatus FullyDepreciated = new(
        Values.FullyDepreciated
    );

    public static readonly AssetsCreateFromPurchaseAssetsResponseStatus Disposed = new(
        Values.Disposed
    );

    public AssetsCreateFromPurchaseAssetsResponseStatus(string value)
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
    public static AssetsCreateFromPurchaseAssetsResponseStatus FromCustom(string value)
    {
        return new AssetsCreateFromPurchaseAssetsResponseStatus(value);
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
        AssetsCreateFromPurchaseAssetsResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetsCreateFromPurchaseAssetsResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AssetsCreateFromPurchaseAssetsResponseStatus value) =>
        value.Value;

    public static explicit operator AssetsCreateFromPurchaseAssetsResponseStatus(string value) =>
        new(value);

    internal class AssetsCreateFromPurchaseAssetsResponseStatusSerializer
        : JsonConverter<AssetsCreateFromPurchaseAssetsResponseStatus>
    {
        public override AssetsCreateFromPurchaseAssetsResponseStatus Read(
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
            return new AssetsCreateFromPurchaseAssetsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsCreateFromPurchaseAssetsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsCreateFromPurchaseAssetsResponseStatus ReadAsPropertyName(
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
            return new AssetsCreateFromPurchaseAssetsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsCreateFromPurchaseAssetsResponseStatus value,
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
