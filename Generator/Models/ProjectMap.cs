﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StaticSharpProjectMapGenerator.Models
{
    public class ProjectMap
    {
        public ProjectMap(string projectName, string rootPageName, string pathToRoot, string rootContainingNamespaceString)
        {
            Name = projectName;
            Root = new PageMap(rootPageName, new List<string> { rootPageName });
            PathToRoot = pathToRoot;
            RootContaingNamespace = rootContainingNamespaceString;
        }

        public string Name { get; set; }

        public string Debug { get; set; }

        //public string Version {get; set;} // TODO: in order to match source generator with VSCode extension

        public PageMap Root { get; }

        public string PathToRoot { get; }

        public string RootContaingNamespace { get; }

        //public List<string> PageTypes { get; set; } = new List<string>();
    }
}