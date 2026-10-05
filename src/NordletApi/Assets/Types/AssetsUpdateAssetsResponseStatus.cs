using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(AssetsUpdateAssetsResponseStatus.AssetsUpdateAssetsResponseStatusSerializer))]
[Serializable]
public readonly record struct AssetsUpdateAssetsResponseStatus : IStringEnum
{
    public static readonly AssetsUpdateAssetsResponseStatus Active = new(Values.Active);

    public static readonly AssetsUpdateAssetsResponseStatus FullyDepreciated = new(
        Values.FullyDepreciated
    );

    public static readonly AssetsUpdateAssetsResponseStatus Disposed = new(Values.Disposed);

    public AssetsUpdateAssetsResponseStatus(string value)
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
    public static AssetsUpdateAssetsResponseStatus FromCustom(string value)
    {
        return new AssetsUpdateAssetsResponseStatus(value);
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

    public static bool operator ==(AssetsUpdateAssetsResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AssetsUpdateAssetsResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AssetsUpdateAssetsResponseStatus value) => value.Value;

    public static explicit operator AssetsUpdateAssetsResponseStatus(string value) => new(value);

    internal class AssetsUpdateAssetsResponseStatusSerializer
        : JsonConverter<AssetsUpdateAssetsResponseStatus>
    {
        public override AssetsUpdateAssetsResponseStatus Read(
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
            return new AssetsUpdateAssetsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsUpdateAssetsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsUpdateAssetsResponseStatus ReadAsPropertyName(
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
            return new AssetsUpdateAssetsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsUpdateAssetsResponseStatus value,
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
