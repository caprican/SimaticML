﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SimaticML
{
    [Serializable]
    public class Object_T : IEnumerable<Object_T>
    {
        [XmlAttribute]
        public string ID { get; set; }

        [XmlAttribute]
        public string CompositionName { get; set; } = null;
        [XmlIgnore]
        public bool CompositionNameSpecified { get; set; }

        //[XmlArray("ObjectList")]
        //[XmlArrayItem("MultilingualText", typeof(MultilingualText_T))]
        //[XmlArrayItem("SW.Blocks.CompileUnit", typeof(SW.Blocks.CompileUnit))]
        //[XmlArrayItem("MultilingualTextItem", typeof(MultilingualTextItem_T))]
        protected internal Object_T[] Items { get; set; }
        public Object_T this[int key]  {  get => Items[key];  set => Items[key] = value;  }

        public IEnumerator<Object_T> GetEnumerator()
        {
            if (Items is null) yield break;
            foreach (var item in Items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
