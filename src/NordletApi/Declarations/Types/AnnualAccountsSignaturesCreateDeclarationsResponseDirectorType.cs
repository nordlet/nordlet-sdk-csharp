using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType.AnnualAccountsSignaturesCreateDeclarationsResponseDirectorTypeSerializer)
)]
[Serializable]
public readonly record struct AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType
    : IStringEnum
{
    public static readonly AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType ManagingCurrent =
        new(Values.ManagingCurrent);

    public static readonly AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType ManagingFormer =
        new(Values.ManagingFormer);

    public static readonly AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType SupervisoryCurrent =
        new(Values.SupervisoryCurrent);

    public static readonly AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType SupervisoryFormer =
        new(Values.SupervisoryFormer);

    public AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType(string value)
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
    public static AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType FromCustom(
        string value
    )
    {
        return new AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType(value);
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
        AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType value
    ) => value.Value;

    public static explicit operator AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType(
        string value
    ) => new(value);

    internal class AnnualAccountsSignaturesCreateDeclarationsResponseDirectorTypeSerializer
        : JsonConverter<AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType>
    {
        public override AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType Read(
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
            return new AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType ReadAsPropertyName(
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
            return new AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnualAccountsSignaturesCreateDeclarationsResponseDirectorType value,
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
