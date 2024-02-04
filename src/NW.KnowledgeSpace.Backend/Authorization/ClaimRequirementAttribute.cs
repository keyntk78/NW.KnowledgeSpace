using Microsoft.AspNetCore.Mvc;
using NW.KnowledgeSpace.Backend.Constants;

namespace NW.KnowledgeSpace.Backend.Authorization
{
    public class ClaimRequirementAttribute : TypeFilterAttribute
    {
        public ClaimRequirementAttribute(FunctionCode functionId, CommandCode commandId)
            : base(typeof(ClaimRequirementFilter))
        {
            Arguments = new object[] { functionId, commandId };
        }
    }
}
