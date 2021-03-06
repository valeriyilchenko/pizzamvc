﻿using Pizza.Contracts.Attributes;

namespace KebabManager.Common.Enums
{
    public enum CustomerType
    {
        [EnumDisplayName("Individual customer")]
        Individual,
        [EnumDisplayName("Enterprise customer")]
        Enterprise,
        [EnumDisplayName("Government customer")]
        Government,
    }
}
