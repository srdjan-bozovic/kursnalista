﻿using Windows.UI.Xaml;

namespace MSC.Universal.Shared.UI.Controls
{
    public class ReflectionDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object newContent, DependencyObject container)
        {
            if (newContent != null)
            {
                var contentTypeName = newContent.GetType().Name + "Template";
                var local = Resources[contentTypeName] as DataTemplate;
                return local??Application.Current.Resources[contentTypeName] as DataTemplate;
            }

            return null;
        }
    }
}