﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.RequestFeature
{
    public class RequestParameters
    {
        const int maxPageSize = 50;

        public int PageNumber { get; set; }
      
        private int _pageSize;

        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value > maxPageSize ? value : maxPageSize; }
        }
    }
}
