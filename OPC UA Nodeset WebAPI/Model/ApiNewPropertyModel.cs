﻿using CESMII.OpcUa.NodeSetModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Opc.Ua;
using OPC_UA_Nodeset_WebAPI.UA_Nodeset_Utilities;
using System.Xml.Linq;

namespace OPC_UA_Nodeset_WebAPI.Model
{
    public class ApiNewPropertyModel
    {
        public string DisplayName { get; set; }

        public string Description { get; set; }

        public uint ParentId { get; set; }

        public ApiNewPropertyModel() { }


    }
}