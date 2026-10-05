using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SettingsUpdateInventoryResponseNegativeStockPolicy.SettingsUpdateInventoryResponseNegativeStockPolicySerializer)
)]
[Serializable]
public readonly record struct SettingsUpdateInventoryResponseNegativeStockPolicy : IStringEnum
{
    public static readonly SettingsUpdateInventoryResponseNegativeStockPolicy Reject = new(
        Values.Reject
    );

    public static readonly SettingsUpdateInventoryResponseNegativeStockPolicy Allow = new(
        Values.Allow
    );

    public SettingsUpdateInventoryResponseNegativeStockPolicy(string value)
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
    public static SettingsUpdateInventoryResponseNegativeStockPolicy FromCustom(string value)
    {
        return new SettingsUpdateInventoryResponseNegativeStockPolicy(value);
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
        SettingsUpdateInventoryResponseNegativeStockPolicy value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SettingsUpdateInventoryResponseNegativeStockPolicy value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SettingsUpdateInventoryResponseNegativeStockPolicy value
    ) => value.Value;

    public static explicit operator SettingsUpdateInventoryResponseNegativeStockPolicy(
        string value
    ) => new(value);

    internal class SettingsUpdateInventoryResponseNegativeStockPolicySerializer
        : JsonConverter<SettingsUpdateInventoryResponseNegativeStockPolicy>
    {
        public override SettingsUpdateInventoryResponseNegativeStockPolicy Read(
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
            return new SettingsUpdateInventoryResponseNegativeStockPolicy(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SettingsUpdateInventoryResponseNegativeStockPolicy value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SettingsUpdateInventoryResponseNegativeStockPolicy ReadAsPropertyName(
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
            return new SettingsUpdateInventoryResponseNegativeStockPolicy(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SettingsUpdateInventoryResponseNegativeStockPolicy value,
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
