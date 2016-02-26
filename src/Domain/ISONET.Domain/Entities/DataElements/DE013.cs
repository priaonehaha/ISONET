﻿using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE013 : DataElement
    {
        public DE013(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.YY, AttributeMask.MM }, 4);
            ConditionUse = conditionUse;
            Bit = 013;
            Name = "date, effective";
            Value = value;
        }

        public DE013(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.YY, AttributeMask.MM }, 4);
            ConditionUse = conditionUse;
            Bit = 013;
            Name = "date, effective";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}