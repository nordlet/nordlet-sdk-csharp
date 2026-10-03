using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AssetsAssetsInputVatResponseStatus.PostV1AssetsAssetsInputVatResponseStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1AssetsAssetsInputVatResponseStatus : IStringEnum
{
    public static readonly PostV1AssetsAssetsInputVatResponseStatus Active = new(Values.Active);

    public static readonly PostV1AssetsAssetsInputVatResponseStatus FullyDepreciated = new(
        Values.FullyDepreciated
    );

    public static readonly PostV1AssetsAssetsInputVatResponseStatus Disposed = new(Values.Disposed);

    public PostV1AssetsAssetsInputVatResponseStatus(string value)
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
    public static PostV1AssetsAssetsInputVatResponseStatus FromCustom(string value)
    {
        return new PostV1AssetsAssetsInputVatResponseStatus(value);
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
        PostV1AssetsAssetsInputVatResponseStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AssetsAssetsInputVatResponseStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AssetsAssetsInputVatResponseStatus value) =>
        value.Value;

    public static explicit operator PostV1AssetsAssetsInputVatResponseStatus(string value) =>
        new(value);

    internal class PostV1AssetsAssetsInputVatResponseStatusSerializer
        : JsonConverter<PostV1AssetsAssetsInputVatResponseStatus>
    {
        public override PostV1AssetsAssetsInputVatResponseStatus Read(
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
            return new PostV1AssetsAssetsInputVatResponseStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AssetsAssetsInputVatResponseStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AssetsAssetsInputVatResponseStatus ReadAsPropertyName(
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
            return new PostV1AssetsAssetsInputVatResponseStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AssetsAssetsInputVatResponseStatus value,
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
