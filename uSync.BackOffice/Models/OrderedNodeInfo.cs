﻿using System;
using System.Xml.Linq;

namespace uSync.BackOffice
{
    /// <summary>
    ///  object representing a file and its level
    /// </summary>
    public class OrderedNodeInfo
    {
        /// <summary>
        ///  the key for the item.
        /// </summary>
        public Guid Key { get; set; }

        /// <summary>
        ///  umbraco alias of the item
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        ///  relative path of the item (so same in all 'folders')
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        ///  level (e.g 0 is root) of file
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        ///  path to the actual file.
        /// </summary>
        public string Filename { get; set; }

        /// <summary>
        ///  the xml for this item.
        /// </summary>
        public XElement Node { get; set; }

        /// <summary>
        ///  is this element from a root folder ? 
        /// </summary>
        public bool IsRoot { get; set; }
    }

}