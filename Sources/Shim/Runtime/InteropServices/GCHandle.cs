﻿/*
 *  Copyright (c) 2013-2014, Cureos AB.
 *  All rights reserved.
 *  http://www.cureos.com
 *
 *	This file is part of CSShim.
 *
 *  CSShim is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Lesser General Public License as
 *  published by the Free Software Foundation, either version 3 of the
 *  License, or (at your option) any later version.
 *
 *  CSShim is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Lesser General Public License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public
 *  License along with CSShim. If not, see <http://www.gnu.org/licenses/>.
 */

namespace System.Runtime.InteropServices
{
    public struct GCHandle
    {
        #region PROPERTIES

        public bool IsAllocated { get; private set; }
        
        #endregion

        #region METHODS

        public static GCHandle Alloc(object value, GCHandleType type)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public IntPtr AddrOfPinnedObject()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public void Free()
        {
            throw new PlatformNotSupportedException("PCL");
        }
        
        #endregion
    }
}