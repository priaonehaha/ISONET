﻿using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE038 : DataElement
    {
        //Custom Data Element
        public DE038(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 038;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        public DE038(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 038;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE038(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPACE }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 6);
            ConditionUse = conditionUse;
            Bit = 038;
            Name = "approval code";
            Value = value;
        }

        public DE038(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.ALPHABETICAL, AttributeFormat.NUMERIC, AttributeFormat.SPACE }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 6);
            ConditionUse = conditionUse;
            Bit = 038;
            Name = "approval code";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}