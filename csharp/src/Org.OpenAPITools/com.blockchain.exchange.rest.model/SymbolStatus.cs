/* 
 * Blockchain.com Exchange REST API
 *
 * ## Introduction Welcome to Blockchain.com's Exchange API and developer documentation. \\ These documents detail and give examples of various functionality offered by the API such as receiving real time market data, requesting balance information and performing trades. ## To Get Started Create or log into your existing Blockchain.com Exchange account \\ Select API from the drop down menu \\ Fill out form and click “Create New API Key Now” \\ Once generated you can view your keys under API Settings. \\ Please be aware that the API key can only be used once it was verified via email.  The API key must be set via the \\ `X-API-Token`\\ header.  The base URL to be used for all calls is \\ `https://api.blockchain.com/v3/exchange`  Autogenerated clients for this API can be found [here](https://github.com/blockchain/lib-exchange-client). 
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.com.blockchain.exchange.rest.model
{
    /// <summary>
    /// SymbolStatus
    /// </summary>
    [DataContract]
    public partial class SymbolStatus :  IEquatable<SymbolStatus>, IValidatableObject
    {
        /// <summary>
        /// Symbol status; open, close, suspend, halt, halt-freeze.
        /// </summary>
        /// <value>Symbol status; open, close, suspend, halt, halt-freeze.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Open for value: open
            /// </summary>
            [EnumMember(Value = "open")]
            Open = 1,

            /// <summary>
            /// Enum Close for value: close
            /// </summary>
            [EnumMember(Value = "close")]
            Close = 2,

            /// <summary>
            /// Enum Suspend for value: suspend
            /// </summary>
            [EnumMember(Value = "suspend")]
            Suspend = 3,

            /// <summary>
            /// Enum Halt for value: halt
            /// </summary>
            [EnumMember(Value = "halt")]
            Halt = 4,

            /// <summary>
            /// Enum HaltFreeze for value: halt-freeze
            /// </summary>
            [EnumMember(Value = "halt-freeze")]
            HaltFreeze = 5

        }

        /// <summary>
        /// Symbol status; open, close, suspend, halt, halt-freeze.
        /// </summary>
        /// <value>Symbol status; open, close, suspend, halt, halt-freeze.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SymbolStatus" /> class.
        /// </summary>
        /// <param name="baseCurrency">Blockchain symbol identifier.</param>
        /// <param name="baseCurrencyScale">The number of decimals the currency can be split in.</param>
        /// <param name="counterCurrency">Blockchain symbol identifier.</param>
        /// <param name="counterCurrencyScale">The number of decimals the currency can be split in.</param>
        /// <param name="minPriceIncrement">The price of the instrument must be a multiple of min_price_increment * (10^-min_price_increment_scale).</param>
        /// <param name="minPriceIncrementScale">minPriceIncrementScale.</param>
        /// <param name="minOrderSize">The minimum quantity for an order for this instrument must be min_order_size*(10^-min_order_size_scale).</param>
        /// <param name="minOrderSizeScale">minOrderSizeScale.</param>
        /// <param name="maxOrderSize">The maximum quantity for an order for this instrument is max_order_size*(10^-max_order_size_scale). If this equal to zero, there is no limit.</param>
        /// <param name="maxOrderSizeScale">maxOrderSizeScale.</param>
        /// <param name="lotSize">lotSize.</param>
        /// <param name="lotSizeScale">lotSizeScale.</param>
        /// <param name="status">Symbol status; open, close, suspend, halt, halt-freeze..</param>
        /// <param name="id">id.</param>
        /// <param name="auctionPrice">If the symbol is halted and will open on an auction, this will be the opening price..</param>
        /// <param name="auctionSize">Opening size.</param>
        /// <param name="auctionTime">Opening time in HHMM format.</param>
        /// <param name="imbalance">Auction imbalance. If &gt; 0 then there will be buy orders left over at the auction price. If &lt; 0 then there will be sell orders left over at the auction price..</param>
        public SymbolStatus(string baseCurrency = default(string), int baseCurrencyScale = default(int), string counterCurrency = default(string), int counterCurrencyScale = default(int), long minPriceIncrement = default(long), int minPriceIncrementScale = default(int), long minOrderSize = default(long), int minOrderSizeScale = default(int), long maxOrderSize = default(long), int maxOrderSizeScale = default(int), long lotSize = default(long), int lotSizeScale = default(int), StatusEnum? status = default(StatusEnum?), long id = default(long), double auctionPrice = default(double), double auctionSize = default(double), string auctionTime = default(string), double imbalance = default(double))
        {
            this.BaseCurrency = baseCurrency;
            this.BaseCurrencyScale = baseCurrencyScale;
            this.CounterCurrency = counterCurrency;
            this.CounterCurrencyScale = counterCurrencyScale;
            this.MinPriceIncrement = minPriceIncrement;
            this.MinPriceIncrementScale = minPriceIncrementScale;
            this.MinOrderSize = minOrderSize;
            this.MinOrderSizeScale = minOrderSizeScale;
            this.MaxOrderSize = maxOrderSize;
            this.MaxOrderSizeScale = maxOrderSizeScale;
            this.LotSize = lotSize;
            this.LotSizeScale = lotSizeScale;
            this.Status = status;
            this.Id = id;
            this.AuctionPrice = auctionPrice;
            this.AuctionSize = auctionSize;
            this.AuctionTime = auctionTime;
            this.Imbalance = imbalance;
        }
        
        /// <summary>
        /// Blockchain symbol identifier
        /// </summary>
        /// <value>Blockchain symbol identifier</value>
        [DataMember(Name="base_currency", EmitDefaultValue=false)]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// The number of decimals the currency can be split in
        /// </summary>
        /// <value>The number of decimals the currency can be split in</value>
        [DataMember(Name="base_currency_scale", EmitDefaultValue=false)]
        public int BaseCurrencyScale { get; set; }

        /// <summary>
        /// Blockchain symbol identifier
        /// </summary>
        /// <value>Blockchain symbol identifier</value>
        [DataMember(Name="counter_currency", EmitDefaultValue=false)]
        public string CounterCurrency { get; set; }

        /// <summary>
        /// The number of decimals the currency can be split in
        /// </summary>
        /// <value>The number of decimals the currency can be split in</value>
        [DataMember(Name="counter_currency_scale", EmitDefaultValue=false)]
        public int CounterCurrencyScale { get; set; }

        /// <summary>
        /// The price of the instrument must be a multiple of min_price_increment * (10^-min_price_increment_scale)
        /// </summary>
        /// <value>The price of the instrument must be a multiple of min_price_increment * (10^-min_price_increment_scale)</value>
        [DataMember(Name="min_price_increment", EmitDefaultValue=false)]
        public long MinPriceIncrement { get; set; }

        /// <summary>
        /// Gets or Sets MinPriceIncrementScale
        /// </summary>
        [DataMember(Name="min_price_increment_scale", EmitDefaultValue=false)]
        public int MinPriceIncrementScale { get; set; }

        /// <summary>
        /// The minimum quantity for an order for this instrument must be min_order_size*(10^-min_order_size_scale)
        /// </summary>
        /// <value>The minimum quantity for an order for this instrument must be min_order_size*(10^-min_order_size_scale)</value>
        [DataMember(Name="min_order_size", EmitDefaultValue=false)]
        public long MinOrderSize { get; set; }

        /// <summary>
        /// Gets or Sets MinOrderSizeScale
        /// </summary>
        [DataMember(Name="min_order_size_scale", EmitDefaultValue=false)]
        public int MinOrderSizeScale { get; set; }

        /// <summary>
        /// The maximum quantity for an order for this instrument is max_order_size*(10^-max_order_size_scale). If this equal to zero, there is no limit
        /// </summary>
        /// <value>The maximum quantity for an order for this instrument is max_order_size*(10^-max_order_size_scale). If this equal to zero, there is no limit</value>
        [DataMember(Name="max_order_size", EmitDefaultValue=false)]
        public long MaxOrderSize { get; set; }

        /// <summary>
        /// Gets or Sets MaxOrderSizeScale
        /// </summary>
        [DataMember(Name="max_order_size_scale", EmitDefaultValue=false)]
        public int MaxOrderSizeScale { get; set; }

        /// <summary>
        /// Gets or Sets LotSize
        /// </summary>
        [DataMember(Name="lot_size", EmitDefaultValue=false)]
        public long LotSize { get; set; }

        /// <summary>
        /// Gets or Sets LotSizeScale
        /// </summary>
        [DataMember(Name="lot_size_scale", EmitDefaultValue=false)]
        public int LotSizeScale { get; set; }


        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// If the symbol is halted and will open on an auction, this will be the opening price.
        /// </summary>
        /// <value>If the symbol is halted and will open on an auction, this will be the opening price.</value>
        [DataMember(Name="auction_price", EmitDefaultValue=false)]
        public double AuctionPrice { get; set; }

        /// <summary>
        /// Opening size
        /// </summary>
        /// <value>Opening size</value>
        [DataMember(Name="auction_size", EmitDefaultValue=false)]
        public double AuctionSize { get; set; }

        /// <summary>
        /// Opening time in HHMM format
        /// </summary>
        /// <value>Opening time in HHMM format</value>
        [DataMember(Name="auction_time", EmitDefaultValue=false)]
        public string AuctionTime { get; set; }

        /// <summary>
        /// Auction imbalance. If &gt; 0 then there will be buy orders left over at the auction price. If &lt; 0 then there will be sell orders left over at the auction price.
        /// </summary>
        /// <value>Auction imbalance. If &gt; 0 then there will be buy orders left over at the auction price. If &lt; 0 then there will be sell orders left over at the auction price.</value>
        [DataMember(Name="imbalance", EmitDefaultValue=false)]
        public double Imbalance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SymbolStatus {\n");
            sb.Append("  BaseCurrency: ").Append(BaseCurrency).Append("\n");
            sb.Append("  BaseCurrencyScale: ").Append(BaseCurrencyScale).Append("\n");
            sb.Append("  CounterCurrency: ").Append(CounterCurrency).Append("\n");
            sb.Append("  CounterCurrencyScale: ").Append(CounterCurrencyScale).Append("\n");
            sb.Append("  MinPriceIncrement: ").Append(MinPriceIncrement).Append("\n");
            sb.Append("  MinPriceIncrementScale: ").Append(MinPriceIncrementScale).Append("\n");
            sb.Append("  MinOrderSize: ").Append(MinOrderSize).Append("\n");
            sb.Append("  MinOrderSizeScale: ").Append(MinOrderSizeScale).Append("\n");
            sb.Append("  MaxOrderSize: ").Append(MaxOrderSize).Append("\n");
            sb.Append("  MaxOrderSizeScale: ").Append(MaxOrderSizeScale).Append("\n");
            sb.Append("  LotSize: ").Append(LotSize).Append("\n");
            sb.Append("  LotSizeScale: ").Append(LotSizeScale).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AuctionPrice: ").Append(AuctionPrice).Append("\n");
            sb.Append("  AuctionSize: ").Append(AuctionSize).Append("\n");
            sb.Append("  AuctionTime: ").Append(AuctionTime).Append("\n");
            sb.Append("  Imbalance: ").Append(Imbalance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SymbolStatus);
        }

        /// <summary>
        /// Returns true if SymbolStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of SymbolStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SymbolStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BaseCurrency == input.BaseCurrency ||
                    (this.BaseCurrency != null &&
                    this.BaseCurrency.Equals(input.BaseCurrency))
                ) && 
                (
                    this.BaseCurrencyScale == input.BaseCurrencyScale ||
                    (this.BaseCurrencyScale != null &&
                    this.BaseCurrencyScale.Equals(input.BaseCurrencyScale))
                ) && 
                (
                    this.CounterCurrency == input.CounterCurrency ||
                    (this.CounterCurrency != null &&
                    this.CounterCurrency.Equals(input.CounterCurrency))
                ) && 
                (
                    this.CounterCurrencyScale == input.CounterCurrencyScale ||
                    (this.CounterCurrencyScale != null &&
                    this.CounterCurrencyScale.Equals(input.CounterCurrencyScale))
                ) && 
                (
                    this.MinPriceIncrement == input.MinPriceIncrement ||
                    (this.MinPriceIncrement != null &&
                    this.MinPriceIncrement.Equals(input.MinPriceIncrement))
                ) && 
                (
                    this.MinPriceIncrementScale == input.MinPriceIncrementScale ||
                    (this.MinPriceIncrementScale != null &&
                    this.MinPriceIncrementScale.Equals(input.MinPriceIncrementScale))
                ) && 
                (
                    this.MinOrderSize == input.MinOrderSize ||
                    (this.MinOrderSize != null &&
                    this.MinOrderSize.Equals(input.MinOrderSize))
                ) && 
                (
                    this.MinOrderSizeScale == input.MinOrderSizeScale ||
                    (this.MinOrderSizeScale != null &&
                    this.MinOrderSizeScale.Equals(input.MinOrderSizeScale))
                ) && 
                (
                    this.MaxOrderSize == input.MaxOrderSize ||
                    (this.MaxOrderSize != null &&
                    this.MaxOrderSize.Equals(input.MaxOrderSize))
                ) && 
                (
                    this.MaxOrderSizeScale == input.MaxOrderSizeScale ||
                    (this.MaxOrderSizeScale != null &&
                    this.MaxOrderSizeScale.Equals(input.MaxOrderSizeScale))
                ) && 
                (
                    this.LotSize == input.LotSize ||
                    (this.LotSize != null &&
                    this.LotSize.Equals(input.LotSize))
                ) && 
                (
                    this.LotSizeScale == input.LotSizeScale ||
                    (this.LotSizeScale != null &&
                    this.LotSizeScale.Equals(input.LotSizeScale))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AuctionPrice == input.AuctionPrice ||
                    (this.AuctionPrice != null &&
                    this.AuctionPrice.Equals(input.AuctionPrice))
                ) && 
                (
                    this.AuctionSize == input.AuctionSize ||
                    (this.AuctionSize != null &&
                    this.AuctionSize.Equals(input.AuctionSize))
                ) && 
                (
                    this.AuctionTime == input.AuctionTime ||
                    (this.AuctionTime != null &&
                    this.AuctionTime.Equals(input.AuctionTime))
                ) && 
                (
                    this.Imbalance == input.Imbalance ||
                    (this.Imbalance != null &&
                    this.Imbalance.Equals(input.Imbalance))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.BaseCurrency != null)
                    hashCode = hashCode * 59 + this.BaseCurrency.GetHashCode();
                if (this.BaseCurrencyScale != null)
                    hashCode = hashCode * 59 + this.BaseCurrencyScale.GetHashCode();
                if (this.CounterCurrency != null)
                    hashCode = hashCode * 59 + this.CounterCurrency.GetHashCode();
                if (this.CounterCurrencyScale != null)
                    hashCode = hashCode * 59 + this.CounterCurrencyScale.GetHashCode();
                if (this.MinPriceIncrement != null)
                    hashCode = hashCode * 59 + this.MinPriceIncrement.GetHashCode();
                if (this.MinPriceIncrementScale != null)
                    hashCode = hashCode * 59 + this.MinPriceIncrementScale.GetHashCode();
                if (this.MinOrderSize != null)
                    hashCode = hashCode * 59 + this.MinOrderSize.GetHashCode();
                if (this.MinOrderSizeScale != null)
                    hashCode = hashCode * 59 + this.MinOrderSizeScale.GetHashCode();
                if (this.MaxOrderSize != null)
                    hashCode = hashCode * 59 + this.MaxOrderSize.GetHashCode();
                if (this.MaxOrderSizeScale != null)
                    hashCode = hashCode * 59 + this.MaxOrderSizeScale.GetHashCode();
                if (this.LotSize != null)
                    hashCode = hashCode * 59 + this.LotSize.GetHashCode();
                if (this.LotSizeScale != null)
                    hashCode = hashCode * 59 + this.LotSizeScale.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AuctionPrice != null)
                    hashCode = hashCode * 59 + this.AuctionPrice.GetHashCode();
                if (this.AuctionSize != null)
                    hashCode = hashCode * 59 + this.AuctionSize.GetHashCode();
                if (this.AuctionTime != null)
                    hashCode = hashCode * 59 + this.AuctionTime.GetHashCode();
                if (this.Imbalance != null)
                    hashCode = hashCode * 59 + this.Imbalance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {

            
            // BaseCurrency (string) pattern
            Regex regexBaseCurrency = new Regex(@"^[A-Z]{3,5}-[A-Z]{3,5}$", RegexOptions.CultureInvariant);
            if (false == regexBaseCurrency.Match(this.BaseCurrency).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BaseCurrency, must match a pattern of " + regexBaseCurrency, new [] { "BaseCurrency" });
            }


            
            // CounterCurrency (string) pattern
            Regex regexCounterCurrency = new Regex(@"^[A-Z]{3,5}-[A-Z]{3,5}$", RegexOptions.CultureInvariant);
            if (false == regexCounterCurrency.Match(this.CounterCurrency).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CounterCurrency, must match a pattern of " + regexCounterCurrency, new [] { "CounterCurrency" });
            }

            yield break;
        }
    }

}
