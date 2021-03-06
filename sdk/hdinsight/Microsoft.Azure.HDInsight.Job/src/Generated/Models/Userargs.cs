// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.HDInsight.Job.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Gets or sets the object containing the user arguments.
    /// </summary>
    public partial class Userargs
    {
        /// <summary>
        /// Initializes a new instance of the Userargs class.
        /// </summary>
        public Userargs()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Userargs class.
        /// </summary>
        /// <param name="arg">The list of args defined by the user.</param>
        /// <param name="callback">The callback URL, if any.</param>
        /// <param name="define">The define properties defined by the
        /// user.</param>
        /// <param name="enablelog">Whether or not the user enabled
        /// logs.</param>
        /// <param name="execute">The query defined by the user.</param>
        /// <param name="file">The query file provided by the user.</param>
        /// <param name="files">The files defined by the user.</param>
        /// <param name="jar">The JAR file provided by the user.</param>
        /// <param name="statusdir">The status directory defined by the
        /// user.</param>
        public Userargs(IList<string> arg = default(IList<string>), object callback = default(object), IList<string> define = default(IList<string>), string enablelog = default(string), string execute = default(string), object file = default(object), object files = default(object), string jar = default(string), object statusdir = default(object))
        {
            Arg = arg;
            Callback = callback;
            Define = define;
            Enablelog = enablelog;
            Execute = execute;
            File = file;
            Files = files;
            Jar = jar;
            Statusdir = statusdir;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the list of args defined by the user.
        /// </summary>
        [JsonProperty(PropertyName = "arg")]
        public IList<string> Arg { get; private set; }

        /// <summary>
        /// Gets or sets the callback URL, if any.
        /// </summary>
        [JsonProperty(PropertyName = "callback")]
        public object Callback { get; set; }

        /// <summary>
        /// Gets the define properties defined by the user.
        /// </summary>
        [JsonProperty(PropertyName = "define")]
        public IList<string> Define { get; private set; }

        /// <summary>
        /// Gets or sets whether or not the user enabled logs.
        /// </summary>
        [JsonProperty(PropertyName = "enablelog")]
        public string Enablelog { get; set; }

        /// <summary>
        /// Gets or sets the query defined by the user.
        /// </summary>
        [JsonProperty(PropertyName = "execute")]
        public string Execute { get; set; }

        /// <summary>
        /// Gets or sets the query file provided by the user.
        /// </summary>
        [JsonProperty(PropertyName = "file")]
        public object File { get; set; }

        /// <summary>
        /// Gets or sets the files defined by the user.
        /// </summary>
        [JsonProperty(PropertyName = "files")]
        public object Files { get; set; }

        /// <summary>
        /// Gets or sets the JAR file provided by the user.
        /// </summary>
        [JsonProperty(PropertyName = "jar")]
        public string Jar { get; set; }

        /// <summary>
        /// Gets or sets the status directory defined by the user.
        /// </summary>
        [JsonProperty(PropertyName = "statusdir")]
        public object Statusdir { get; set; }

    }
}
