﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("SNET_T1Model", "FK_ORDER", "CUSTOMER", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Infrastructure.CUSTOMER), "ORDER", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Infrastructure.ORDER), true)]
[assembly: EdmRelationshipAttribute("SNET_T1Model", "FK_ORDERDETAILS", "ORDER", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(Infrastructure.ORDER), "ORDERDETAILS", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(Infrastructure.ORDERDETAIL), true)]

#endregion

namespace Infrastructure
{
    #region Contexts

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class SNET_T1Entities : ObjectContext
    {
        #region Constructors

        /// <summary>
        /// Initializes a new SNET_T1Entities object using the connection string found in the 'SNET_T1Entities' section of the application configuration file.
        /// </summary>
        public SNET_T1Entities()
            : base("name=SNET_T1Entities", "SNET_T1Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new SNET_T1Entities object.
        /// </summary>
        public SNET_T1Entities(string connectionString)
            : base(connectionString, "SNET_T1Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new SNET_T1Entities object.
        /// </summary>
        public SNET_T1Entities(EntityConnection connection)
            : base(connection, "SNET_T1Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        #endregion

        #region Partial Methods

        partial void OnContextCreated();

        #endregion

        #region ObjectSet Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CUSTOMER> CUSTOMERs
        {
            get
            {
                if ((_CUSTOMERs == null))
                {
                    _CUSTOMERs = base.CreateObjectSet<CUSTOMER>("CUSTOMERs");
                }
                return _CUSTOMERs;
            }
        }
        private ObjectSet<CUSTOMER> _CUSTOMERs;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ORDER> ORDERs
        {
            get
            {
                if ((_ORDERs == null))
                {
                    _ORDERs = base.CreateObjectSet<ORDER>("ORDERs");
                }
                return _ORDERs;
            }
        }
        private ObjectSet<ORDER> _ORDERs;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ORDERDETAIL> ORDERDETAILS
        {
            get
            {
                if ((_ORDERDETAILS == null))
                {
                    _ORDERDETAILS = base.CreateObjectSet<ORDERDETAIL>("ORDERDETAILS");
                }
                return _ORDERDETAILS;
            }
        }
        private ObjectSet<ORDERDETAIL> _ORDERDETAILS;

        #endregion
        #region AddTo Methods

        /// <summary>
        /// Deprecated Method for adding a new object to the CUSTOMERs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCUSTOMERs(CUSTOMER cUSTOMER)
        {
            base.AddObject("CUSTOMERs", cUSTOMER);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the ORDERs EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToORDERs(ORDER oRDER)
        {
            base.AddObject("ORDERs", oRDER);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the ORDERDETAILS EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToORDERDETAILS(ORDERDETAIL oRDERDETAIL)
        {
            base.AddObject("ORDERDETAILS", oRDERDETAIL);
        }

        #endregion
    }


    #endregion

    #region Entities

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "SNET_T1Model", Name = "CUSTOMER")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class CUSTOMER : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new CUSTOMER object.
        /// </summary>
        /// <param name="cUSTOMERID">Initial value of the CUSTOMERID property.</param>
        /// <param name="nAME">Initial value of the NAME property.</param>
        public static CUSTOMER CreateCUSTOMER(global::System.Int16 cUSTOMERID, global::System.String nAME)
        {
            CUSTOMER cUSTOMER = new CUSTOMER();
            cUSTOMER.CUSTOMERID = cUSTOMERID;
            cUSTOMER.NAME = nAME;
            return cUSTOMER;
        }

        #endregion
        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int16 CUSTOMERID
        {
            get
            {
                return _CUSTOMERID;
            }
            set
            {
                if (_CUSTOMERID != value)
                {
                    OnCUSTOMERIDChanging(value);
                    ReportPropertyChanging("CUSTOMERID");
                    _CUSTOMERID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("CUSTOMERID");
                    OnCUSTOMERIDChanged();
                }
            }
        }
        private global::System.Int16 _CUSTOMERID;
        partial void OnCUSTOMERIDChanging(global::System.Int16 value);
        partial void OnCUSTOMERIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String NAME
        {
            get
            {
                return _NAME;
            }
            set
            {
                OnNAMEChanging(value);
                ReportPropertyChanging("NAME");
                _NAME = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("NAME");
                OnNAMEChanged();
            }
        }
        private global::System.String _NAME;
        partial void OnNAMEChanging(global::System.String value);
        partial void OnNAMEChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public global::System.String ADRESA
        {
            get
            {
                return _ADRESA;
            }
            set
            {
                OnADRESAChanging(value);
                ReportPropertyChanging("ADRESA");
                _ADRESA = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ADRESA");
                OnADRESAChanged();
            }
        }
        private global::System.String _ADRESA;
        partial void OnADRESAChanging(global::System.String value);
        partial void OnADRESAChanged();

        #endregion

        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SNET_T1Model", "FK_ORDER", "ORDER")]
        public EntityCollection<ORDER> ORDERs
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ORDER>("SNET_T1Model.FK_ORDER", "ORDER");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ORDER>("SNET_T1Model.FK_ORDER", "ORDER", value);
                }
            }
        }

        #endregion
    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "SNET_T1Model", Name = "ORDER")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class ORDER : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new ORDER object.
        /// </summary>
        /// <param name="oRDERID">Initial value of the ORDERID property.</param>
        /// <param name="dATA">Initial value of the DATA property.</param>
        /// <param name="cUSTOMERID">Initial value of the CUSTOMERID property.</param>
        /// <param name="vALOARE">Initial value of the VALOARE property.</param>
        public static ORDER CreateORDER(global::System.Int16 oRDERID, global::System.DateTime dATA, global::System.Int16 cUSTOMERID, global::System.Decimal vALOARE)
        {
            ORDER oRDER = new ORDER();
            oRDER.ORDERID = oRDERID;
            oRDER.DATA = dATA;
            oRDER.CUSTOMERID = cUSTOMERID;
            oRDER.VALOARE = vALOARE;
            return oRDER;
        }

