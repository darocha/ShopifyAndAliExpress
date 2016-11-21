﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// An entity representing a Shopify product.
    /// </summary>
    public class ShopifyProduct : ShopifyObject
    {
        /// <summary>
        /// The name of the product. In a shop's catalog, clicking on a product's title takes you to that product's page.
        /// On a product's page, the product's title typically appears in a large font.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The description of the product, complete with HTML formatting.
        /// </summary>
        [JsonProperty("body_html")]
        public string BodyHtml { get; set; }

        /// <summary>
        /// The date and time when the product was created. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("created_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The date and time when the product was last modified. The API returns this value in ISO 8601 format.
        /// </summary>
        [JsonProperty("updated_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The date and time when the product was published. The API returns this value in ISO 8601 format. 
        /// </summary>
        [JsonProperty("published_at", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? PublishedAt { get; set; }

        /// <summary>
        /// Hide a published product by changing the published attribute to false.
        /// </summary>
        [JsonProperty("published", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Published { get; set; } 

        /// <summary>
        /// The name of the vendor of the product.
        /// </summary>
        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// A categorization that a product can be tagged with, commonly used for filtering and searching.
        /// </summary>
        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// A human-friendly unique string for the Product automatically generated from its title.
        /// They are used by the Liquid templating language to refer to objects.
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }

        /// <summary>
        /// The suffix of the liquid template being used.
        /// By default, the original template is called product.liquid, without any suffix.
        /// Any additional templates will be: product.suffix.liquid.
        /// </summary>
        [JsonProperty("template_suffix")]
        public string TemplateSuffix { get; set; }

        /// <summary>
        /// The sales channels in which the product is visible.
        /// </summary>
        [JsonProperty("published_scope")]
        public string PublishedScope { get; set; }

        /// <summary>
        /// A categorization that a product can be tagged with, commonly used for filtering and searching.
        /// Each comma-separated tag has a character limit of 255.
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// A list of variant objects, each one representing a slightly different version of the product.
        /// For example, if a product comes in different sizes and colors, each size and color permutation (such as "small black", "medium black", "large blue"), would be a variant.
        /// To reorder variants, update the product with the variants in the desired order.The position attribute on the variant will be ignored.
        /// </summary>
        [JsonProperty("variants")]
        public IEnumerable<ShopifyProductVariant> Variants { get; set; }

        /// <summary>
        /// Custom product property names like "Size", "Color", and "Material".
        /// Products are based on permutations of these options. 
        /// A product may have a maximum of 3 options. 255 characters limit each.
        /// </summary>
        [JsonProperty("options")]
        public IEnumerable<ShopifyProductOption> Options { get; set; }

        /// <summary>
        /// A list of image objects, each one representing an image associated with the product.
        /// </summary>
        [JsonProperty("images")]
        public IEnumerable<ShopifyProductImage> Images { get; set; }

        /// <summary>
        /// Attaches additional information to a shop's resources.
        /// </summary>
        [JsonProperty("metafields")]
        public IEnumerable<ShopifyMetaField> Metafields { get; set; }
    }
}
