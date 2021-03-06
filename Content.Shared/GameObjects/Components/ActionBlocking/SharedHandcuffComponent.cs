﻿using Robust.Shared.GameObjects;
using Robust.Shared.Serialization;
using System;

namespace Content.Shared.GameObjects.Components.ActionBlocking
{
    public class SharedHandcuffComponent : Component
    {
        public override string Name => "Handcuff";
        public override uint? NetID => ContentNetIDs.HANDCUFFS;

        [Serializable, NetSerializable]
        protected sealed class HandcuffedComponentState : ComponentState
        {
            public string IconState { get; }

            public HandcuffedComponentState(string iconState) : base(ContentNetIDs.HANDCUFFS)
            {
                IconState = iconState;
            }
        }
    }
}
