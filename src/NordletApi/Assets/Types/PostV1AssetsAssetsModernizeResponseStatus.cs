using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AssetsAssetsModernizeResponseStatus.PostV1AssetsAssetsModernizeResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1AssetsAssetsModernizeResponseStatus : IStringEnum
{
    public static readonly PostV1AssetsAssetsModernizeResponseStatus Active = new(Values.Active);

    public static readonly PostV1AssetsAssetsModernizeResponseStatus FullyDepreciated = new(
        Values.FullyDepreciated
    );

    public static readonly PostV1AssetsAssetsModernizeResponseStatus Disposed = new(
        Values.Disposed
    );

    public PostV1AssetsAssetsModernizeResponseStatus(string value)
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
    public static PostV1AssetsAssetsModernizeResponseStatus FromCustom(string value)
    {
        return new PostV1AssetsAssetsModernizeResponseStatus(value);
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
        PostV1AssetsAssetsModernizeResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AssetsAssetsModernizeResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AssetsAssetsModernizeResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1AssetsAssetsModernizeResponseStatus(string value) =>
        new(value);

    internal class PostV1AssetsAssetsModernizeResponseStatusSerializer
        : JsonConverter<PostV1AssetsAssetsModernizeResponseStatus>
    {
        public override PostV1AssetsAssetsModernizeResponseStatus Read(
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
            return new PostV1AssetsAssetsModernizeResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AssetsAssetsModernizeResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AssetsAssetsModernizeResponseStatus ReadAsPropertyName(
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
            return new PostV1AssetsAssetsModernizeResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AssetsAssetsModernizeResponseStatus value,
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
