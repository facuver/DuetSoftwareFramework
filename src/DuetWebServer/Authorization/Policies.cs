﻿namespace DuetWebServer.Authorization
{
    /// <summary>
    /// Access policies (TBD)
    /// </summary>
    public static class Policies
    {
        /// <summary>
        /// Authorization policy for read-only requests
        /// </summary>
        public const string ReadOnly = "readOnly";

        /// <summary>
        /// Authorization policy for read-write requests
        /// </summary>
        public const string ReadWrite = "readWrite";
    }
}
