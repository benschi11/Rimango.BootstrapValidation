﻿using System;
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

            manifest.DefineStyle("Rimango.BootstrapValidator").SetUrl("formValidation.min.css");


            manifest.DefineScript("Rimango.BootstrapValidator").SetUrl("framework/bootstrap.min.js").SetDependencies("Rimango.FormValidation");
            manifest.DefineScript("Rimango.FormValidation").SetUrl("formValidation.min.js").SetDependencies("jQuery");
            manifest.DefineScript("Rimango.BootstrapValidator.DE")
                .SetUrl("language/de_DE.js")
                .SetDependencies("Rimango.BootstrapValidator");
            manifest.DefineScript("Rimango.BootstrapValidator.EN")
                .SetUrl("language/en_EN.js")
                .SetDependencies("Rimango.BootstrapValidator");

            manifest.DefineScript("Rimango.BootstrapValidator.ValidateForm").SetUrl("ValidateForm.js").SetDependencies("Rimango.BootstrapValidator");
        }
    }
}