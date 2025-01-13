﻿using System.ComponentModel.DataAnnotations;

namespace Hospital.ViewModels.Department
{
    public class DepartmentUpdateVM
    {
        [MaxLength(128)]
        public string Name { get; set; } = null!;
    }
}
