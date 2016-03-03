﻿using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE073 : DataElement
    {
        //Custom Data Element
        public DE073(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 073;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        public DE073(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 073;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE073(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.YY, AttributeMask.MM, AttributeMask.DD }, 6);
            ConditionUse = conditionUse;
            Bit = 0073;
            Name = "date, action";
            Value = value;
        }

        public DE073(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.YY, AttributeMask.MM, AttributeMask.DD }, 6);
            ConditionUse = conditionUse;
            Bit = 0073;
            Name = "date, action";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}