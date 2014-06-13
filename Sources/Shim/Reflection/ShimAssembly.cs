﻿/*
 *  Copyright (c) 2013-2014, Cureos AB.
 *  All rights reserved.
 *  http://www.cureos.com
 *
 *	This file is part of Shim.NET.
 *
 *  Shim.NET is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  Shim.NET is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with Shim.NET.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace System.Reflection
{
    public static class ShimAssembly
    {
		/// <summary>
		/// Gets the assembly that contains the code that is currently executing.
		/// </summary>
		/// <returns>The assembly that contains the code that is currently executing.</returns>
		/// <remarks>
		/// By definition, the executing assembly is the assembly from which this method is invoked.
		/// The return value should thus be the assembly from which this method is called.
		/// The "classic" method used to obtain this assembly, <code>Assembly.GetCallingAssembly</code> is not
		/// publicly exposed in the .NET for Windows Store assembly. Therefore the method is
		/// here invoked through reflection, based on a StackOverflow tip at http://stackoverflow.com/a/14754653/650012 .
		/// </remarks>
        public static Assembly GetExecutingAssembly()
		{
		    return
		        (Assembly)typeof(Assembly).GetTypeInfo().GetDeclaredMethod("GetCallingAssembly").Invoke(null, new object[0]);
		}
    }
}
