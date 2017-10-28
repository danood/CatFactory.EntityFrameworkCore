﻿using CatFactory.DotNetCore;

namespace CatFactory.EfCore.Definitions
{
    public static class EntityInterfaceDefinition
    {
        public static CSharpInterfaceDefinition GetEntityInterfaceDefinition(this EntityFrameworkCoreProject project)
        {
            var interfaceDefinition = new CSharpInterfaceDefinition();

            interfaceDefinition.Namespace = project.GetEntityLayerNamespace();
            interfaceDefinition.Name = "IEntity";

            return interfaceDefinition;
        }
    }
}
