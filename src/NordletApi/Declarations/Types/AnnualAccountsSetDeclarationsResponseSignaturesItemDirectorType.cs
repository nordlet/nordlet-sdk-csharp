using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType.AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorTypeSerializer)
)]
[Serializable]
public readonly record struct AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType
    : IStringEnum
{
    public static readonly AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType ManagingCurrent =
        new(Values.ManagingCurrent);

    public static readonly AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType ManagingFormer =
        new(Values.ManagingFormer);

    public static readonly AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType SupervisoryCurrent =
        new(Values.SupervisoryCurrent);

    public static readonly AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType SupervisoryFormer =
        new(Values.SupervisoryFormer);

    public AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType(string value)
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
    public static AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType FromCustom(
        string value
    )
    {
        return new AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType(value);
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
        AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType value
    ) => value.Value;

    public static explicit operator AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType(
        string value
    ) => new(value);

    internal class AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorTypeSerializer
        : JsonConverter<AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType>
    {
        public override AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType Read(
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
            return new AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType ReadAsPropertyName(
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
            return new AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnualAccountsSetDeclarationsResponseSignaturesItemDirectorType value,
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
