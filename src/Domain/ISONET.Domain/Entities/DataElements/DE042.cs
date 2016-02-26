﻿using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE042 : DataElement
    {
        public DE042(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 15);
            ConditionUse = conditionUse;
            Bit = 042;
            Name = "card acceptor identification code";
            Value = value;
        }

        public DE042(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPECIAL }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 15);
            ConditionUse = conditionUse;
            Bit = 042;
            Name = "card acceptor identification code";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}