﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CreateKnxProd.Model
{
    public partial class ParameterRefRef_t : INotifyPropertyChanged
    {
        [XmlIgnore]
        public ParameterRef_t ParameterRef { get; set; }
    }
}