﻿
namespace PaginationTaghelper.Pagination
{
    public interface IPagingObject
    {
        int Page { get; set; }
        int ItemPerPage { get; set; }
    }
}