        #endregion
        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int16 ORDERID
        {
            get
            {
                return _ORDERID;
            }
            set
            {
                if (_ORDERID != value)
                {
                    OnORDERIDChanging(value);
                    ReportPropertyChanging("ORDERID");
                    _ORDERID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ORDERID");
                    OnORDERIDChanged();
                }
            }
        }
        private global::System.Int16 _ORDERID;
        partial void OnORDERIDChanging(global::System.Int16 value);
        partial void OnORDERIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime DATA
        {
            get
            {
                return _DATA;
            }
            set
            {
                OnDATAChanging(value);
                ReportPropertyChanging("DATA");
                _DATA = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DATA");
                OnDATAChanged();
            }
        }
        private global::System.DateTime _DATA;
        partial void OnDATAChanging(global::System.DateTime value);
        partial void OnDATAChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int16 CUSTOMERID
        {
            get
            {
                return _CUSTOMERID;
            }
            set
            {
                OnCUSTOMERIDChanging(value);
                ReportPropertyChanging("CUSTOMERID");
                _CUSTOMERID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CUSTOMERID");
                OnCUSTOMERIDChanged();
            }
        }
        private global::System.Int16 _CUSTOMERID;
        partial void OnCUSTOMERIDChanging(global::System.Int16 value);
        partial void OnCUSTOMERIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Decimal VALOARE
        {
            get
            {
                return _VALOARE;
            }
            set
            {
                OnVALOAREChanging(value);
                ReportPropertyChanging("VALOARE");
                _VALOARE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("VALOARE");
                OnVALOAREChanged();
            }
        }
        private global::System.Decimal _VALOARE;
        partial void OnVALOAREChanging(global::System.Decimal value);
        partial void OnVALOAREChanged();

