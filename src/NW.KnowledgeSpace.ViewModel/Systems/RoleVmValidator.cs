using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace NW.KnowledgeSpace.ViewModel.Systems
{
    public class RoleVmValidator :AbstractValidator<RoleVm>
    {
        public RoleVmValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id value is required")
                .MaximumLength(50).WithMessage("Role id cannot over limit 50 characters");

            RuleFor(x => x.Name).NotEmpty().WithMessage("Role name value is required");
        }
    }
}
