﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MbDotNet.Models.Stubs;
using MbDotNet.Enums;
using Newtonsoft.Json;

namespace MbDotNet.Models.Imposters
{
    public class TcpImposter : Imposter
    {
        [JsonProperty("stubs")]
        public ICollection<TcpStub> Stubs { get; private set; }

        [JsonProperty("mode")]
        public string Mode { get; private set; }

        public TcpImposter(int port, string name, TcpMode mode) : base(port, MbDotNet.Enums.Protocol.Tcp, name)
        {
            Stubs = new List<TcpStub>();
            Mode = mode.ToString().ToLower();
        }

        public TcpStub AddStub()
        {
            var stub = new TcpStub();
            Stubs.Add(stub);
            return stub;
        }
    }
}
