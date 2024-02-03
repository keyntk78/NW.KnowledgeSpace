using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.KnowledgeSpace.ViewModel.Systems.Command
{
    public class AddCommandToFunctionRequest
    {
        public string CommandId { get; set; }

        public string FunctionId { get; set; }
    }
}
