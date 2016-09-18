using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aecs.Models.Config
{
    public class ConfigFile
    {
        /// <summary>
        /// Unique id for this node. Every server node in this installation have a unique id
        /// </summary>
        public int NodeId { get; set; }
        /// <summary>
        /// Unique id for the cluster installation
        /// </summary>
        public string NodeClusterId { get; set; }
        /// <summary>
        /// Password for accessing the nodeClusterId
        /// </summary>
        public string NodeClusterPassword { get; set; }
        /// <summary>
        /// Database configuration
        /// </summary>
        public ConfigFileDatabase Database { get; set; }

    }
    public class ConfigFileDatabase
    {
        /// <summary>
        /// Is database access enable on this node
        /// </summary>
        public bool IsEnable { get; set; }
        /// <summary>
        /// Database store name 
        /// </summary>
        public string DbName { get; set; }
        /// <summary>
        /// List of all database server from the configuration file
        /// </summary>
        public List<ConfigFileDatabaseNodes> Nodes { get; set; }
    }
    public class ConfigFileDatabaseNodes
    {
        /// <summary>
        /// The ip address to the database server
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// The port that the database is running on
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// Database user
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// Password of the database user
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Is this database server read-only
        /// </summary>
        public bool ReadOnly { get; set; }
        /// <summary>
        /// Priority of this database server. The system will connect to lowest Priority first
        /// </summary>
        public int Prio { get; set; }
    }


}
