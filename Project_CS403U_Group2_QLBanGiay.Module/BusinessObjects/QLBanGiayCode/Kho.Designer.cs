﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Project_CS403U_Group2_QLBanGiay.Module.BusinessObjects.QLBanGiay
{

    [DefaultProperty("Kho_ID")]
    public partial class Kho : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fKho_ID;
        public string Kho_ID
        {
            get { return fKho_ID; }
            set { SetPropertyValue<string>(nameof(Kho_ID), ref fKho_ID, value); }
        }
        string fDiaChi;
        public string DiaChi
        {
            get { return fDiaChi; }
            set { SetPropertyValue<string>(nameof(DiaChi), ref fDiaChi, value); }
        }
    }

}
