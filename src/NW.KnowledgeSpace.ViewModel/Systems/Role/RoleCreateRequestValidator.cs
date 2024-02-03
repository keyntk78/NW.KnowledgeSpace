using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NW.KnowledgeSpace.ViewModel.Systems.Role;

namespace NW.KnowledgeSpace.ViewModel.Systems
{
    public class RoleCreateRequestValidator :AbstractValidator<RoleCreateRequest>
    {
        public RoleCreateRequestValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id value is required")
                .MaximumLength(50).WithMessage("Role id cannot over limit 50 characters");

            RuleFor(x => x.Name).NotEmpty().WithMessage("Role name value is required");
        }
    }
}
