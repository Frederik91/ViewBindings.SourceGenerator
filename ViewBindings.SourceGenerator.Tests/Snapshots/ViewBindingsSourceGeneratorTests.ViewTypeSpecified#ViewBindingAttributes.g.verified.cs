//HintName: ViewBindingAttributes.g.cs

using System;

namespace ViewBindings.SourceGenerator.Contracts.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class ViewBindingAttribute : Attribute
{
    public Type? ViewType { get; set; }

    public ViewBindingAttribute()
    {
    }

    public ViewBindingAttribute(Type viewType)
    {
        ViewType = viewType;
    }
}

[AttributeUsage(AttributeTargets.Assembly)]
public class ViewBindingsNamespaceAttribute : Attribute
{
    public string Namespace { get; }

    public ViewBindingsNamespaceAttribute(string @namespace)
    {
        Namespace = @namespace;
    }
}
