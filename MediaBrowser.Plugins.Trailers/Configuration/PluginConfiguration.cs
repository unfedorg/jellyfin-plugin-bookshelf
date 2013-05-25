﻿using MediaBrowser.Model.Plugins;

namespace MediaBrowser.Plugins.Trailers.Configuration
{
    /// <summary>
    /// Class PluginConfiguration
    /// </summary>
    public class PluginConfiguration : BasePluginConfiguration
    {
        /// <summary>
        /// Gets or sets the name of the folder.
        /// </summary>
        /// <value>The name of the folder.</value>
        public string FolderName { get; set; }

        /// <summary>
        /// Trailers older than this will not be downloaded and deleted if already downloaded.
        /// </summary>
        /// <value>The max trailer age.</value>
        public int? MaxTrailerAge { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginConfiguration" /> class.
        /// </summary>
        public PluginConfiguration()
            : base()
        {
            FolderName = "Trailers";

            MaxTrailerAge = 60;
        }
    }
}
