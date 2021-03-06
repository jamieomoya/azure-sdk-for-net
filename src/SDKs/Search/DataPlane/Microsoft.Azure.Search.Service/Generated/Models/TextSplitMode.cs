// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TextSplitMode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextSplitMode
    {
        [EnumMember(Value = "pages")]
        Pages,
        [EnumMember(Value = "sentences")]
        Sentences
    }
    internal static class TextSplitModeEnumExtension
    {
        internal static string ToSerializedValue(this TextSplitMode? value)
        {
            return value == null ? null : ((TextSplitMode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TextSplitMode value)
        {
            switch( value )
            {
                case TextSplitMode.Pages:
                    return "pages";
                case TextSplitMode.Sentences:
                    return "sentences";
            }
            return null;
        }

        internal static TextSplitMode? ParseTextSplitMode(this string value)
        {
            switch( value )
            {
                case "pages":
                    return TextSplitMode.Pages;
                case "sentences":
                    return TextSplitMode.Sentences;
            }
            return null;
        }
    }
}
