﻿// Copyright (c) to owners found in https://github.com/AArnott/pinvoke/blob/master/COPYRIGHT.md. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

namespace PInvoke
{
    using System.Runtime.InteropServices;

    /// <content>
    /// Contains the <see cref="BCRYPT_DSA_KEY_BLOB"/> nested type.
    /// </content>
    public partial class BCrypt
    {
        /// <summary>
        /// A key blob format for transporting DSA keys.
        /// Used as a header for a Digital Signature Algorithm (DSA) public key or private key BLOB in memory.
        /// </summary>
        /// <remarks>
        /// The structure applies to DSA keys that equal or exceed 512 bits in length but are less than or equal to 1024 bits.
        /// </remarks>
        public struct BCRYPT_DSA_KEY_BLOB
        {
            /// <summary>
            /// The structure represents a DSA public key.
            /// </summary>
            public const uint BCRYPT_DSA_PUBLIC_MAGIC = 0x42505344;  // DSPB

            /// <summary>
            /// The structure represents a DSA private key.
            /// </summary>
            public const uint BCRYPT_DSA_PRIVATE_MAGIC = 0x56505344;  // DSPV

            /// <summary>
            /// Determines the type of key this structure represents. This can be one of the following values:
            /// <see cref="BCRYPT_DSA_PUBLIC_MAGIC"/>, <see cref="BCRYPT_DSA_PRIVATE_MAGIC"/>.
            /// </summary>
            public uint dwMagic;

            /// <summary>
            /// The length, in bytes, of the key.
            /// </summary>
            public uint cbKey;

            /// <summary>
            /// The number of iterations, in big-endian format, used to generate q.
            /// </summary>
            public uint Count;

            /// <summary>
            /// The seed value, in big-endian format, used to generate q.
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public byte[] Seed;

            /// <summary>
            /// The 160-bit prime factor, in big-endian format.
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public byte[] q;
        }
    }
}