using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(AssetsCreateAssetsResponseStatus.AssetsCreateAssetsResponseStatusSerializer))]
[Serializable]
public readonly record struct AssetsCreateAssetsResponseStatus : IStringEnum
{
    public static readonly AssetsCreateAssetsResponseStatus Active = new(Values.Active);

    public static readonly AssetsCreateAssetsResponseStatus FullyDepreciated = new(
        Values.FullyDepreciated
    );

    public static readonly AssetsCreateAssetsResponseStatus Disposed = new(Values.Disposed);

    public AssetsCreateAssetsResponseStatus(string value)
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
    public static AssetsCreateAssetsResponseStatus FromCustom(string value)
    {
        return new AssetsCreateAssetsResponseStatus(value);
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

    public static bool operator ==(AssetsCreateAssetsResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AssetsCreateAssetsResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AssetsCreateAssetsResponseStatus value) => value.Value;

    public static explicit operator AssetsCreateAssetsResponseStatus(string value) => new(value);

    internal class AssetsCreateAssetsResponseStatusSerializer
        : JsonConverter<AssetsCreateAssetsResponseStatus>
    {
        public override AssetsCreateAssetsResponseStatus Read(
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
            return new AssetsCreateAssetsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsCreateAssetsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsCreateAssetsResponseStatus ReadAsPropertyName(
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
            return new AssetsCreateAssetsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsCreateAssetsResponseStatus value,
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
