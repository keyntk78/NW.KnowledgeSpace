using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NW.KnowledgeSpace.ViewModel.Contents.Report
{
    public class ReportCreateRequest
    {
        public int? KnowledgeBaseId { get; set; }

        public int? CommentId { get; set; }

        public string Content { get; set; }

        public string ReportUserId { get; set; }
    }
}
