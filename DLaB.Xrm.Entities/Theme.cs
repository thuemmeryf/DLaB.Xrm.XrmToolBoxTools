//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLaB.Xrm.Entities
{
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public enum ThemeState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Information that's used to set custom visual theme options for client applications.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("theme")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public partial class Theme : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string BackgroundColor = "backgroundcolor";
			public const string ControlBorder = "controlborder";
			public const string ControlShade = "controlshade";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string DefaultCustomEntityColor = "defaultcustomentitycolor";
			public const string DefaultEntityColor = "defaultentitycolor";
			public const string ExchangeRate = "exchangerate";
			public const string GlobalLinkColor = "globallinkcolor";
			public const string HeaderColor = "headercolor";
			public const string HoverLinkEffect = "hoverlinkeffect";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsDefaultTheme = "isdefaulttheme";
			public const string LogoId = "logoid";
			public const string LogoToolTip = "logotooltip";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string NavBarBackgroundColor = "navbarbackgroundcolor";
			public const string NavBarShelfColor = "navbarshelfcolor";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string ProcessControlColor = "processcontrolcolor";
			public const string SelectedLinkEffect = "selectedlinkeffect";
			public const string statecode = "statecode";
			public const string statuscode = "statuscode";
			public const string ThemeId = "themeid";
			public const string Id = "themeid";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string Type = "type";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string lk_theme_createdby = "lk_theme_createdby";
			public const string lk_theme_createdonbehalfby = "lk_theme_createdonbehalfby";
			public const string lk_theme_logoid = "lk_theme_logoid";
			public const string lk_theme_modifiedby = "lk_theme_modifiedby";
			public const string lk_theme_modifiedonbehalfby = "lk_theme_modifiedonbehalfby";
			public const string organization_theme = "organization_theme";
			public const string TransactionCurrency_Theme = "TransactionCurrency_Theme";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Theme() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "theme";
		
		public const int EntityTypeCode = 2015;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Choose the color that CRM will use for all backgrounds, including dashboards, forms, and lists.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("backgroundcolor")]
		public string BackgroundColor
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("backgroundcolor");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BackgroundColor");
				this.SetAttributeValue("backgroundcolor", value);
				this.OnPropertyChanged("BackgroundColor");
			}
		}
		
		/// <summary>
		/// Choose the color that controls will use for borders
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("controlborder")]
		public string ControlBorder
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("controlborder");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ControlBorder");
				this.SetAttributeValue("controlborder", value);
				this.OnPropertyChanged("ControlBorder");
			}
		}
		
		/// <summary>
		/// Choose the color for controls to use to indicate when you hover over items
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("controlshade")]
		public string ControlShade
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("controlshade");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ControlShade");
				this.SetAttributeValue("controlshade", value);
				this.OnPropertyChanged("ControlShade");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedBy");
				this.SetAttributeValue("createdby", value);
				this.OnPropertyChanged("CreatedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOn");
				this.SetAttributeValue("createdon", value);
				this.OnPropertyChanged("CreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Choose the default custom entity color if no color is assigned
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultcustomentitycolor")]
		public string DefaultCustomEntityColor
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("defaultcustomentitycolor");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DefaultCustomEntityColor");
				this.SetAttributeValue("defaultcustomentitycolor", value);
				this.OnPropertyChanged("DefaultCustomEntityColor");
			}
		}
		
		/// <summary>
		/// Choose the default color for system entities if no color is assigned
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultentitycolor")]
		public string DefaultEntityColor
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("defaultentitycolor");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DefaultEntityColor");
				this.SetAttributeValue("defaultentitycolor", value);
				this.OnPropertyChanged("DefaultEntityColor");
			}
		}
		
		/// <summary>
		/// Exchange rate for the currency associated with the Theme with respect to the base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Choose the color for links, such as email addresses or lookups
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("globallinkcolor")]
		public string GlobalLinkColor
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("globallinkcolor");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("GlobalLinkColor");
				this.SetAttributeValue("globallinkcolor", value);
				this.OnPropertyChanged("GlobalLinkColor");
			}
		}
		
		/// <summary>
		/// Choose the color for header text, such as form tab labels
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("headercolor")]
		public string HeaderColor
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("headercolor");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("HeaderColor");
				this.SetAttributeValue("headercolor", value);
				this.OnPropertyChanged("HeaderColor");
			}
		}
		
		/// <summary>
		/// Choose the color that commands or lists will use when you hover over the items
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hoverlinkeffect")]
		public string HoverLinkEffect
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("hoverlinkeffect");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("HoverLinkEffect");
				this.SetAttributeValue("hoverlinkeffect", value);
				this.OnPropertyChanged("HoverLinkEffect");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Default status of theme.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdefaulttheme")]
		public System.Nullable<bool> IsDefaultTheme
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdefaulttheme");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsDefaultTheme");
				this.SetAttributeValue("isdefaulttheme", value);
				this.OnPropertyChanged("IsDefaultTheme");
			}
		}
		
		/// <summary>
		/// Upload a web resource to use as a logo. Recommended dimensions are a height of 50 pixels and a maximum width of 400 pixels.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("logoid")]
		public Microsoft.Xrm.Sdk.EntityReference LogoId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("logoid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LogoId");
				this.SetAttributeValue("logoid", value);
				this.OnPropertyChanged("LogoId");
			}
		}
		
		/// <summary>
		/// Enter text that will be used as the tooltip and alt text for the logo.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("logotooltip")]
		public string LogoToolTip
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("logotooltip");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LogoToolTip");
				this.SetAttributeValue("logotooltip", value);
				this.OnPropertyChanged("LogoToolTip");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedBy");
				this.SetAttributeValue("modifiedby", value);
				this.OnPropertyChanged("ModifiedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOn");
				this.SetAttributeValue("modifiedon", value);
				this.OnPropertyChanged("ModifiedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// The name of the Theme Entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Choose the primary Navigation Bar color
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("navbarbackgroundcolor")]
		public string NavBarBackgroundColor
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("navbarbackgroundcolor");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("NavBarBackgroundColor");
				this.SetAttributeValue("navbarbackgroundcolor", value);
				this.OnPropertyChanged("NavBarBackgroundColor");
			}
		}
		
		/// <summary>
		/// Choose the secondary Navigation Bar color
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("navbarshelfcolor")]
		public string NavBarShelfColor
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("navbarshelfcolor");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("NavBarShelfColor");
				this.SetAttributeValue("navbarshelfcolor", value);
				this.OnPropertyChanged("NavBarShelfColor");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Choose the primary color for process controls
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processcontrolcolor")]
		public string ProcessControlColor
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("processcontrolcolor");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessControlColor");
				this.SetAttributeValue("processcontrolcolor", value);
				this.OnPropertyChanged("ProcessControlColor");
			}
		}
		
		/// <summary>
		/// Choose the color that commands or lists will use to indicate selected items
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("selectedlinkeffect")]
		public string SelectedLinkEffect
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("selectedlinkeffect");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SelectedLinkEffect");
				this.SetAttributeValue("selectedlinkeffect", value);
				this.OnPropertyChanged("SelectedLinkEffect");
			}
		}
		
		/// <summary>
		/// Status of the Theme
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<Entities.ThemeState> statecode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((Entities.ThemeState)(System.Enum.ToObject(typeof(Entities.ThemeState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
		}
		
		/// <summary>
		/// Reason for the status of the Theme
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue statuscode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("statuscode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("statuscode");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("themeid")]
		public System.Nullable<System.Guid> ThemeId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("themeid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ThemeId");
				this.SetAttributeValue("themeid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ThemeId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("themeid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.ThemeId = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Exchange rate for the currency associated with the Theme with respect to the base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// Define type of theme.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("type")]
		public System.Nullable<bool> Type
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("type");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Type");
				this.SetAttributeValue("type", value);
				this.OnPropertyChanged("Type");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N theme_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("theme_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<Entities.AsyncOperation> theme_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.AsyncOperation>("theme_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("theme_AsyncOperations");
				this.SetRelatedEntities<Entities.AsyncOperation>("theme_AsyncOperations", null, value);
				this.OnPropertyChanged("theme_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N theme_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("theme_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<Entities.BulkDeleteFailure> theme_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.BulkDeleteFailure>("theme_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("theme_BulkDeleteFailures");
				this.SetRelatedEntities<Entities.BulkDeleteFailure>("theme_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("theme_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N theme_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("theme_ProcessSession")]
		public System.Collections.Generic.IEnumerable<Entities.ProcessSession> theme_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.ProcessSession>("theme_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("theme_ProcessSession");
				this.SetRelatedEntities<Entities.ProcessSession>("theme_ProcessSession", null, value);
				this.OnPropertyChanged("theme_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N theme_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("theme_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<Entities.UserEntityInstanceData> theme_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.UserEntityInstanceData>("theme_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("theme_UserEntityInstanceDatas");
				this.SetRelatedEntities<Entities.UserEntityInstanceData>("theme_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("theme_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 lk_theme_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_theme_createdby")]
		public Entities.SystemUser lk_theme_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_theme_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_theme_createdby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_theme_createdby", null, value);
				this.OnPropertyChanged("lk_theme_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_theme_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_theme_createdonbehalfby")]
		public Entities.SystemUser lk_theme_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_theme_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_theme_createdonbehalfby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_theme_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_theme_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_theme_logoid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("logoid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_theme_logoid")]
		public Entities.WebResource lk_theme_logoid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.WebResource>("lk_theme_logoid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_theme_logoid");
				this.SetRelatedEntity<Entities.WebResource>("lk_theme_logoid", null, value);
				this.OnPropertyChanged("lk_theme_logoid");
			}
		}
		
		/// <summary>
		/// N:1 lk_theme_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_theme_modifiedby")]
		public Entities.SystemUser lk_theme_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_theme_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_theme_modifiedby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_theme_modifiedby", null, value);
				this.OnPropertyChanged("lk_theme_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_theme_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_theme_modifiedonbehalfby")]
		public Entities.SystemUser lk_theme_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.SystemUser>("lk_theme_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_theme_modifiedonbehalfby");
				this.SetRelatedEntity<Entities.SystemUser>("lk_theme_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_theme_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_theme
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_theme")]
		public Entities.Organization organization_theme
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.Organization>("organization_theme", null);
			}
		}
		
		/// <summary>
		/// N:1 TransactionCurrency_Theme
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Theme")]
		public Entities.TransactionCurrency TransactionCurrency_Theme
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<Entities.TransactionCurrency>("TransactionCurrency_Theme", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrency_Theme");
				this.SetRelatedEntity<Entities.TransactionCurrency>("TransactionCurrency_Theme", null, value);
				this.OnPropertyChanged("TransactionCurrency_Theme");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Theme(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["themeid"] = base.Id;
                        break;
                    case "themeid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual Theme_StatusCode? statuscodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Theme_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				statuscode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}