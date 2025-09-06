using Microsoft.CodeAnalysis.CSharp.Syntax;
namespace ViewBindings.SourceGenerator.Extensions;

public static class ClassDeclarationSyntaxExtensions
{
    public static bool HasViewBindingAttribute(this ClassDeclarationSyntax classDeclarationSyntax)
    {
        foreach (var attributeList in classDeclarationSyntax.AttributeLists)
        {
            foreach (var attribute in attributeList.Attributes)
            {
                var name = attribute.Name.ToString();
                if (name == "ViewBinding" || name == "ViewBindingAttribute")
                    return true;
            }
        }
        return false;
    }
}