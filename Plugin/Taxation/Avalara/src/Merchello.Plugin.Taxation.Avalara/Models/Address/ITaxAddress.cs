﻿namespace Merchello.Plugin.Taxation.Avalara.Models.Address
{
    /// <summary>
    /// Defines a TaxAddress used in tax requests.
    /// </summary>
    public interface ITaxAddress : IValidatableAddress
    {
        /// <summary>
        /// Gets or sets the latitude of the address (Optional)
        /// </summary>
        decimal Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude of the address (Optional)
        /// </summary>
        decimal Longitude { get; set; }

        /// <summary>
        /// Gets or sets the tax region id (Optional)
        /// </summary>
        int TaxRegionId { get; set; }
    }
}