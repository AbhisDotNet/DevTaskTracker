﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTaskTracker.Application.DTOs.PaginatedDtos
{
    public class PaginatedResult
    {
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        //public bool HasPrevious => CurrentPage > 1;
        //public bool HasNext => CurrentPage < TotalPages;
    }
}
