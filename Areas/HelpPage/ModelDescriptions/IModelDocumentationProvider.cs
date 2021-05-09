using System;
using System.Reflection;

namespace ISIT420_HW4_Tarasiuk_Gurskaia.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}