using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(BankAccountsListPartnersResponseRowsItemAccountType.BankAccountsListPartnersResponseRowsItemAccountTypeSerializer)
)]
[Serializable]
public readonly record struct BankAccountsListPartnersResponseRowsItemAccountType : IStringEnum
{
    public static readonly BankAccountsListPartnersResponseRowsItemAccountType Checking = new(
        Values.Checking
    );

    public static readonly BankAccountsListPartnersResponseRowsItemAccountType Savings = new(
        Values.Savings
    );

    public BankAccountsListPartnersResponseRowsItemAccountType(string value)
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
    public static BankAccountsListPartnersResponseRowsItemAccountType FromCustom(string value)
    {
        return new BankAccountsListPartnersResponseRowsItemAccountType(value);
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
        BankAccountsListPartnersResponseRowsItemAccountType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        BankAccountsListPartnersResponseRowsItemAccountType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        BankAccountsListPartnersResponseRowsItemAccountType value
    ) => value.Value;

    public static explicit operator BankAccountsListPartnersResponseRowsItemAccountType(
        string value
    ) => new(value);

    internal class BankAccountsListPartnersResponseRowsItemAccountTypeSerializer
        : JsonConverter<BankAccountsListPartnersResponseRowsItemAccountType>
    {
        public override BankAccountsListPartnersResponseRowsItemAccountType Read(
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
            return new BankAccountsListPartnersResponseRowsItemAccountType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            BankAccountsListPartnersResponseRowsItemAccountType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override BankAccountsListPartnersResponseRowsItemAccountType ReadAsPropertyName(
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
            return new BankAccountsListPartnersResponseRowsItemAccountType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            BankAccountsListPartnersResponseRowsItemAccountType value,
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
        public const string Checking = "checking";

        public const string Savings = "savings";
    }
}
