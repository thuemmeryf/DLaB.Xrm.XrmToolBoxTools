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
	
	/// <summary>
	/// An invalid dependency in the CRM system.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("invaliddependency")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "8.0.1.7297")]
	public partial class InvalidDependency : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public struct Fields
		{
			public const string ExistingComponentId = "existingcomponentid";
			public const string ExistingComponentType = "existingcomponenttype";
			public const string ExistingDependencyType = "existingdependencytype";
			public const string InvalidDependencyId = "invaliddependencyid";
			public const string Id = "invaliddependencyid";
			public const string IsExistingNodeRequiredComponent = "isexistingnoderequiredcomponent";
			public const string MissingComponentId = "missingcomponentid";
			public const string MissingComponentInfo = "missingcomponentinfo";
			public const string MissingComponentLookupType = "missingcomponentlookuptype";
			public const string MissingComponentType = "missingcomponenttype";
		}

		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public InvalidDependency() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "invaliddependency";
		
		public const int EntityTypeCode = 7107;
		
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
		/// Unique identifier of the object that has an invalid dependency
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("existingcomponentid")]
		public System.Nullable<System.Guid> ExistingComponentId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("existingcomponentid");
			}
		}
		
		/// <summary>
		/// Component type of the object that has an invalid dependency
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("existingcomponenttype")]
		public Microsoft.Xrm.Sdk.OptionSetValue ExistingComponentType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("existingcomponenttype");
			}
		}
		
		/// <summary>
		/// The dependency type of the invalid dependency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("existingdependencytype")]
		public Microsoft.Xrm.Sdk.OptionSetValue ExistingDependencyType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("existingdependencytype");
			}
		}
		
		/// <summary>
		/// Unique identifier of the invalid dependency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invaliddependencyid")]
		public System.Nullable<System.Guid> InvalidDependencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("invaliddependencyid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invaliddependencyid")]
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
				base.Id = value;
			}
		}
		
		/// <summary>
		/// Indicates whether the existing node is the required component in the dependency
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isexistingnoderequiredcomponent")]
		public System.Nullable<bool> IsExistingNodeRequiredComponent
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isexistingnoderequiredcomponent");
			}
		}
		
		/// <summary>
		/// Unique identifier of the missing component.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("missingcomponentid")]
		public System.Nullable<System.Guid> MissingComponentId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("missingcomponentid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MissingComponentId");
				this.SetAttributeValue("missingcomponentid", value);
				this.OnPropertyChanged("MissingComponentId");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("missingcomponentinfo")]
		public string MissingComponentInfo
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("missingcomponentinfo");
			}
		}
		
		/// <summary>
		/// The lookup type of the missing component.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("missingcomponentlookuptype")]
		public System.Nullable<int> MissingComponentLookupType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("missingcomponentlookuptype");
			}
		}
		
		/// <summary>
		/// The object type code of the missing component.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("missingcomponenttype")]
		public Microsoft.Xrm.Sdk.OptionSetValue MissingComponentType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("missingcomponenttype");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_invaliddependency
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_invaliddependency")]
		public System.Collections.Generic.IEnumerable<Entities.UserEntityInstanceData> userentityinstancedata_invaliddependency
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<Entities.UserEntityInstanceData>("userentityinstancedata_invaliddependency", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_invaliddependency");
				this.SetRelatedEntities<Entities.UserEntityInstanceData>("userentityinstancedata_invaliddependency", null, value);
				this.OnPropertyChanged("userentityinstancedata_invaliddependency");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public InvalidDependency(object anonymousType) : 
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
                        Attributes["invaliddependencyid"] = base.Id;
                        break;
                    case "invaliddependencyid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("existingcomponenttype")]
		public virtual ComponentType? ExistingComponentTypeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ComponentType?)(EntityOptionSetEnum.GetEnum(this, "existingcomponenttype")));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("existingdependencytype")]
		public virtual DependencyType? ExistingDependencyTypeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((DependencyType?)(EntityOptionSetEnum.GetEnum(this, "existingdependencytype")));
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("missingcomponenttype")]
		public virtual ComponentType? MissingComponentTypeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ComponentType?)(EntityOptionSetEnum.GetEnum(this, "missingcomponenttype")));
			}
		}
	}
}