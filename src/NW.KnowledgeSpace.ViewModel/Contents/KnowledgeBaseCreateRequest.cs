﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.KnowledgeSpace.ViewModel.Contents
{
    public class KnowledgeBaseCreateRequest
    {
        public int CategoryId { get; set; }

        public string Title { get; set; }

        public string SeoAlias { get; set; }

        public string Description { get; set; }

        public string Environment { get; set; }

        public string Problem { get; set; }

        public string StepToReproduce { get; set; }

        public string ErrorMessage { get; set; }

        public string Workaround { get; set; }

        public string Note { get; set; }

        public string Labels { get; set; }
    }
}
