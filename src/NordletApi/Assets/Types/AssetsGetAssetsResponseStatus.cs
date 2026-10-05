using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(typeof(AssetsGetAssetsResponseStatus.AssetsGetAssetsResponseStatusSerializer))]
[Serializable]
public readonly record struct AssetsGetAssetsResponseStatus : IStringEnum
{
    public static readonly AssetsGetAssetsResponseStatus Active = new(Values.Active);

    public static readonly AssetsGetAssetsResponseStatus FullyDepreciated = new(
        Values.FullyDepreciated
    );

    public static readonly AssetsGetAssetsResponseStatus Disposed = new(Values.Disposed);

    public AssetsGetAssetsResponseStatus(string value)
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
    public static AssetsGetAssetsResponseStatus FromCustom(string value)
    {
        return new AssetsGetAssetsResponseStatus(value);
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

    public static bool operator ==(AssetsGetAssetsResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AssetsGetAssetsResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AssetsGetAssetsResponseStatus value) => value.Value;

    public static explicit operator AssetsGetAssetsResponseStatus(string value) => new(value);

    internal class AssetsGetAssetsResponseStatusSerializer
        : JsonConverter<AssetsGetAssetsResponseStatus>
    {
        public override AssetsGetAssetsResponseStatus Read(
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
            return new AssetsGetAssetsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsGetAssetsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsGetAssetsResponseStatus ReadAsPropertyName(
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
            return new AssetsGetAssetsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsGetAssetsResponseStatus value,
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
