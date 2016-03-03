﻿using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE128 : DataElement
    {
        //Custom Data Element
        public DE128(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 128;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        //Custom Data Element
        public DE128(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 128;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        public DE128(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 8);
            ConditionUse = conditionUse;
            Bit = 128;
            Name = "message authentication code field";
            Value = value;
        }

        public DE128(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 8);
            ConditionUse = conditionUse;
            Bit = 128;
            Name = "message authentication code field";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}