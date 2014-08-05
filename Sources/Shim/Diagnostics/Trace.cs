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

namespace System.Diagnostics
{
    public static class Trace
    {
        #region METHODS

        public static void Write(string message)
        {
            Debug.WriteLine(message);
        }

        public static void WriteLine(string message)
        {
            Debug.WriteLine(message);
        }

        public static void TraceWarning(string message)
        {
            Debug.WriteLine(message);
        }

        public static void Assert(bool condition)
        {
            Debug.Assert(condition);
        }

        public static void TraceInformation(string format, params object[] args)
        {
            Debug.WriteLine(format, args);
        }
        
        #endregion
    }
}