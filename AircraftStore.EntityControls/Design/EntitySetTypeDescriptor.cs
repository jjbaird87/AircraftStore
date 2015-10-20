using System;
using System.ComponentModel;

namespace EFWinforms.Design
{
    /// <summary>
    /// Exposes all the EntitySets in a EntityDataSource as a list of PropertyDescriptor objects.
    /// </summary>
    /// <remarks>
    /// This is required for showing the available EntitySets in the drop down that
    /// appears when editing the "DataMember" property of a complex bound control.
    /// 
    /// Reflected from DataViewManagerListItemTypeDescriptor
    /// </remarks>
    class EntitySetTypeDescriptor : ICustomTypeDescriptor
    {
        //----------------------------------------------------------------------------
        #region ** fields

        readonly EntityDataSource _dataSource;
        PropertyDescriptorCollection _pdc;

        #endregion

        //----------------------------------------------------------------------------
        #region ** methods

        internal EntitySetTypeDescriptor(EntityDataSource dataSource)
        {
            _dataSource = dataSource;
        }
        internal void Reset()
        {
            _pdc = null;
        }

        #endregion

        //----------------------------------------------------------------------------
        #region ** ICustomTypeDescriptor

        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties(Attribute[] attributes)
        {
            if (_pdc == null)
            {
                int count = _dataSource.EntitySets.Count;
                var properties = new PropertyDescriptor[count];
                for (int i = 0; i < count; i++)
                {
                    properties[i] = new EntitySetPropertyDescriptor(_dataSource.EntitySets[i]);
                }
                _pdc = new PropertyDescriptorCollection(properties);
            }
            return _pdc;
        }
        object ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { return this; }
        AttributeCollection ICustomTypeDescriptor.GetAttributes() { return new AttributeCollection(null); }
        string ICustomTypeDescriptor.GetClassName() { return null; }
        string ICustomTypeDescriptor.GetComponentName() { return null; }
        TypeConverter ICustomTypeDescriptor.GetConverter() { return null; }
        EventDescriptor ICustomTypeDescriptor.GetDefaultEvent() { return null; }
        PropertyDescriptor ICustomTypeDescriptor.GetDefaultProperty() { return null; }
        object ICustomTypeDescriptor.GetEditor(Type editorBaseType) { return null; }
        EventDescriptorCollection ICustomTypeDescriptor.GetEvents() { return new EventDescriptorCollection(null); }
        EventDescriptorCollection ICustomTypeDescriptor.GetEvents(Attribute[] attributes) { return new EventDescriptorCollection(null); }
        PropertyDescriptorCollection ICustomTypeDescriptor.GetProperties() { return ((ICustomTypeDescriptor)this).GetProperties(null); }

        #endregion
    }

    /// <summary>
    /// Custom PropertyDescriptor used by the EntitySetTypeDescriptor (above)
    /// to expose EntitySets as properties.
    /// </summary>
    /// <remarks>
    /// Reflected from DataTablePropertyDescriptor
    /// </remarks>
    class EntitySetPropertyDescriptor : PropertyDescriptor
    {
        //----------------------------------------------------------------------------
        #region ** fields

        readonly EntitySet _view;

        #endregion

        //----------------------------------------------------------------------------
        #region ** ctor

        internal EntitySetPropertyDescriptor(EntitySet view)
            : base(view.Name, null)
        {
            _view = view;
        }

        #endregion

        //----------------------------------------------------------------------------
        #region ** overrides

        public override bool CanResetValue(object component)
        {
            return false;
        }
        public override bool Equals(object other)
        {
            var propertyDescriptor = other as EntitySetPropertyDescriptor;
            if (propertyDescriptor != null)
            {
                var descriptor = propertyDescriptor;
                return descriptor._view == _view;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return _view.GetHashCode();
        }
        public override object GetValue(object component)
        {
            return _view.List;
        }
        public override void ResetValue(object component) { }
        public override void SetValue(object component, object value) { }
        public override bool ShouldSerializeValue(object component) { return false; }
        public override Type ComponentType => typeof(EntitySet);
        public override bool IsReadOnly => false;
        public override Type PropertyType => typeof(IBindingList);

        #endregion
    }
}
