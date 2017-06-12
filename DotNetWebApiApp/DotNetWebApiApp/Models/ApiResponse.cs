using System.Collections.Generic;

namespace DotNetWebApiApp.Models
{
    /// <summary>
    /// This will be the type of object that will be send to the client application on every request
    /// </summary>
    /// <typeparam name="T">Actual type of the returning model</typeparam>
    public class ApiResponse<T>
    {
        #region Constructors
        public ApiResponse()
        {
            this.Errors = new List<string>();
        }
        public ApiResponse(T data) : this()
        {
            this.Data = data;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Actual Data object passed
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Has there been any error occurred during current request
        /// </summary>
        public bool HasError { get; set; }

        /// <summary>
        /// List of errors
        /// </summary>
        public List<string> Errors { get; set; }
        #endregion

    }
}