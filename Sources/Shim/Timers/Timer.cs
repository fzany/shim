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

using System.ComponentModel;

namespace System.Timers
{
    public delegate void ElapsedEventHandler(object sender, ElapsedEventArgs e);

    public sealed class Timer : IDisposable
    {
        #region EVENTS

        public event ElapsedEventHandler Elapsed
        {
            add
            {
                throw new PlatformNotSupportedException("PCL");
            }
            remove
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        #endregion

        #region PROPERTIES

        public bool Enabled { get; set; }
        
        public double Interval { get; set; }

        public ISynchronizeInvoke SynchronizingObject { get; set; }

        #endregion

        #region METHODS

        public void Dispose()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public void Start()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public void Stop()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        #endregion
    }
}
