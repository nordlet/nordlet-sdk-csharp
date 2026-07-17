using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(PostV1InventorySettingsGetResponseNegativeStockPolicy.PostV1InventorySettingsGetResponseNegativeStockPolicySerializer)
)]
[Serializable]
public readonly record struct PostV1InventorySettingsGetResponseNegativeStockPolicy : IStringEnum
{
    public static readonly PostV1InventorySettingsGetResponseNegativeStockPolicy Reject = new(
        Values.Reject
    );

    public static readonly PostV1InventorySettingsGetResponseNegativeStockPolicy Allow = new(
        Values.Allow
    );

    public PostV1InventorySettingsGetResponseNegativeStockPolicy(string value)
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
    public static PostV1InventorySettingsGetResponseNegativeStockPolicy FromCustom(string value)
    {
        return new PostV1InventorySettingsGetResponseNegativeStockPolicy(value);
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
        PostV1InventorySettingsGetResponseNegativeStockPolicy value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostV1InventorySettingsGetResponseNegativeStockPolicy value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostV1InventorySettingsGetResponseNegativeStockPolicy value
    ) => value.Value;

    public static explicit operator PostV1InventorySettingsGetResponseNegativeStockPolicy(
        string value
    ) => new(value);

    internal class PostV1InventorySettingsGetResponseNegativeStockPolicySerializer
        : JsonConverter<PostV1InventorySettingsGetResponseNegativeStockPolicy>
    {
        public override PostV1InventorySettingsGetResponseNegativeStockPolicy Read(
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
            return new PostV1InventorySettingsGetResponseNegativeStockPolicy(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PostV1InventorySettingsGetResponseNegativeStockPolicy value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PostV1InventorySettingsGetResponseNegativeStockPolicy ReadAsPropertyName(
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
            return new PostV1InventorySettingsGetResponseNegativeStockPolicy(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PostV1InventorySettingsGetResponseNegativeStockPolicy value,
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
        public const string Reject = "reject";

        public const string Allow = "allow";
    }
}
