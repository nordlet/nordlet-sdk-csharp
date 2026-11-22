using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem.GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItemSerializer)
)]
[Serializable]
public readonly record struct GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem
    : IStringEnum
{
    public static readonly GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem SubsAndProfessionalFees =
        new(Values.SubsAndProfessionalFees);

    public static readonly GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem NurseryPlaces =
        new(Values.NurseryPlaces);

    public static readonly GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem EducationalAssistance =
        new(Values.EducationalAssistance);

    public static readonly GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem LoansWrittenOrWaived =
        new(Values.LoansWrittenOrWaived);

    public static readonly GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem Multiple =
        new(Values.Multiple);

    public static readonly GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem Other = new(
        Values.Other
    );

    public GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem(string value)
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
    public static GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem FromCustom(
        string value
    )
    {
        return new GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem(value);
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
        GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem value
    ) => value.Value;

    public static explicit operator GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem(
        string value
    ) => new(value);

    internal class GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItemSerializer
        : JsonConverter<GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem>
    {
        public override GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem Read(
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
            return new GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem ReadAsPropertyName(
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
            return new GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GbP11DItemsCreateDeclarationsRequestItemOtherNonClass1AItem value,
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
        public const string SubsAndProfessionalFees = "subs and professional fees";

        public const string NurseryPlaces = "nursery places";

        public const string EducationalAssistance = "educational assistance";

        public const string LoansWrittenOrWaived = "loans written or waived";

        public const string Multiple = "multiple";

        public const string Other = "other";
    }
}