        #endregion

        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SNET_T1Model", "FK_ORDER", "CUSTOMER")]
        public CUSTOMER CUSTOMER
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CUSTOMER>("SNET_T1Model.FK_ORDER", "CUSTOMER").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CUSTOMER>("SNET_T1Model.FK_ORDER", "CUSTOMER").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<CUSTOMER> CUSTOMERReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<CUSTOMER>("SNET_T1Model.FK_ORDER", "CUSTOMER");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<CUSTOMER>("SNET_T1Model.FK_ORDER", "CUSTOMER", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SNET_T1Model", "FK_ORDERDETAILS", "ORDERDETAILS")]
        public EntityCollection<ORDERDETAIL> ORDERDETAILS
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ORDERDETAIL>("SNET_T1Model.FK_ORDERDETAILS", "ORDERDETAILS");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ORDERDETAIL>("SNET_T1Model.FK_ORDERDETAILS", "ORDERDETAILS", value);
                }
            }
        }

        #endregion
    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "SNET_T1Model", Name = "ORDERDETAIL")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class ORDERDETAIL : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new ORDERDETAIL object.
        /// </summary>
        /// <param name="oRDERID">Initial value of the ORDERID property.</param>
        /// <param name="pRODUS">Initial value of the PRODUS property.</param>
        /// <param name="vALOARE">Initial value of the VALOARE property.</param>
        /// <param name="sERIAL">Initial value of the SERIAL property.</param>
        public static ORDERDETAIL CreateORDERDETAIL(global::System.Int16 oRDERID, global::System.String pRODUS, global::System.Decimal vALOARE, global::System.Int16 sERIAL)
        {
            ORDERDETAIL oRDERDETAIL = new ORDERDETAIL();
            oRDERDETAIL.ORDERID = oRDERID;
            oRDERDETAIL.PRODUS = pRODUS;
            oRDERDETAIL.VALOARE = vALOARE;
            oRDERDETAIL.SERIAL = sERIAL;
            return oRDERDETAIL;
        }

        #endregion
        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int16 ORDERID
        {
            get
            {
                return _ORDERID;
            }
            set
            {
                if (_ORDERID != value)
                {
                    OnORDERIDChanging(value);
                    ReportPropertyChanging("ORDERID");
                    _ORDERID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ORDERID");
                    OnORDERIDChanged();
                }
            }
        }
        private global::System.Int16 _ORDERID;
        partial void OnORDERIDChanging(global::System.Int16 value);
        partial void OnORDERIDChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String PRODUS
        {
            get
            {
                return _PRODUS;
            }
            set
            {
                OnPRODUSChanging(value);
                ReportPropertyChanging("PRODUS");
                _PRODUS = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PRODUS");
                OnPRODUSChanged();
            }
        }
        private global::System.String _PRODUS;
        partial void OnPRODUSChanging(global::System.String value);
        partial void OnPRODUSChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Decimal VALOARE
        {
            get
            {
                return _VALOARE;
            }
            set
            {
                OnVALOAREChanging(value);
                ReportPropertyChanging("VALOARE");
                _VALOARE = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("VALOARE");
                OnVALOAREChanged();
            }
        }
        private global::System.Decimal _VALOARE;
        partial void OnVALOAREChanging(global::System.Decimal value);
        partial void OnVALOAREChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int16 SERIAL
        {
            get
            {
                return _SERIAL;
            }
            set
            {
                if (_SERIAL != value)
                {
                    OnSERIALChanging(value);
                    ReportPropertyChanging("SERIAL");
                    _SERIAL = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("SERIAL");
                    OnSERIALChanged();
                }
            }
        }
        private global::System.Int16 _SERIAL;
        partial void OnSERIALChanging(global::System.Int16 value);
        partial void OnSERIALChanged();

        #endregion

        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SNET_T1Model", "FK_ORDERDETAILS", "ORDER")]
        public ORDER ORDER
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ORDER>("SNET_T1Model.FK_ORDERDETAILS", "ORDER").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ORDER>("SNET_T1Model.FK_ORDERDETAILS", "ORDER").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<ORDER> ORDERReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<ORDER>("SNET_T1Model.FK_ORDERDETAILS", "ORDER");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<ORDER>("SNET_T1Model.FK_ORDERDETAILS", "ORDER", value);
                }
            }
        }

        #endregion
    }

    #endregion

}
