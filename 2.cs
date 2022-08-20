private static DependencyPropertyDescriptor GetHasErrorDescriptor(DependencyObject dependencyObject)
        {
            object descriptor = dependencyObject.GetValue(HasErrorDescriptorProperty);
            return descriptor as DependencyPropertyDescriptor;
        }
