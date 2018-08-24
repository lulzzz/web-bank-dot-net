﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Akka.Persistence.EventStore.Tests
{
    public class AltAdapter : DefaultAdapter
    {
        protected override byte[] ToBytes(object @event, JObject metadata, out string type, out bool isJson)
        {
            metadata["additionalProp"] = true;
            return base.ToBytes(@event, metadata, out type, out isJson);
        }

        protected override object ToEvent(byte[] bytes, JObject metadata)
        {
            return base.ToEvent(bytes, metadata);
        }
    }
}
