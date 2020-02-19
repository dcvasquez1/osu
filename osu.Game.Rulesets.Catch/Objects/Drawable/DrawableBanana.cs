﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Bindables;
using osu.Framework.Utils;
using osuTK.Graphics;

namespace osu.Game.Rulesets.Catch.Objects.Drawable
{
    public class DrawableBanana : DrawableFruit
    {
        public DrawableBanana(Banana h)
            : base(h)
        {
        }

        protected override void LoadComplete()
        {
            base.LoadComplete();

            AccentColour.BindValueChanged(accentChanged, true);
        }

        private Color4? colour;

        private void accentChanged(ValueChangedEvent<Color4> obj)
        {
            // override any external colour changes with banananana
            AccentColour.Value = (colour ??= getBananaColour());
        }

        private Color4 getBananaColour()
        {
            switch (RNG.Next(0, 3))
            {
                default:
                    return new Color4(255, 240, 0, 255);

                case 1:
                    return new Color4(255, 192, 0, 255);

                case 2:
                    return new Color4(214, 221, 28, 255);
            }
        }
    }
}
