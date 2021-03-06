﻿// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
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

using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class TorqueTests : TorqueTestsBase
    {
        protected override double KilogramForceCentimetersInOneNewtonMeter => 10.1971621;

        protected override double KilogramForceMetersInOneNewtonMeter => 0.101971621;

        protected override double KilogramForceMillimetersInOneNewtonMeter => 101.971621;

        protected override double MeganewtonCentimetersInOneNewtonMeter => 1E-4;

        protected override double KilonewtonCentimetersInOneNewtonMeter => 0.1;

        protected override double MeganewtonMetersInOneNewtonMeter => 1E-6;

        protected override double KilonewtonMetersInOneNewtonMeter => 0.001;

        protected override double MeganewtonMillimetersInOneNewtonMeter => 1E-3;

        protected override double KilonewtonMillimetersInOneNewtonMeter => 1;

        protected override double MegapoundForceFeetInOneNewtonMeter => 7.376e-7;

        protected override double KilopoundForceFeetInOneNewtonMeter => 7.376e-4;

        protected override double MegapoundForceInchesInOneNewtonMeter => 8.8516E-6;

        protected override double KilopoundForceInchesInOneNewtonMeter => 8.8516E-3;

        protected override double NewtonCentimetersInOneNewtonMeter => 100;

        protected override double NewtonMetersInOneNewtonMeter => 1;

        protected override double NewtonMillimetersInOneNewtonMeter => 1000;

        protected override double PoundForceFeetInOneNewtonMeter => 0.737562149277;

        protected override double PoundForceInchesInOneNewtonMeter => 8.85074579;

        protected override double TonneForceCentimetersInOneNewtonMeter => 1.01972e-2;

        protected override double TonneForceMetersInOneNewtonMeter => 1.01972e-4;

        protected override double TonneForceMillimetersInOneNewtonMeter => 1.01972e-1;

        [Fact]
        public void TorqueDividedByForceEqualsLength()
        {
            Length length = Torque.FromNewtonMeters(4)/Force.FromNewtons(2);
            Assert.Equal(length, Length.FromMeters(2));
        }

        [Fact]
        public void TorqueDividedByLengthEqualsForce()
        {
            Force force = Torque.FromNewtonMeters(4)/Length.FromMeters(2);
            Assert.Equal(force, Force.FromNewtons(2));
        }
    }
}