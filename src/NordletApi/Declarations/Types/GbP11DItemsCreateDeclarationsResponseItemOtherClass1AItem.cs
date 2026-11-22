using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem.GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItemSerializer)
)]
[Serializable]
public readonly record struct GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem
    : IStringEnum
{
    public static readonly GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem SubscriptionsAndFees =
        new(Values.SubscriptionsAndFees);

    public static readonly GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem EducationalAssistanceCl1A =
        new(Values.EducationalAssistanceCl1A);

    public static readonly GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem NonQualifyingRelocationBen =
        new(Values.NonQualifyingRelocationBen);

    public static readonly GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem StopLossCharges =
        new(Values.StopLossCharges);

    public static readonly GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem Other = new(
        Values.Other
    );

    public static readonly GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem Multiple = new(
        Values.Multiple
    );

    public GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem(string value)
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
    public static GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem FromCustom(string value)
    {
        return new GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem(value);
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
        GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem value
    ) => value.Value;

    public static explicit operator GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem(
        string value
    ) => new(value);

    internal class GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItemSerializer
        : JsonConverter<GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem>
    {
        public override GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem Read(
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
            return new GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem ReadAsPropertyName(
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
            return new GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsResponseItemOtherClass1AItem value,
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
        public const string SubscriptionsAndFees = "subscriptions and fees";

        public const string EducationalAssistanceCl1A = "educational assistance CL1A";

        public const string NonQualifyingRelocationBen = "non-qualifying relocation ben";

        public const string StopLossCharges = "stop loss charges";

        public const string Other = "other";

        public const string Multiple = "multiple";
    }
}
