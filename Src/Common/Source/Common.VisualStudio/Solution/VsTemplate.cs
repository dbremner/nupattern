﻿using System;
using System.IO;
using System.Linq;
using System.Xml;
using EnvDTE;
using NuPattern.VisualStudio.Properties;

namespace NuPattern.VisualStudio.Solution
{
    internal abstract class VsTemplate : ITemplate
    {
        string templatePath;
        string defaultExtension;

        public VsTemplate(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException(Resources.VsItemTemplate_FileNotExists, path);

            this.templatePath = path;
            // Try to retrieve the default path from the default item name if any.
            using (var reader = XmlReader.Create(path))
            {
                reader.MoveToContent();
                if (reader.ReadToDescendant("DefaultName", "http://schemas.microsoft.com/developer/vstemplate/2005"))
                {
                    var defaultName = reader.ReadElementContentAsString();
                    if (!String.IsNullOrEmpty(defaultName) && Path.HasExtension(defaultName))
                        defaultExtension = Path.GetExtension(defaultName);
                }
            }
        }

        public IItemContainer Unfold(string name, IItemContainer parent)
        {
            if (!Path.HasExtension(name) && !String.IsNullOrEmpty(defaultExtension))
                name = Path.ChangeExtension(name, defaultExtension);

            ProjectItems itemsParent;
            if (parent.Kind == ItemKind.Project)
            {
                itemsParent = (((VsProject)parent).ExtenderObject as Project).ProjectItems;
            }
            else
            {
                throw new NotSupportedException();
            }

            itemsParent.AddFromTemplate(templatePath, name);

            return (from item in parent.Items
                    where item.Kind == ItemKind.Item && item.Name == name
                    select item)
                         .FirstOrDefault();
        }

        public dynamic Parameters
        {
            get { throw new NotSupportedException(); }
        }
    }
}
