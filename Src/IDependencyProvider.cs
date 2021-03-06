﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSG
{
    /// <summary>
    /// Interface that can provide dependencies.
    /// </summary>
    public interface IDependencyProvider
    {
        /// <summary>
        /// Resolved a named dependency.
        /// Return null if the dependency was not found.
        /// </summary>
        object ResolveDependency(string dependencyName);

        /// <summary>
        /// Find the type of a named dependency.
        /// Return null if the dependency was not found.
        /// </summary>
        Type FindDependencyType(string dependencyName);
    }
}
