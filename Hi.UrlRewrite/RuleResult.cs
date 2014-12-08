﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Hi.UrlRewrite
{
    public class RuleResult
    {
        public int? StatusCode { get; set; }
        public bool StopProcessing { get; set; }
        public HttpCacheability? HttpCacheability { get; set; }
        public Uri OriginalUri { get; set; }
        public Uri RewrittenUri { get; set; }
        public Guid ItemId { get; set; }

        public bool UrlIsRewritten
        {
            get
            {

                var originalUrl = OriginalUri.ToString();
                var rewrittenUrl = RewrittenUri.ToString();

                return !originalUrl.Equals(rewrittenUrl, StringComparison.InvariantCultureIgnoreCase);
            }
        }
    }
}