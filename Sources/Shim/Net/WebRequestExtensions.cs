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

namespace System.Net
{
    using System.IO;

    public static class WebRequestExtensions
    {
        public static WebResponse GetResponse(this WebRequest request)
        {
#if DOTNET
            return request.GetResponse();
#else
            return request.EndGetResponse(request.BeginGetResponse(null, null));
#endif
        }

        public static Stream GetRequestStream(this WebRequest request)
        {
#if DOTNET
            return request.GetRequestStream();
#else
            return request.EndGetRequestStream(request.BeginGetRequestStream(null, null));
#endif
        }

        public static void SetConnectionGroupName(this WebRequest request, string groupName)
        {
#if DOTNET
            request.ConnectionGroupName = groupName;
#endif
        }

        public static void SetProxy(this WebRequest request, IWebProxy proxy)
        {
#if DOTNET
            request.Proxy = proxy;
#endif
        }

        public static void SetTimeout(this WebRequest request, int timeout)
        {
#if DOTNET
            request.Timeout = timeout;
#endif
        }

        public static void SetContentLength(this WebRequest request, long contentLength)
        {
#if DOTNET
            request.ContentLength = contentLength;
#endif
        }
    }
}