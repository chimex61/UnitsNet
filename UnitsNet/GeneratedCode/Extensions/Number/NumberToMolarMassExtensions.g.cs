﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToMolarMass
{
    public static class NumberToMolarMassExtensions
    {
        #region CentigramPerMole

        /// <inheritdoc cref="MolarMass.FromCentigramsPerMole(double)"/>
        public static MolarMass CentigramsPerMole(this int value) => MolarMass.FromCentigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromCentigramsPerMole(double?)"/>
        public static MolarMass? CentigramsPerMole(this int? value) => MolarMass.FromCentigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromCentigramsPerMole(double)"/>
        public static MolarMass CentigramsPerMole(this long value) => MolarMass.FromCentigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromCentigramsPerMole(double?)"/>
        public static MolarMass? CentigramsPerMole(this long? value) => MolarMass.FromCentigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromCentigramsPerMole(double)"/>
        public static MolarMass CentigramsPerMole(this double value) => MolarMass.FromCentigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromCentigramsPerMole(double?)"/>
        public static MolarMass? CentigramsPerMole(this double? value) => MolarMass.FromCentigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromCentigramsPerMole(double)"/>
        public static MolarMass CentigramsPerMole(this float value) => MolarMass.FromCentigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromCentigramsPerMole(double?)"/>
        public static MolarMass? CentigramsPerMole(this float? value) => MolarMass.FromCentigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromCentigramsPerMole(double)"/>
        public static MolarMass CentigramsPerMole(this decimal value) => MolarMass.FromCentigramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromCentigramsPerMole(double?)"/>
        public static MolarMass? CentigramsPerMole(this decimal? value) => MolarMass.FromCentigramsPerMole(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecagramPerMole

        /// <inheritdoc cref="MolarMass.FromDecagramsPerMole(double)"/>
        public static MolarMass DecagramsPerMole(this int value) => MolarMass.FromDecagramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecagramsPerMole(double?)"/>
        public static MolarMass? DecagramsPerMole(this int? value) => MolarMass.FromDecagramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecagramsPerMole(double)"/>
        public static MolarMass DecagramsPerMole(this long value) => MolarMass.FromDecagramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecagramsPerMole(double?)"/>
        public static MolarMass? DecagramsPerMole(this long? value) => MolarMass.FromDecagramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecagramsPerMole(double)"/>
        public static MolarMass DecagramsPerMole(this double value) => MolarMass.FromDecagramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecagramsPerMole(double?)"/>
        public static MolarMass? DecagramsPerMole(this double? value) => MolarMass.FromDecagramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecagramsPerMole(double)"/>
        public static MolarMass DecagramsPerMole(this float value) => MolarMass.FromDecagramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecagramsPerMole(double?)"/>
        public static MolarMass? DecagramsPerMole(this float? value) => MolarMass.FromDecagramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecagramsPerMole(double)"/>
        public static MolarMass DecagramsPerMole(this decimal value) => MolarMass.FromDecagramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromDecagramsPerMole(double?)"/>
        public static MolarMass? DecagramsPerMole(this decimal? value) => MolarMass.FromDecagramsPerMole(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecigramPerMole

        /// <inheritdoc cref="MolarMass.FromDecigramsPerMole(double)"/>
        public static MolarMass DecigramsPerMole(this int value) => MolarMass.FromDecigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecigramsPerMole(double?)"/>
        public static MolarMass? DecigramsPerMole(this int? value) => MolarMass.FromDecigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecigramsPerMole(double)"/>
        public static MolarMass DecigramsPerMole(this long value) => MolarMass.FromDecigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecigramsPerMole(double?)"/>
        public static MolarMass? DecigramsPerMole(this long? value) => MolarMass.FromDecigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecigramsPerMole(double)"/>
        public static MolarMass DecigramsPerMole(this double value) => MolarMass.FromDecigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecigramsPerMole(double?)"/>
        public static MolarMass? DecigramsPerMole(this double? value) => MolarMass.FromDecigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecigramsPerMole(double)"/>
        public static MolarMass DecigramsPerMole(this float value) => MolarMass.FromDecigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecigramsPerMole(double?)"/>
        public static MolarMass? DecigramsPerMole(this float? value) => MolarMass.FromDecigramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromDecigramsPerMole(double)"/>
        public static MolarMass DecigramsPerMole(this decimal value) => MolarMass.FromDecigramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromDecigramsPerMole(double?)"/>
        public static MolarMass? DecigramsPerMole(this decimal? value) => MolarMass.FromDecigramsPerMole(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region GramPerMole

        /// <inheritdoc cref="MolarMass.FromGramsPerMole(double)"/>
        public static MolarMass GramsPerMole(this int value) => MolarMass.FromGramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromGramsPerMole(double?)"/>
        public static MolarMass? GramsPerMole(this int? value) => MolarMass.FromGramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromGramsPerMole(double)"/>
        public static MolarMass GramsPerMole(this long value) => MolarMass.FromGramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromGramsPerMole(double?)"/>
        public static MolarMass? GramsPerMole(this long? value) => MolarMass.FromGramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromGramsPerMole(double)"/>
        public static MolarMass GramsPerMole(this double value) => MolarMass.FromGramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromGramsPerMole(double?)"/>
        public static MolarMass? GramsPerMole(this double? value) => MolarMass.FromGramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromGramsPerMole(double)"/>
        public static MolarMass GramsPerMole(this float value) => MolarMass.FromGramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromGramsPerMole(double?)"/>
        public static MolarMass? GramsPerMole(this float? value) => MolarMass.FromGramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromGramsPerMole(double)"/>
        public static MolarMass GramsPerMole(this decimal value) => MolarMass.FromGramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromGramsPerMole(double?)"/>
        public static MolarMass? GramsPerMole(this decimal? value) => MolarMass.FromGramsPerMole(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region HectogramPerMole

        /// <inheritdoc cref="MolarMass.FromHectogramsPerMole(double)"/>
        public static MolarMass HectogramsPerMole(this int value) => MolarMass.FromHectogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromHectogramsPerMole(double?)"/>
        public static MolarMass? HectogramsPerMole(this int? value) => MolarMass.FromHectogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromHectogramsPerMole(double)"/>
        public static MolarMass HectogramsPerMole(this long value) => MolarMass.FromHectogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromHectogramsPerMole(double?)"/>
        public static MolarMass? HectogramsPerMole(this long? value) => MolarMass.FromHectogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromHectogramsPerMole(double)"/>
        public static MolarMass HectogramsPerMole(this double value) => MolarMass.FromHectogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromHectogramsPerMole(double?)"/>
        public static MolarMass? HectogramsPerMole(this double? value) => MolarMass.FromHectogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromHectogramsPerMole(double)"/>
        public static MolarMass HectogramsPerMole(this float value) => MolarMass.FromHectogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromHectogramsPerMole(double?)"/>
        public static MolarMass? HectogramsPerMole(this float? value) => MolarMass.FromHectogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromHectogramsPerMole(double)"/>
        public static MolarMass HectogramsPerMole(this decimal value) => MolarMass.FromHectogramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromHectogramsPerMole(double?)"/>
        public static MolarMass? HectogramsPerMole(this decimal? value) => MolarMass.FromHectogramsPerMole(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramPerMole

        /// <inheritdoc cref="MolarMass.FromKilogramsPerMole(double)"/>
        public static MolarMass KilogramsPerMole(this int value) => MolarMass.FromKilogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilogramsPerMole(double?)"/>
        public static MolarMass? KilogramsPerMole(this int? value) => MolarMass.FromKilogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilogramsPerMole(double)"/>
        public static MolarMass KilogramsPerMole(this long value) => MolarMass.FromKilogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilogramsPerMole(double?)"/>
        public static MolarMass? KilogramsPerMole(this long? value) => MolarMass.FromKilogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilogramsPerMole(double)"/>
        public static MolarMass KilogramsPerMole(this double value) => MolarMass.FromKilogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilogramsPerMole(double?)"/>
        public static MolarMass? KilogramsPerMole(this double? value) => MolarMass.FromKilogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilogramsPerMole(double)"/>
        public static MolarMass KilogramsPerMole(this float value) => MolarMass.FromKilogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilogramsPerMole(double?)"/>
        public static MolarMass? KilogramsPerMole(this float? value) => MolarMass.FromKilogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilogramsPerMole(double)"/>
        public static MolarMass KilogramsPerMole(this decimal value) => MolarMass.FromKilogramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromKilogramsPerMole(double?)"/>
        public static MolarMass? KilogramsPerMole(this decimal? value) => MolarMass.FromKilogramsPerMole(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilopoundPerMole

        /// <inheritdoc cref="MolarMass.FromKilopoundsPerMole(double)"/>
        public static MolarMass KilopoundsPerMole(this int value) => MolarMass.FromKilopoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilopoundsPerMole(double?)"/>
        public static MolarMass? KilopoundsPerMole(this int? value) => MolarMass.FromKilopoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilopoundsPerMole(double)"/>
        public static MolarMass KilopoundsPerMole(this long value) => MolarMass.FromKilopoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilopoundsPerMole(double?)"/>
        public static MolarMass? KilopoundsPerMole(this long? value) => MolarMass.FromKilopoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilopoundsPerMole(double)"/>
        public static MolarMass KilopoundsPerMole(this double value) => MolarMass.FromKilopoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilopoundsPerMole(double?)"/>
        public static MolarMass? KilopoundsPerMole(this double? value) => MolarMass.FromKilopoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilopoundsPerMole(double)"/>
        public static MolarMass KilopoundsPerMole(this float value) => MolarMass.FromKilopoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilopoundsPerMole(double?)"/>
        public static MolarMass? KilopoundsPerMole(this float? value) => MolarMass.FromKilopoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromKilopoundsPerMole(double)"/>
        public static MolarMass KilopoundsPerMole(this decimal value) => MolarMass.FromKilopoundsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromKilopoundsPerMole(double?)"/>
        public static MolarMass? KilopoundsPerMole(this decimal? value) => MolarMass.FromKilopoundsPerMole(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegapoundPerMole

        /// <inheritdoc cref="MolarMass.FromMegapoundsPerMole(double)"/>
        public static MolarMass MegapoundsPerMole(this int value) => MolarMass.FromMegapoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMegapoundsPerMole(double?)"/>
        public static MolarMass? MegapoundsPerMole(this int? value) => MolarMass.FromMegapoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMegapoundsPerMole(double)"/>
        public static MolarMass MegapoundsPerMole(this long value) => MolarMass.FromMegapoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMegapoundsPerMole(double?)"/>
        public static MolarMass? MegapoundsPerMole(this long? value) => MolarMass.FromMegapoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMegapoundsPerMole(double)"/>
        public static MolarMass MegapoundsPerMole(this double value) => MolarMass.FromMegapoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMegapoundsPerMole(double?)"/>
        public static MolarMass? MegapoundsPerMole(this double? value) => MolarMass.FromMegapoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMegapoundsPerMole(double)"/>
        public static MolarMass MegapoundsPerMole(this float value) => MolarMass.FromMegapoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMegapoundsPerMole(double?)"/>
        public static MolarMass? MegapoundsPerMole(this float? value) => MolarMass.FromMegapoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMegapoundsPerMole(double)"/>
        public static MolarMass MegapoundsPerMole(this decimal value) => MolarMass.FromMegapoundsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromMegapoundsPerMole(double?)"/>
        public static MolarMass? MegapoundsPerMole(this decimal? value) => MolarMass.FromMegapoundsPerMole(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicrogramPerMole

        /// <inheritdoc cref="MolarMass.FromMicrogramsPerMole(double)"/>
        public static MolarMass MicrogramsPerMole(this int value) => MolarMass.FromMicrogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMicrogramsPerMole(double?)"/>
        public static MolarMass? MicrogramsPerMole(this int? value) => MolarMass.FromMicrogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMicrogramsPerMole(double)"/>
        public static MolarMass MicrogramsPerMole(this long value) => MolarMass.FromMicrogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMicrogramsPerMole(double?)"/>
        public static MolarMass? MicrogramsPerMole(this long? value) => MolarMass.FromMicrogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMicrogramsPerMole(double)"/>
        public static MolarMass MicrogramsPerMole(this double value) => MolarMass.FromMicrogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMicrogramsPerMole(double?)"/>
        public static MolarMass? MicrogramsPerMole(this double? value) => MolarMass.FromMicrogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMicrogramsPerMole(double)"/>
        public static MolarMass MicrogramsPerMole(this float value) => MolarMass.FromMicrogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMicrogramsPerMole(double?)"/>
        public static MolarMass? MicrogramsPerMole(this float? value) => MolarMass.FromMicrogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMicrogramsPerMole(double)"/>
        public static MolarMass MicrogramsPerMole(this decimal value) => MolarMass.FromMicrogramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromMicrogramsPerMole(double?)"/>
        public static MolarMass? MicrogramsPerMole(this decimal? value) => MolarMass.FromMicrogramsPerMole(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MilligramPerMole

        /// <inheritdoc cref="MolarMass.FromMilligramsPerMole(double)"/>
        public static MolarMass MilligramsPerMole(this int value) => MolarMass.FromMilligramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMilligramsPerMole(double?)"/>
        public static MolarMass? MilligramsPerMole(this int? value) => MolarMass.FromMilligramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMilligramsPerMole(double)"/>
        public static MolarMass MilligramsPerMole(this long value) => MolarMass.FromMilligramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMilligramsPerMole(double?)"/>
        public static MolarMass? MilligramsPerMole(this long? value) => MolarMass.FromMilligramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMilligramsPerMole(double)"/>
        public static MolarMass MilligramsPerMole(this double value) => MolarMass.FromMilligramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMilligramsPerMole(double?)"/>
        public static MolarMass? MilligramsPerMole(this double? value) => MolarMass.FromMilligramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMilligramsPerMole(double)"/>
        public static MolarMass MilligramsPerMole(this float value) => MolarMass.FromMilligramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMilligramsPerMole(double?)"/>
        public static MolarMass? MilligramsPerMole(this float? value) => MolarMass.FromMilligramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromMilligramsPerMole(double)"/>
        public static MolarMass MilligramsPerMole(this decimal value) => MolarMass.FromMilligramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromMilligramsPerMole(double?)"/>
        public static MolarMass? MilligramsPerMole(this decimal? value) => MolarMass.FromMilligramsPerMole(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanogramPerMole

        /// <inheritdoc cref="MolarMass.FromNanogramsPerMole(double)"/>
        public static MolarMass NanogramsPerMole(this int value) => MolarMass.FromNanogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromNanogramsPerMole(double?)"/>
        public static MolarMass? NanogramsPerMole(this int? value) => MolarMass.FromNanogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromNanogramsPerMole(double)"/>
        public static MolarMass NanogramsPerMole(this long value) => MolarMass.FromNanogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromNanogramsPerMole(double?)"/>
        public static MolarMass? NanogramsPerMole(this long? value) => MolarMass.FromNanogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromNanogramsPerMole(double)"/>
        public static MolarMass NanogramsPerMole(this double value) => MolarMass.FromNanogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromNanogramsPerMole(double?)"/>
        public static MolarMass? NanogramsPerMole(this double? value) => MolarMass.FromNanogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromNanogramsPerMole(double)"/>
        public static MolarMass NanogramsPerMole(this float value) => MolarMass.FromNanogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromNanogramsPerMole(double?)"/>
        public static MolarMass? NanogramsPerMole(this float? value) => MolarMass.FromNanogramsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromNanogramsPerMole(double)"/>
        public static MolarMass NanogramsPerMole(this decimal value) => MolarMass.FromNanogramsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromNanogramsPerMole(double?)"/>
        public static MolarMass? NanogramsPerMole(this decimal? value) => MolarMass.FromNanogramsPerMole(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundPerMole

        /// <inheritdoc cref="MolarMass.FromPoundsPerMole(double)"/>
        public static MolarMass PoundsPerMole(this int value) => MolarMass.FromPoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromPoundsPerMole(double?)"/>
        public static MolarMass? PoundsPerMole(this int? value) => MolarMass.FromPoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromPoundsPerMole(double)"/>
        public static MolarMass PoundsPerMole(this long value) => MolarMass.FromPoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromPoundsPerMole(double?)"/>
        public static MolarMass? PoundsPerMole(this long? value) => MolarMass.FromPoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromPoundsPerMole(double)"/>
        public static MolarMass PoundsPerMole(this double value) => MolarMass.FromPoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromPoundsPerMole(double?)"/>
        public static MolarMass? PoundsPerMole(this double? value) => MolarMass.FromPoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromPoundsPerMole(double)"/>
        public static MolarMass PoundsPerMole(this float value) => MolarMass.FromPoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromPoundsPerMole(double?)"/>
        public static MolarMass? PoundsPerMole(this float? value) => MolarMass.FromPoundsPerMole(value);

        /// <inheritdoc cref="MolarMass.FromPoundsPerMole(double)"/>
        public static MolarMass PoundsPerMole(this decimal value) => MolarMass.FromPoundsPerMole(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarMass.FromPoundsPerMole(double?)"/>
        public static MolarMass? PoundsPerMole(this decimal? value) => MolarMass.FromPoundsPerMole(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
