using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AssetsAssetsGetResponseStatus.PostV1AssetsAssetsGetResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1AssetsAssetsGetResponseStatus : IStringEnum
{
    public static readonly PostV1AssetsAssetsGetResponseStatus Active = new(Values.Active);

    public static readonly PostV1AssetsAssetsGetResponseStatus FullyDepreciated = new(
        Values.FullyDepreciated
    );

    public static readonly PostV1AssetsAssetsGetResponseStatus Disposed = new(Values.Disposed);

    public PostV1AssetsAssetsGetResponseStatus(string value)
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
    public static PostV1AssetsAssetsGetResponseStatus FromCustom(string value)
    {
        return new PostV1AssetsAssetsGetResponseStatus(value);
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

    public static bool operator ==(PostV1AssetsAssetsGetResponseStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PostV1AssetsAssetsGetResponseStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AssetsAssetsGetResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1AssetsAssetsGetResponseStatus(string value) => new(value);

    internal class PostV1AssetsAssetsGetResponseStatusSerializer
        : JsonConverter<PostV1AssetsAssetsGetResponseStatus>
    {
        public override PostV1AssetsAssetsGetResponseStatus Read(
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
            return new PostV1AssetsAssetsGetResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AssetsAssetsGetResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AssetsAssetsGetResponseStatus ReadAsPropertyName(
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
            return new PostV1AssetsAssetsGetResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AssetsAssetsGetResponseStatus value,
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
