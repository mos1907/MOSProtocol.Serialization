﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 
namespace OSM.MOSProtocol.Messages.MOS_2_8_2
{
    using System.Xml.Serialization;

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class item
    {

        /// <remarks/>
        public string itemID;

        /// <remarks/>
        public string itemSlug;

        /// <remarks/>
        public string objID;

        /// <remarks/>
        public string mosID;

        /// <remarks/>
        public string mosPlugInID;

        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElement()]
        public System.Xml.XmlElement mosAbstract;

        /// <remarks/>
        public objPaths objPaths;

        /// <remarks/>
        public string itemChannel;

        /// <remarks/>
        public string itemEdStart;

        /// <remarks/>
        public string itemEdDur;

        /// <remarks/>
        public string itemUserTimingDur;

        /// <remarks/>
        public string itemTrigger;

        /// <remarks/>
        public string macroIn;

        /// <remarks/>
        public string macroOut;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("mosExternalMetadata")]
        public mosExternalMetadata[] mosExternalMetadata;
    }

}