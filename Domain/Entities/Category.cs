﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category:AuditableBaseEntity
    {
        public string? CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public Guid? CategoryChildrenId { get; set; }
        public int? NumOrder { get; set; }
        public ICollection<Category>? ChildrenCategories { get; set; }
        public Category? ParentCategory { get; set; }

    }
}
