using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(SalesTaxExemptionsCreatePartnersRequestState.SalesTaxExemptionsCreatePartnersRequestStateSerializer)
)]
[Serializable]
public readonly record struct SalesTaxExemptionsCreatePartnersRequestState : IStringEnum
{
    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsAr = new(Values.UsAr);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsGa = new(Values.UsGa);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsIa = new(Values.UsIa);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsIn = new(Values.UsIn);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsKs = new(Values.UsKs);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsKy = new(Values.UsKy);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsMi = new(Values.UsMi);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsMn = new(Values.UsMn);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsNc = new(Values.UsNc);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsNd = new(Values.UsNd);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsNe = new(Values.UsNe);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsNj = new(Values.UsNj);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsNv = new(Values.UsNv);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsOh = new(Values.UsOh);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsOk = new(Values.UsOk);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsRi = new(Values.UsRi);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsSd = new(Values.UsSd);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsTn = new(Values.UsTn);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsUt = new(Values.UsUt);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsVt = new(Values.UsVt);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsWa = new(Values.UsWa);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsWi = new(Values.UsWi);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsWv = new(Values.UsWv);

    public static readonly SalesTaxExemptionsCreatePartnersRequestState UsWy = new(Values.UsWy);

    public SalesTaxExemptionsCreatePartnersRequestState(string value)
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
    public static SalesTaxExemptionsCreatePartnersRequestState FromCustom(string value)
    {
        return new SalesTaxExemptionsCreatePartnersRequestState(value);
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
        SalesTaxExemptionsCreatePartnersRequestState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SalesTaxExemptionsCreatePartnersRequestState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SalesTaxExemptionsCreatePartnersRequestState value) =>
        value.Value;

    public static explicit operator SalesTaxExemptionsCreatePartnersRequestState(string value) =>
        new(value);

    internal class SalesTaxExemptionsCreatePartnersRequestStateSerializer
        : JsonConverter<SalesTaxExemptionsCreatePartnersRequestState>
    {
        public override SalesTaxExemptionsCreatePartnersRequestState Read(
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
            return new SalesTaxExemptionsCreatePartnersRequestState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SalesTaxExemptionsCreatePartnersRequestState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SalesTaxExemptionsCreatePartnersRequestState ReadAsPropertyName(
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
            return new SalesTaxExemptionsCreatePartnersRequestState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SalesTaxExemptionsCreatePartnersRequestState value,
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
        public const string UsAr = "US-AR";

        public const string UsGa = "US-GA";

        public const string UsIa = "US-IA";

        public const string UsIn = "US-IN";

        public const string UsKs = "US-KS";

        public const string UsKy = "US-KY";

        public const string UsMi = "US-MI";

        public const string UsMn = "US-MN";

        public const string UsNc = "US-NC";

        public const string UsNd = "US-ND";

        public const string UsNe = "US-NE";

        public const string UsNj = "US-NJ";

        public const string UsNv = "US-NV";

        public const string UsOh = "US-OH";

        public const string UsOk = "US-OK";

        public const string UsRi = "US-RI";

        public const string UsSd = "US-SD";

        public const string UsTn = "US-TN";

        public const string UsUt = "US-UT";

        public const string UsVt = "US-VT";

        public const string UsWa = "US-WA";

        public const string UsWi = "US-WI";

        public const string UsWv = "US-WV";

        public const string UsWy = "US-WY";
    }
}
