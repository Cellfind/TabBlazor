﻿using Microsoft.AspNetCore.Components;

namespace Tabler.Components
{
    public partial class TablerAvatarList : TablerBaseComponent
    {
        [Parameter] public bool Stacked { get; set; }
        protected override string ClassNames => ClassBuilder
            .Add("avatar-list")
            .AddIf("avatar-list-stacked", Stacked)
           .ToString(); 
    }
}