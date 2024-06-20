using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "عنوان الزامی است")]
        public string Title { get; set; }
        public string? Image { get; set; }
        [Required(ErrorMessage = "توضیحات الزامی است")]
        public string Description { get; set; }
        public bool IsDeleted { get; set; } = false;
        public List<ServiceDto?>? Services { get; set; }
        //public DateTime CreatedAt { get; set; }
    }
}
