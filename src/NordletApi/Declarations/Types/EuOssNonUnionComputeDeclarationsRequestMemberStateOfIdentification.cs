using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification.EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentificationSerializer)
)]
[Serializable]
public readonly record struct EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification
    : IStringEnum
{
    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification At =
        new(Values.At);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Be =
        new(Values.Be);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Bg =
        new(Values.Bg);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Cy =
        new(Values.Cy);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Cz =
        new(Values.Cz);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification De =
        new(Values.De);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Dk =
        new(Values.Dk);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Ee =
        new(Values.Ee);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Es =
        new(Values.Es);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Fi =
        new(Values.Fi);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Fr =
        new(Values.Fr);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Gr =
        new(Values.Gr);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Hr =
        new(Values.Hr);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Hu =
        new(Values.Hu);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Ie =
        new(Values.Ie);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification It =
        new(Values.It);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Lt =
        new(Values.Lt);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Lu =
        new(Values.Lu);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Lv =
        new(Values.Lv);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Mt =
        new(Values.Mt);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Nl =
        new(Values.Nl);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Pl =
        new(Values.Pl);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Pt =
        new(Values.Pt);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Ro =
        new(Values.Ro);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Se =
        new(Values.Se);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Si =
        new(Values.Si);

    public static readonly EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Sk =
        new(Values.Sk);

    public EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification(string value)
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
    public static EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification FromCustom(
        string value
    )
    {
        return new EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification(value);
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
        EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification value
    ) => value.Value;

    public static explicit operator EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification(
        string value
    ) => new(value);

    internal class EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentificationSerializer
        : JsonConverter<EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification>
    {
        public override EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification Read(
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
            return new EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification ReadAsPropertyName(
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
            return new EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification value,
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
        public const string At = "AT";

        public const string Be = "BE";

        public const string Bg = "BG";

        public const string Cy = "CY";

        public const string Cz = "CZ";

        public const string De = "DE";

        public const string Dk = "DK";

        public const string Ee = "EE";

        public const string Es = "ES";

        public const string Fi = "FI";

        public const string Fr = "FR";

        public const string Gr = "GR";

        public const string Hr = "HR";

        public const string Hu = "HU";

        public const string Ie = "IE";

        public const string It = "IT";

        public const string Lt = "LT";

        public const string Lu = "LU";

        public const string Lv = "LV";

        public const string Mt = "MT";

        public const string Nl = "NL";

        public const string Pl = "PL";

        public const string Pt = "PT";

        public const string Ro = "RO";

        public const string Se = "SE";

        public const string Si = "SI";

        public const string Sk = "SK";
    }
}
