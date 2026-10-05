using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType.AnnualAccountsSignaturesCreateDeclarationsRequestDirectorTypeSerializer)
)]
[Serializable]
public readonly record struct AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType
    : IStringEnum
{
    public static readonly AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType ManagingCurrent =
        new(Values.ManagingCurrent);

    public static readonly AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType ManagingFormer =
        new(Values.ManagingFormer);

    public static readonly AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType SupervisoryCurrent =
        new(Values.SupervisoryCurrent);

    public static readonly AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType SupervisoryFormer =
        new(Values.SupervisoryFormer);

    public AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType(string value)
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
    public static AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType FromCustom(
        string value
    )
    {
        return new AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType(value);
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
        AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType value
    ) => value.Value;

    public static explicit operator AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType(
        string value
    ) => new(value);

    internal class AnnualAccountsSignaturesCreateDeclarationsRequestDirectorTypeSerializer
        : JsonConverter<AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType>
    {
        public override AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType Read(
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
            return new AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType ReadAsPropertyName(
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
            return new AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnualAccountsSignaturesCreateDeclarationsRequestDirectorType value,
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
        public const string ManagingCurrent = "managing_current";

        public const string ManagingFormer = "managing_former";

        public const string SupervisoryCurrent = "supervisory_current";

        public const string SupervisoryFormer = "supervisory_former";
    }
}
