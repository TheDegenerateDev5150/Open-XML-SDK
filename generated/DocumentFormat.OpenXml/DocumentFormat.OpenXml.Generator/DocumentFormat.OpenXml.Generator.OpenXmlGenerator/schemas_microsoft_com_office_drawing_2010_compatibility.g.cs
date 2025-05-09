﻿// <auto-generated/>

// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#nullable enable

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Framework;
using DocumentFormat.OpenXml.Framework.Metadata;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Validation.Schema;
using System;
using System.Collections.Generic;
using System.IO.Packaging;

namespace DocumentFormat.OpenXml.Office2010.Drawing.LegacyCompatibility
{
    /// <summary>
    /// <para>Defines the CompatibilityShape Class.</para>
    /// <para>This class is available in Office 2010 and above.</para>
    /// <para>When the object is serialized out as xml, it's qualified name is com14:compatSp.</para>
    /// </summary>
    public partial class CompatibilityShape : OpenXmlLeafElement
    {
        #pragma warning disable CS0109
        internal static readonly new OpenXmlQualifiedName ElementQName = new("http://schemas.microsoft.com/office/drawing/2010/compatibility", "compatSp");
        internal static readonly new OpenXmlQualifiedName ElementTypeName = new("http://schemas.microsoft.com/office/drawing/2010/compatibility", "CT_CompatShape");
        internal static readonly new OpenXmlSchemaType ElementType = new(ElementQName, ElementTypeName);
        #pragma warning restore CS0109

        /// <summary>
        /// Initializes a new instance of the CompatibilityShape class.
        /// </summary>
        public CompatibilityShape() : base()
        {
        }

        /// <summary>
        /// <para>spid, this property is only available in Office 2010 and later.</para>
        /// <para>Represents the following attribute in the schema: spid</para>
        /// </summary>
        public StringValue? ShapeId
        {
            get => GetAttribute<StringValue>();
            set => SetAttribute(value);
        }

        internal override void ConfigureMetadata(ElementMetadata.Builder builder)
        {
            base.ConfigureMetadata(builder);
            builder.SetSchema(ElementType);
            builder.Availability = FileFormatVersions.Office2010;
            builder.AddElement<CompatibilityShape>()
                .AddAttribute("spid", a => a.ShapeId, aBuilder =>
                {
                    aBuilder.AddValidator(RequiredValidator.Instance);
                    aBuilder.AddValidator(new StringValidator() { IsToken = (true) });
                });
        }

        /// <inheritdoc/>
        public override OpenXmlElement CloneNode(bool deep) => CloneImp<CompatibilityShape>(deep);
    }
}