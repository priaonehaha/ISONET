﻿using ISONET.Domain.Interfaces.Entities;
using System;

namespace ISONET.Domain.Entities
{
    public abstract class DataElement : IDataElement
    {
        public abstract IAtrribute Attribute { get; }
        public abstract short Bit { get; }
        public abstract IConditionUse ConditionUse { get; }
        public abstract string Description { get; set; }
        public abstract string Name { get; }
        public abstract object Value { get; set; }

        // TODO: Verificar a melhor forma de armazenar o valor para os tipos LLVAR e LLLVAR.
        public override string ToString()
        {
            string value = string.Empty;

            switch (Attribute.LengthType)
            {
                case LengthType.LLLVAR:
                    value = Convert.ToString(Value.ToString().Length.ToString("D3")) + Value;
                    break;

                case LengthType.LLVAR:
                    value = Convert.ToString(Value.ToString().Length.ToString("D3")) + Value;
                    break;

                case LengthType.FIXED:
                    break;
            }

            return value;
        }
    }
}