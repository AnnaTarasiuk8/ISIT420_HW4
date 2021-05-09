using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ISIT420_HW4_Tarasiuk_Gurskaia.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}