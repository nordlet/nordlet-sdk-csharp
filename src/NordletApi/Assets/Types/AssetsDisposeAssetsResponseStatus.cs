using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AssetsDisposeAssetsResponseStatus.AssetsDisposeAssetsResponseStatusSerializer)
)]
[Serializable]
public readonly record struct AssetsDisposeAssetsResponseStatus : IStringEnum
{
    public static readonly AssetsDisposeAssetsResponseStatus Active = new(Values.Active);

    public static readonly AssetsDisposeAssetsResponseStatus FullyDepreciated = new(
        Values.FullyDepreciated
    );

    public static readonly AssetsDisposeAssetsResponseStatus Disposed = new(Values.Disposed);

    public AssetsDisposeAssetsResponseStatus(string value)
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
    public static AssetsDisposeAssetsResponseStatus FromCustom(string value)
    {
        return new AssetsDisposeAssetsResponseStatus(value);
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

    public static bool operator ==(AssetsDisposeAssetsResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AssetsDisposeAssetsResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AssetsDisposeAssetsResponseStatus value) => value.Value;

    public static explicit operator AssetsDisposeAssetsResponseStatus(string value) => new(value);

    internal class AssetsDisposeAssetsResponseStatusSerializer
        : JsonConverter<AssetsDisposeAssetsResponseStatus>
    {
        public override AssetsDisposeAssetsResponseStatus Read(
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
            return new AssetsDisposeAssetsResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AssetsDisposeAssetsResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AssetsDisposeAssetsResponseStatus ReadAsPropertyName(
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
            return new AssetsDisposeAssetsResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AssetsDisposeAssetsResponseStatus value,
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
