using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rimango.BootstrapValidation
{
    using Orchard.UI.Resources;

    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder)
        {
            var manifest = builder.Add();

            manifest.DefineStyle("Rimango.BootstrapValidator").SetUrl("BootstrapValidator/bootstrapValidator.min.css");


            manifest.DefineScript("Rimango.BootstrapValidator").SetUrl("BootstrapValidator/bootstrapValidator.min.js").SetDependencies("jQuery");
            manifest.DefineScript("Rimango.BootstrapValidator.DE")
                .SetUrl("BootstrapValidator/language/de_DE.js")
                .SetDependencies("Rimango.BootstrapValidator");
            manifest.DefineScript("Rimango.BootstrapValidator.EN")
                .SetUrl("BootstrapValidator/language/en_EN.js")
                .SetDependencies("Rimango.BootstrapValidator");
        }
    }
}