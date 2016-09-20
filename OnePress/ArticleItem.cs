using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnePress
{
    public class ArticleItem
    {
        public ArticleItem() { }

        public string id { get; }

        public string date { get; }

        public string date_gmt { get; }

        public string guid { get; }

        public string modified { get; }

        public string modified_gmt { get; }

        public string slug { get; }

        public string type { get; }

        public string link { get; }

        public string title { get; }

        public string content { get; }

        public string excerpt { get; }

        public string author { get; }

        public string featured_media { get; }

        public string comment_status { get; }

        public string ping_status { get; }

        public string sticky { get; }

        public string format { get; }

        public string categories { get; }

        public string tags { get; }
    }
}
