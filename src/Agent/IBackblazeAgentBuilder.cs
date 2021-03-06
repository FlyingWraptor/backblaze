﻿using Microsoft.Extensions.DependencyInjection;

namespace Bytewizer.Backblaze.Agent
{
    /// <summary>
    /// Backblaze B2 Cloud Storage agent builder interface
    /// </summary>
    public interface IBackblazeAgentBuilder
    {
        /// <summary>
        /// Gets the service collection.
        /// </summary>
        IServiceCollection Services { get; }
    }
}
