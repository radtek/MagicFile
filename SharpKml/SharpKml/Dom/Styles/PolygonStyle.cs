﻿// Copyright (c) Samuel Cragg.
//
// Licensed under the MIT license. See LICENSE file in the project root for
// full license information.

namespace SharpKml.Dom
{
    using SharpKml.Base;

    /// <summary>
    /// Specifies the drawing style for a <see cref="Polygon"/>, including the
    /// extruded portion of a <c>Polygon</c> or <see cref="LineString"/>.
    /// </summary>
    /// <remarks>OGC KML 2.2 Section 12.12.</remarks>
    [KmlElement("PolyStyle")]
    public class PolygonStyle : ColorStyle
    {
        /// <summary>
        /// The default value that should be used for <see cref="Fill"/>.
        /// </summary>
        public const bool DefaultFill = true;

        /// <summary>
        /// The default value that should be used for <see cref="Outline"/>.
        /// </summary>
        public const bool DefaultOutline = true;

        /// <summary>
        /// Gets or sets whether to fill the polygon.
        /// </summary>
        [KmlElement("fill", 1)]
        public bool? Fill { get; set; }

        /// <summary>
        /// Gets or sets whether to draw the polygon boundaries.
        /// </summary>
        [KmlElement("outline", 2)]
        public bool? Outline { get; set; }
    }
}
