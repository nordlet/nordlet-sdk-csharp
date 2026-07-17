using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1AssetsAssetsListResponseRowsItemStatus.PostV1AssetsAssetsListResponseRowsItemStatusSerializer)
)]
[Serializable]
public readonly record struct PostV1AssetsAssetsListResponseRowsItemStatus : IStringEnum
{
    public static readonly PostV1AssetsAssetsListResponseRowsItemStatus Active = new(Values.Active);

    public static readonly PostV1AssetsAssetsListResponseRowsItemStatus FullyDepreciated = new(
        Values.FullyDepreciated
    );

    public static readonly PostV1AssetsAssetsListResponseRowsItemStatus Disposed = new(
        Values.Disposed
    );

    public PostV1AssetsAssetsListResponseRowsItemStatus(string value)
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
    public static PostV1AssetsAssetsListResponseRowsItemStatus FromCustom(string value)
    {
        return new PostV1AssetsAssetsListResponseRowsItemStatus(value);
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
        PostV1AssetsAssetsListResponseRowsItemStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1AssetsAssetsListResponseRowsItemStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1AssetsAssetsListResponseRowsItemStatus value) =>
        value.Value;

    public static explicit operator PostV1AssetsAssetsListResponseRowsItemStatus(string value) =>
        new(value);

    internal class PostV1AssetsAssetsListResponseRowsItemStatusSerializer
        : JsonConverter<PostV1AssetsAssetsListResponseRowsItemStatus>
    {
        public override PostV1AssetsAssetsListResponseRowsItemStatus Read(
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
            return new PostV1AssetsAssetsListResponseRowsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1AssetsAssetsListResponseRowsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1AssetsAssetsListResponseRowsItemStatus ReadAsPropertyName(
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
            return new PostV1AssetsAssetsListResponseRowsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1AssetsAssetsListResponseRowsItemStatus value,
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
