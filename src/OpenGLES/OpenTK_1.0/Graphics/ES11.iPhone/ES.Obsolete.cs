#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
// Copyright 2013 Xamarin Inc
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

namespace OpenTK.Graphics.ES11
{
    using System;
    using System.Text;
    using System.Runtime.InteropServices;
    #pragma warning disable 3019
    #pragma warning disable 1591
    #pragma warning disable 1572
    #pragma warning disable 1573

    partial class GL
    {
        public static partial class Ext
        {
            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "1.1", Version = "1.1", EntryPoint = "glGetObjectLabelEXT")]
            [Obsolete ("Use the overload with strongly typed enumerations and StringBuilder final parameter. This overload is not supported.")]
            public static 
            unsafe void GetObjectLabel(OpenTK.Graphics.ES11.All type, Int32 @object, Int32 bufSize, Int32* length, String label)
            {
                throw new NotSupportedException ("Use the overload with strongly typed enumerations and StringBuilder final parameter. This overload is not supported.");
            }

            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "1.1", Version = "1.1", EntryPoint = "glGetObjectLabelEXT")]
            [Obsolete ("Use the overload with strongly typed enumerations and StringBuilder final parameter. This overload is not supported.")]
            public static 
            void GetObjectLabel(OpenTK.Graphics.ES11.All type, UInt32 @object, Int32 bufSize, Int32[] length, String label)
            {
                throw new NotSupportedException ("Use the overload with strongly typed enumerations and StringBuilder final parameter. This overload is not supported.");
            }

            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "1.1", Version = "1.1", EntryPoint = "glGetObjectLabelEXT")]
            [Obsolete ("Use the overload with strongly typed enumerations and StringBuilder final parameter. This overload is not supported.")]
            public static 
            void GetObjectLabel(OpenTK.Graphics.ES11.All type, UInt32 @object, Int32 bufSize, ref Int32 length, String label)
            {
                throw new NotSupportedException ("Use the overload with strongly typed enumerations and StringBuilder final parameter. This overload is not supported.");
            }

            [System.CLSCompliant(false)]
            [AutoGenerated(Category = "1.1", Version = "1.1", EntryPoint = "glGetObjectLabelEXT")]
            [Obsolete ("Use the overload with strongly typed enumerations and StringBuilder final parameter. This overload is not supported.")]
            public static 
            unsafe void GetObjectLabel(OpenTK.Graphics.ES11.All type, UInt32 @object, Int32 bufSize, Int32* length, String label)
            {
                throw new NotSupportedException ("Use the overload with strongly typed enumerations and StringBuilder final parameter. This overload is not supported.");
            }
        }
    }
}