﻿using System;

namespace Voyagers.Utilities.ObjectComparer.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class IgnoreVarianceAttribute : Attribute
    {
    }
}