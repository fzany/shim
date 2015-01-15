﻿/*
 *  Copyright (c) 2013-2015, Cureos AB.
 *  All rights reserved.
 *  http://www.cureos.com
 *
 *	This file is part of Shim.
 *
 *  Shim is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Lesser General Public License as
 *  published by the Free Software Foundation, either version 3 of the
 *  License, or (at your option) any later version.
 *
 *  Shim is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Lesser General Public License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public
 *  License along with Shim. If not, see <http://www.gnu.org/licenses/>.
 */

namespace System.Threading
{
    using System.Threading.Tasks;

    #region DELEGATES

    public delegate void ThreadStart();

    public delegate void ParameterizedThreadStart(object obj);

    #endregion 

    public sealed class Thread
    {
        #region FIELDS

        private readonly ThreadStart start;
        private readonly ParameterizedThreadStart parameterizedStart;
        private Task task;

        #endregion

        #region CONSTRUCTORS

        public Thread(ThreadStart start)
        {
            this.start = start;
            this.parameterizedStart = null;
            this.task = null;
        }

        public Thread(ParameterizedThreadStart start)
        {
            this.start = null;
            this.parameterizedStart = start;
            this.task = null;
        }

        #endregion

        #region PROPERTIES

        public static Thread CurrentThread
        {
            get
            {
                throw new PlatformNotSupportedException("PCL");
            }
        }

        public string Name { get; set; }

        public bool IsBackground { get; set; }

        #endregion

        #region METHODS

        public void Start()
        {
            if (this.start == null) throw new InvalidOperationException("Parameter-less action not defined for this thread instance.");
            this.task = Task.Run(new Action(this.start));
        }

        public void Start(object parameter)
        {
            if (this.parameterizedStart == null) throw new InvalidOperationException("Parameterized action not defined for this thread instance.");
            this.task = Task.Run(() => this.parameterizedStart(parameter));
        }

        public void Join()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public bool Join(int millisecondsTimeout)
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public void Abort()
        {
            throw new PlatformNotSupportedException("PCL");
        }

        public static void Sleep(int millisecondsTimeout)
        {
            new ManualResetEvent(false).WaitOne(millisecondsTimeout);
        }

        #endregion
    }
}