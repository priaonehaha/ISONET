﻿using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Domain.Entities.DataElements
{
    public sealed class DE055 : DataElement
    {
        //Custom Data Element
        public DE055(IAtrribute attribute, IConditionUse conditionUse, string description, string name, object value)
        {
            Attribute = attribute;
            Bit = 055;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
            Value = value;
        }

        //Custom Data Element
        public DE055(IAtrribute attribute, IConditionUse conditionUse, string description, string name)
        {
            Attribute = attribute;
            Bit = 055;
            ConditionUse = conditionUse;
            Description = description;
            Name = name;
        }

        public DE055(IConditionUse conditionUse, object value)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 255);
            ConditionUse = conditionUse;
            Bit = 055;
            Name = "integrated circuit card system related data";
            Value = value;
        }

        public DE055(IConditionUse conditionUse)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 255);
            ConditionUse = conditionUse;
            Bit = 055;
            Name = "integrated circuit card system related data";
        }

        public DE055(IConditionUse conditionUse, object value, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 255, length);
            ConditionUse = conditionUse;
            Bit = 055;
            Name = "integrated circuit card system related data";
            Value = value;
        }

        public DE055(IConditionUse conditionUse, short length)
        {
            Attribute = new Atrribute(new[] { AttributeFormat.BINARY }, LengthType.LLLVAR, new[] { AttributeMask.NoMask }, 255, length);
            ConditionUse = conditionUse;
            Bit = 055;
            Name = "integrated circuit card system related data";
        }

        public override IAtrribute Attribute { get; }

        public override short Bit { get; }

        public override IConditionUse ConditionUse { get; }
        public override string Description { get; set; }

        public override string Name { get; }

        public override object Value { get; set; }
    }
}