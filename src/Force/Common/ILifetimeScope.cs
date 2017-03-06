﻿using System;
using JetBrains.Annotations;

namespace Force.Common
{
    /// <summary>
    /// Used to avoid references to specific IOC container
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [PublicAPI]
    public interface ILifetimeScope<out T> : IDisposable
    {
        /// <summary>
        /// Get instance from lifetime scope configured via IOC container
        /// </summary>
        T Instance { get; }
    }
}