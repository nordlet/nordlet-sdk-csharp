using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode.EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCodeSerializer)
)]
[Serializable]
public readonly record struct EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode
    : IStringEnum
{
    public static readonly EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode SixHundredTwentyOne =
        new(Values.SixHundredTwentyOne);

    public static readonly EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode SixHundredTwentyTwo =
        new(Values.SixHundredTwentyTwo);

    public static readonly EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode SixHundredTwentyThree =
        new(Values.SixHundredTwentyThree);

    public static readonly EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode SixHundredTwentyFour =
        new(Values.SixHundredTwentyFour);

    public static readonly EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode SixThousandTwoHundredEleven =
        new(Values.SixThousandTwoHundredEleven);

    public EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode(string value)
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
    public static EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode FromCustom(
        string value
    )
    {
        return new EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode(value);
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
        EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode value
    ) => value.Value;

    public static explicit operator EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode(
        string value
    ) => new(value);

    internal class EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCodeSerializer
        : JsonConverter<EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode>
    {
        public override EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode Read(
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
            return new EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode ReadAsPropertyName(
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
            return new EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EeTsdAnnexesSetDeclarationsResponseInputAnnex6RelatedPartiesItemTypeCode value,
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
        public const string SixHundredTwentyOne = "621";

        public const string SixHundredTwentyTwo = "622";

        public const string SixHundredTwentyThree = "623";

        public const string SixHundredTwentyFour = "624";

        public const string SixThousandTwoHundredEleven = "6211";
    }
}
