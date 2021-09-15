﻿// GE Aviation Systems LLC licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace GEAviation.Metrology.TimeUnits
{
    public sealed class Day : ISimpleUnit
    {
        public ISimpleUnit RelativeTo => UnitManager.getUnit<Hour>();
        public IDimension Dimension => UnitManager.getDimension<TimeDimension>();
        public decimal ScaledFromRelative { get; } = 1 / 24.0m;
        public string Name => "day";
        public string Abbreviation => "day";
    }
}
