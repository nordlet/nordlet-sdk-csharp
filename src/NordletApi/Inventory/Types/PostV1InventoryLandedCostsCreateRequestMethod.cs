using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1InventoryLandedCostsCreateRequestMethod.PostV1InventoryLandedCostsCreateRequestMethodSerializer)
)]
[Serializable]
public readonly record struct PostV1InventoryLandedCostsCreateRequestMethod : IStringEnum
{
    public static readonly PostV1InventoryLandedCostsCreateRequestMethod ByValue = new(
        Values.ByValue
    );

    public static readonly PostV1InventoryLandedCostsCreateRequestMethod ByQuantity = new(
        Values.ByQuantity
    );

    public PostV1InventoryLandedCostsCreateRequestMethod(string value)
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
    public static PostV1InventoryLandedCostsCreateRequestMethod FromCustom(string value)
    {
        return new PostV1InventoryLandedCostsCreateRequestMethod(value);
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
        PostV1InventoryLandedCostsCreateRequestMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1InventoryLandedCostsCreateRequestMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1InventoryLandedCostsCreateRequestMethod value) =>
        value.Value;

    public static explicit operator PostV1InventoryLandedCostsCreateRequestMethod(string value) =>
        new(value);

    internal class PostV1InventoryLandedCostsCreateRequestMethodSerializer
        : JsonConverter<PostV1InventoryLandedCostsCreateRequestMethod>
    {
        public override PostV1InventoryLandedCostsCreateRequestMethod Read(
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
            return new PostV1InventoryLandedCostsCreateRequestMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1InventoryLandedCostsCreateRequestMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1InventoryLandedCostsCreateRequestMethod ReadAsPropertyName(
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
            return new PostV1InventoryLandedCostsCreateRequestMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1InventoryLandedCostsCreateRequestMethod value,
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
        public const string ByValue = "by_value";

        public const string ByQuantity = "by_quantity";
    }
}
