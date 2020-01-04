// Copyright (c) 2020 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;

namespace TelegramAPI
{
    [System.AttributeUsage(AttributeTargets.Property | AttributeTargets.Parameter, Inherited = false, AllowMultiple = true)]
    internal sealed class InputFileAttribute : Attribute
    {
        internal readonly string PropertyName;
        internal InputFileAttribute(string propertyName)
        {
            PropertyName = propertyName;
        }
    }
}
