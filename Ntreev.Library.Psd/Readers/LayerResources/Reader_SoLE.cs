﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ntreev.Library.Psd.Readers.LayerResources
{
    [ResourceID("SoLE")]
    class Reader_SoLE : Reader_SoLd
    {
        public Reader_SoLE(PsdReader reader, long length)
            : base(reader, length)
        {

        }
    }
}