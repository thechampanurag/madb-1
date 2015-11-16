﻿// <copyright file="NullOutputReceiver.cs" company="The Android Open Source Project, Ryan Conrad, Quamotion">
// Copyright (c) The Android Open Source Project, Ryan Conrad, Quamotion. All rights reserved.
// </copyright>

namespace SharpAdbClient
{
    /// <summary>
    /// An implementation of the <see cref="IShellOutputReceiver"/> that does not do anything.
    /// </summary>
    public sealed class NullOutputReceiver : IShellOutputReceiver
    {
        /// <summary>
        /// Backing field for the <see cref="Instance"/> property.
        /// </summary>
        private static NullOutputReceiver instance = null;

        /// <summary>
        /// Prevents a default instance of the <see cref="NullOutputReceiver" /> class from being created.
        /// </summary>
        private NullOutputReceiver()
        {
            this.IsCancelled = false;
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static IShellOutputReceiver Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NullOutputReceiver();
                }

                return instance;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is cancelled.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if this instance is cancelled; otherwise, <see langword="false"/>.
        /// </value>
        public bool IsCancelled { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the receiver parses error messages.
        /// </summary>
        /// <value>
        ///     <see langword="true"/> if this receiver parsers error messages; otherwise <see langword="false"/>.
        /// </value>
        /// <remarks>
        /// The default value is <see langword="false"/>. If set to <see langword="false"/>, the <see cref="AdbClient"/>
        /// will detect common error messages and throw an exception.
        /// </remarks>
        public bool ParsesErrors
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Adds the output.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="offset">The offset.</param>
        /// <param name="length">The length.</param>
        public void AddOutput(byte[] data, int offset, int length)
        {
            // do nothing
        }

        /// <summary>
        /// Flushes the output.
        /// </summary>
        /// <remarks>
        /// This should always be called at the end of the "process" in order to indicate that the data is ready to be processed further if needed.
        /// </remarks>
        public void Flush()
        {
            // do nothing
        }
    }
}