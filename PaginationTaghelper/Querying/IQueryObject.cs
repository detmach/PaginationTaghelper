﻿namespace PaginationTagHelper.Querying
{
    public interface IQueryObject
    {
        string SearchBy { get; set; }
        string SearchItem { get; set; }
        string SortBy { get; set; }
        bool IsSortDescending { get; set; }
        bool ShowAll { get; set; }
    }
}
