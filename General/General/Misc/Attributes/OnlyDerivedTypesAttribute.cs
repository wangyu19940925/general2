﻿using System;
using UnityEngine;

namespace Devdog.General
{
    public class OnlyDerivedTypesAttribute : PropertyAttribute
    {
        public Type type { get; protected set; }

        public OnlyDerivedTypesAttribute()
        {
            
        }

        public OnlyDerivedTypesAttribute(Type type)
        {
            this.type = type;
        }

    }
}