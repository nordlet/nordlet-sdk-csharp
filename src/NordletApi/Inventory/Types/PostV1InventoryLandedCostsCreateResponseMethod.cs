using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1InventoryLandedCostsCreateResponseMethod.PostV1InventoryLandedCostsCreateResponseMethodSerializer)
)]
[Serializable]
public readonly record struct PostV1InventoryLandedCostsCreateResponseMethod : IStringEnum
{
    public static readonly PostV1InventoryLandedCostsCreateResponseMethod ByValue = new(
        Values.ByValue
    );

    public static readonly PostV1InventoryLandedCostsCreateResponseMethod ByQuantity = new(
        Values.ByQuantity
    );

    public PostV1InventoryLandedCostsCreateResponseMethod(string value)
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
    public static PostV1InventoryLandedCostsCreateResponseMethod FromCustom(string value)
    {
        return new PostV1InventoryLandedCostsCreateResponseMethod(value);
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
        PostV1InventoryLandedCostsCreateResponseMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1InventoryLandedCostsCreateResponseMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PostV1InventoryLandedCostsCreateResponseMethod value) =>
        value.Value;

    public static explicit operator PostV1InventoryLandedCostsCreateResponseMethod(string value) =>
        new(value);

    internal class PostV1InventoryLandedCostsCreateResponseMethodSerializer
        : JsonConverter<PostV1InventoryLandedCostsCreateResponseMethod>
    {
        public override PostV1InventoryLandedCostsCreateResponseMethod Read(
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
            return new PostV1InventoryLandedCostsCreateResponseMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1InventoryLandedCostsCreateResponseMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1InventoryLandedCostsCreateResponseMethod ReadAsPropertyName(
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
            return new PostV1InventoryLandedCostsCreateResponseMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1InventoryLandedCostsCreateResponseMethod value,
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
