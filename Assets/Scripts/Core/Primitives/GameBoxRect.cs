// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2023, Jiaqi Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Core.Primitives
{
    using System.Runtime.CompilerServices;

    [System.Serializable]
    public struct GameBoxRect
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public GameBoxRect(int left, int top, int right, int bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public bool IsEmpty => Left == 0 &&
                               Top == 0 &&
                               Right == 0 &&
                               Bottom == 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool IsPointInsideRect(int x, int y)
        {
            return x >= Left &&
                   x <= Right &&
                   y >= Top &&
                   y <= Bottom;
        }
    }
}