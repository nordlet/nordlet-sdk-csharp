using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[JsonConverter(
    typeof(UpdatePartnersRequestInvoiceCurrency.UpdatePartnersRequestInvoiceCurrencySerializer)
)]
[Serializable]
public readonly record struct UpdatePartnersRequestInvoiceCurrency : IStringEnum
{
    public static readonly UpdatePartnersRequestInvoiceCurrency Eur = new(Values.Eur);

    public static readonly UpdatePartnersRequestInvoiceCurrency Usd = new(Values.Usd);

    public static readonly UpdatePartnersRequestInvoiceCurrency Gbp = new(Values.Gbp);

    public static readonly UpdatePartnersRequestInvoiceCurrency Pln = new(Values.Pln);

    public static readonly UpdatePartnersRequestInvoiceCurrency Sek = new(Values.Sek);

    public static readonly UpdatePartnersRequestInvoiceCurrency Nok = new(Values.Nok);

    public static readonly UpdatePartnersRequestInvoiceCurrency Dkk = new(Values.Dkk);

    public static readonly UpdatePartnersRequestInvoiceCurrency Chf = new(Values.Chf);

    public static readonly UpdatePartnersRequestInvoiceCurrency Czk = new(Values.Czk);

    public static readonly UpdatePartnersRequestInvoiceCurrency Huf = new(Values.Huf);

    public static readonly UpdatePartnersRequestInvoiceCurrency Ron = new(Values.Ron);

    public static readonly UpdatePartnersRequestInvoiceCurrency Aed = new(Values.Aed);

    public static readonly UpdatePartnersRequestInvoiceCurrency Afn = new(Values.Afn);

    public static readonly UpdatePartnersRequestInvoiceCurrency All = new(Values.All);

    public static readonly UpdatePartnersRequestInvoiceCurrency Amd = new(Values.Amd);

    public static readonly UpdatePartnersRequestInvoiceCurrency Ars = new(Values.Ars);

    public static readonly UpdatePartnersRequestInvoiceCurrency Aud = new(Values.Aud);

    public static readonly UpdatePartnersRequestInvoiceCurrency Azn = new(Values.Azn);

    public static readonly UpdatePartnersRequestInvoiceCurrency Bam = new(Values.Bam);

    public static readonly UpdatePartnersRequestInvoiceCurrency Bdt = new(Values.Bdt);

    public static readonly UpdatePartnersRequestInvoiceCurrency Bhd = new(Values.Bhd);

    public static readonly UpdatePartnersRequestInvoiceCurrency Bob = new(Values.Bob);

    public static readonly UpdatePartnersRequestInvoiceCurrency Brl = new(Values.Brl);

    public static readonly UpdatePartnersRequestInvoiceCurrency Byn = new(Values.Byn);

    public static readonly UpdatePartnersRequestInvoiceCurrency Cad = new(Values.Cad);

    public static readonly UpdatePartnersRequestInvoiceCurrency Clp = new(Values.Clp);

    public static readonly UpdatePartnersRequestInvoiceCurrency Cny = new(Values.Cny);

    public static readonly UpdatePartnersRequestInvoiceCurrency Cop = new(Values.Cop);

    public static readonly UpdatePartnersRequestInvoiceCurrency Djf = new(Values.Djf);

    public static readonly UpdatePartnersRequestInvoiceCurrency Dzd = new(Values.Dzd);

    public static readonly UpdatePartnersRequestInvoiceCurrency Egp = new(Values.Egp);

    public static readonly UpdatePartnersRequestInvoiceCurrency Etb = new(Values.Etb);

    public static readonly UpdatePartnersRequestInvoiceCurrency Gel = new(Values.Gel);

    public static readonly UpdatePartnersRequestInvoiceCurrency Gnf = new(Values.Gnf);

    public static readonly UpdatePartnersRequestInvoiceCurrency Hkd = new(Values.Hkd);

    public static readonly UpdatePartnersRequestInvoiceCurrency Idr = new(Values.Idr);

    public static readonly UpdatePartnersRequestInvoiceCurrency Ils = new(Values.Ils);

    public static readonly UpdatePartnersRequestInvoiceCurrency Inr = new(Values.Inr);

    public static readonly UpdatePartnersRequestInvoiceCurrency Iqd = new(Values.Iqd);

    public static readonly UpdatePartnersRequestInvoiceCurrency Irr = new(Values.Irr);

    public static readonly UpdatePartnersRequestInvoiceCurrency Isk = new(Values.Isk);

    public static readonly UpdatePartnersRequestInvoiceCurrency Jod = new(Values.Jod);

    public static readonly UpdatePartnersRequestInvoiceCurrency Jpy = new(Values.Jpy);

    public static readonly UpdatePartnersRequestInvoiceCurrency Kes = new(Values.Kes);

    public static readonly UpdatePartnersRequestInvoiceCurrency Kgs = new(Values.Kgs);

    public static readonly UpdatePartnersRequestInvoiceCurrency Krw = new(Values.Krw);

    public static readonly UpdatePartnersRequestInvoiceCurrency Kwd = new(Values.Kwd);

    public static readonly UpdatePartnersRequestInvoiceCurrency Kzt = new(Values.Kzt);

    public static readonly UpdatePartnersRequestInvoiceCurrency Lbp = new(Values.Lbp);

    public static readonly UpdatePartnersRequestInvoiceCurrency Lkr = new(Values.Lkr);

    public static readonly UpdatePartnersRequestInvoiceCurrency Lyd = new(Values.Lyd);

    public static readonly UpdatePartnersRequestInvoiceCurrency Mad = new(Values.Mad);

    public static readonly UpdatePartnersRequestInvoiceCurrency Mdl = new(Values.Mdl);

    public static readonly UpdatePartnersRequestInvoiceCurrency Mga = new(Values.Mga);

    public static readonly UpdatePartnersRequestInvoiceCurrency Mkd = new(Values.Mkd);

    public static readonly UpdatePartnersRequestInvoiceCurrency Mnt = new(Values.Mnt);

    public static readonly UpdatePartnersRequestInvoiceCurrency Mxn = new(Values.Mxn);

    public static readonly UpdatePartnersRequestInvoiceCurrency Myr = new(Values.Myr);

    public static readonly UpdatePartnersRequestInvoiceCurrency Mzn = new(Values.Mzn);

    public static readonly UpdatePartnersRequestInvoiceCurrency Nzd = new(Values.Nzd);

    public static readonly UpdatePartnersRequestInvoiceCurrency Pab = new(Values.Pab);

    public static readonly UpdatePartnersRequestInvoiceCurrency Pen = new(Values.Pen);

    public static readonly UpdatePartnersRequestInvoiceCurrency Php = new(Values.Php);

    public static readonly UpdatePartnersRequestInvoiceCurrency Pkr = new(Values.Pkr);

    public static readonly UpdatePartnersRequestInvoiceCurrency Qar = new(Values.Qar);

    public static readonly UpdatePartnersRequestInvoiceCurrency Rsd = new(Values.Rsd);

    public static readonly UpdatePartnersRequestInvoiceCurrency Sar = new(Values.Sar);

    public static readonly UpdatePartnersRequestInvoiceCurrency Sgd = new(Values.Sgd);

    public static readonly UpdatePartnersRequestInvoiceCurrency Syp = new(Values.Syp);

    public static readonly UpdatePartnersRequestInvoiceCurrency Thb = new(Values.Thb);

    public static readonly UpdatePartnersRequestInvoiceCurrency Tjs = new(Values.Tjs);

    public static readonly UpdatePartnersRequestInvoiceCurrency Tmt = new(Values.Tmt);

    public static readonly UpdatePartnersRequestInvoiceCurrency Tnd = new(Values.Tnd);

    public static readonly UpdatePartnersRequestInvoiceCurrency Try = new(Values.Try);

    public static readonly UpdatePartnersRequestInvoiceCurrency Twd = new(Values.Twd);

    public static readonly UpdatePartnersRequestInvoiceCurrency Tzs = new(Values.Tzs);

    public static readonly UpdatePartnersRequestInvoiceCurrency Uah = new(Values.Uah);

    public static readonly UpdatePartnersRequestInvoiceCurrency Uyu = new(Values.Uyu);

    public static readonly UpdatePartnersRequestInvoiceCurrency Uzs = new(Values.Uzs);

    public static readonly UpdatePartnersRequestInvoiceCurrency Ves = new(Values.Ves);

    public static readonly UpdatePartnersRequestInvoiceCurrency Vnd = new(Values.Vnd);

    public static readonly UpdatePartnersRequestInvoiceCurrency Xaf = new(Values.Xaf);

    public static readonly UpdatePartnersRequestInvoiceCurrency Xof = new(Values.Xof);

    public static readonly UpdatePartnersRequestInvoiceCurrency Yer = new(Values.Yer);

    public static readonly UpdatePartnersRequestInvoiceCurrency Zar = new(Values.Zar);

    public UpdatePartnersRequestInvoiceCurrency(string value)
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
    public static UpdatePartnersRequestInvoiceCurrency FromCustom(string value)
    {
        return new UpdatePartnersRequestInvoiceCurrency(value);
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

    public static bool operator ==(UpdatePartnersRequestInvoiceCurrency value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdatePartnersRequestInvoiceCurrency value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdatePartnersRequestInvoiceCurrency value) =>
        value.Value;

    public static explicit operator UpdatePartnersRequestInvoiceCurrency(string value) =>
        new(value);

    internal class UpdatePartnersRequestInvoiceCurrencySerializer
        : JsonConverter<UpdatePartnersRequestInvoiceCurrency>
    {
        public override UpdatePartnersRequestInvoiceCurrency Read(
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
            return new UpdatePartnersRequestInvoiceCurrency(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            UpdatePartnersRequestInvoiceCurrency value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override UpdatePartnersRequestInvoiceCurrency ReadAsPropertyName(
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
            return new UpdatePartnersRequestInvoiceCurrency(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            UpdatePartnersRequestInvoiceCurrency value,
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
        public const string Eur = "EUR";

        public const string Usd = "USD";

        public const string Gbp = "GBP";

        public const string Pln = "PLN";

        public const string Sek = "SEK";

        public const string Nok = "NOK";

        public const string Dkk = "DKK";

        public const string Chf = "CHF";

        public const string Czk = "CZK";

        public const string Huf = "HUF";

        public const string Ron = "RON";

        public const string Aed = "AED";

        public const string Afn = "AFN";

        public const string All = "ALL";

        public const string Amd = "AMD";

        public const string Ars = "ARS";

        public const string Aud = "AUD";

        public const string Azn = "AZN";

        public const string Bam = "BAM";

        public const string Bdt = "BDT";

        public const string Bhd = "BHD";

        public const string Bob = "BOB";

        public const string Brl = "BRL";

        public const string Byn = "BYN";

        public const string Cad = "CAD";

        public const string Clp = "CLP";

        public const string Cny = "CNY";

        public const string Cop = "COP";

        public const string Djf = "DJF";

        public const string Dzd = "DZD";

        public const string Egp = "EGP";

        public const string Etb = "ETB";

        public const string Gel = "GEL";

        public const string Gnf = "GNF";

        public const string Hkd = "HKD";

        public const string Idr = "IDR";

        public const string Ils = "ILS";

        public const string Inr = "INR";

        public const string Iqd = "IQD";

        public const string Irr = "IRR";

        public const string Isk = "ISK";

        public const string Jod = "JOD";

        public const string Jpy = "JPY";

        public const string Kes = "KES";

        public const string Kgs = "KGS";

        public const string Krw = "KRW";

        public const string Kwd = "KWD";

        public const string Kzt = "KZT";

        public const string Lbp = "LBP";

        public const string Lkr = "LKR";

        public const string Lyd = "LYD";

        public const string Mad = "MAD";

        public const string Mdl = "MDL";

        public const string Mga = "MGA";

        public const string Mkd = "MKD";

        public const string Mnt = "MNT";

        public const string Mxn = "MXN";

        public const string Myr = "MYR";

        public const string Mzn = "MZN";

        public const string Nzd = "NZD";

        public const string Pab = "PAB";

        public const string Pen = "PEN";

        public const string Php = "PHP";

        public const string Pkr = "PKR";

        public const string Qar = "QAR";

        public const string Rsd = "RSD";

        public const string Sar = "SAR";

        public const string Sgd = "SGD";

        public const string Syp = "SYP";

        public const string Thb = "THB";

        public const string Tjs = "TJS";

        public const string Tmt = "TMT";

        public const string Tnd = "TND";

        public const string Try = "TRY";

        public const string Twd = "TWD";

        public const string Tzs = "TZS";

        public const string Uah = "UAH";

        public const string Uyu = "UYU";

        public const string Uzs = "UZS";

        public const string Ves = "VES";

        public const string Vnd = "VND";

        public const string Xaf = "XAF";

        public const string Xof = "XOF";

        public const string Yer = "YER";

        public const string Zar = "ZAR";
    }
}
