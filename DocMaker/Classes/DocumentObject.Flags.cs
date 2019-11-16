using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocMaker
{
    public partial class DocumentObject
    {
        protected uint flags;         // All object parameters are here 
                                    // (for quick save load methods and memory optimisation)

        private uint Savedflags;    // Save the value of flags here in case of discarding changes


        [Flags]
        public enum Flags : uint
        {
            //
            // The first byte   :
            //
            Visible             = 0x01,
            Transparent         = 0x02,
            SizeInPercent       = 0x04,
            IsVertical          = 0x08,

            IsTurned180         = 0x20,
            FlipHorizontally    = 0x20,
            FlipVertically      = 0x40,
            LinkedSize          = 0x80,

            //
            //  The fourth byte :
            //
            //      Reserved for alignement flags & centering flags
            //      HorizontalABits & VerticalABits are used for cleaning alignment flags
            //      Sorry, I know I'm always making things harder can't help :3 xD
            //

            HorizontalABits     = 0x0E000000,   // Represents where the horizontal alignment bits are
            CenterHorizontally  = 0x01000000,   // Center object horizontally to paper
            Left                = 0x02000000,
            Center              = 0x04000000,
            Right               = 0x08000000,

            VerticalABits       = 0xE0000000,   // Represents where the vertical alignment bits are
            CenterVertically    = 0x10000000,   // Center object vertically to paper
            Up                  = 0x20000000,
            Middle              = 0x40000000,
            Down                = 0x80000000,
        }

        private bool Is(Flags f) => (flags & (uint)f) > 0;
        private bool Has(uint i, Flags f) => (i & (uint)f) > 0;

        private bool GetFlag(Flags f) => GetFlag((uint)f);
        private void SetFlag(Flags f, bool b) => SetFlag((uint)f, b);

        private bool GetFlag(uint i) => (flags & i) > 0;
        private void SetFlag(uint i, bool b)
        {
            if (b) flags = flags | i; 
            else flags = flags & (~i);
        }

        public void SaveFlags() => Savedflags = flags;
        public void LoadFlags() => flags = Savedflags;


        public bool Visible
        {
            get => GetFlag(Flags.Visible);
            set => SetFlag(Flags.Visible, value);
        }

        public bool SizeInPercent
        {
            get => GetFlag(Flags.SizeInPercent);
            set => SetFlag(Flags.SizeInPercent, value);
        }

        public bool IsVertical
        {
            get => GetFlag(Flags.IsVertical);
            set => SetFlag(Flags.IsVertical, value);
        }

        public bool IsTurned180
        {
            get => GetFlag(Flags.IsTurned180);
            set => SetFlag(Flags.IsTurned180, value);
        }

        public bool FlipHorizontally
        {
            get => GetFlag(Flags.FlipHorizontally);
            set => SetFlag(Flags.FlipHorizontally, value);
        }

        public bool FlipVertically
        {
            get => GetFlag(Flags.FlipVertically);
            set => SetFlag(Flags.FlipVertically, value);
        }

        public bool LinkedSize
        {
            get => GetFlag(Flags.LinkedSize);
            set => SetFlag(Flags.LinkedSize, value);
        }

        public void SetAlignment(Flags alignment) => SetAlignment((uint)alignment);
        public void SetAlignment(uint alignment) => Alignment = alignment;

        public bool IsLeft() => Is(Flags.Left);
        public bool IsCenter() => Is(Flags.Center);
        public bool IsRight() => Is(Flags.Right);

        public bool IsUp() => Is(Flags.Up);
        public bool IsMiddle() => Is(Flags.Middle);
        public bool IsDown() => Is(Flags.Down);


        public uint Alignment
        {
            get => flags & 0xEE000000;
            set
            {
                if (Has(value, Flags.HorizontalABits)) // Clear old horizontal alignment if a new value is requested
                    SetFlag(Flags.HorizontalABits, false);

                if (Has(value, Flags.VerticalABits)) // Clear old vertical alignment if a new value is requested
                    SetFlag(Flags.VerticalABits, false);

                // Set the requested alignement flags to 1
                SetFlag(value, true);
            }

        }
    }
}
