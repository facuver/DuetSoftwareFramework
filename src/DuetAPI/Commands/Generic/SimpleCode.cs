﻿using DuetAPI.Connection;
using DuetAPI.Utility;

namespace DuetAPI.Commands
{
    /// <summary>
    /// Perform a simple G/M/T-code
    /// </summary>
    /// <remarks>
    /// Internally the code passed is populated as a full <see cref="Code"/> instance and on completion
    /// its <see cref="Code.Result"/> is transformed back into a basic string. This is useful for minimal
    /// extensions that do not require granular control of the code details. Except for certain cases, it
    /// is NOT recommended for usage in <see cref="InterceptionMode"/> because it renders the
    /// internal code buffer useless.
    /// </remarks>
    [RequiredPermissions(SbcPermissions.CommandExecution)]
    public class SimpleCode : Command<string>
    {
        /// <summary>
        /// Code to parse and execute
        /// </summary>
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Destination channel
        /// </summary>
        public CodeChannel Channel { get; set; } = Defaults.InputChannel;

        /// <summary>
        /// Whether this code may be executed asynchronously. If set, the code reply is output as a generic message
        /// </summary>
        public bool ExecuteAsynchronously { get; set; }
    }
}