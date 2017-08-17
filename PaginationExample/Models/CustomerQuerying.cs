﻿using PaginationTaghelper.Pagination;
using PaginationTaghelper.Querying;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaginationExample.Models
{
    public class CustomerQuerying : IPagingObject, IQueryObject
    {
        public string SearchBy { get; set; }
        public string SearchItem { get; set; }
        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }
        public bool ShowAll { get; set; }
        public int Page { get; set; }
        public int ItemPerPage { get; set; }
    }
}
