﻿// Copyright (c) Samuel Cragg.
//
// Licensed under the MIT license. See LICENSE file in the project root for
// full license information.

namespace SharpKml.Dom
{
    using SharpKml.Base;

    /// <summary>
    /// Specifies the extent of a 2D bounding box.
    /// </summary>
    /// <remarks>OGC KML 2.2 Section 11.3.</remarks>
    [KmlElement("LatLonBox")]
    public class LatLonBox : AbstractLatLonBox
    {
        /// <summary>
        /// Gets or sets a rotation of the overlay about its center, in decimal
        /// degrees.
        /// </summary>
        /// <remarks>
        /// Values can be ±180, with 0 being North. Rotations are specified in
        /// a counterclockwise direction.
        /// </remarks>
        [KmlElement("rotation", 1)]
        public double? Rotation { get; set; }
    }
}
