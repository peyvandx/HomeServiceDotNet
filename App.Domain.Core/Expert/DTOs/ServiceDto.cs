using App.Domain.Core.Expert.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.DTOs
{
    public class ServiceDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "عنوان الزامی است")]
        public string? Title { get; set; }
        public string? Image { get; set; }
        [Required(ErrorMessage = "توضیحات مختصر الزامی است")]
        public string? ShortDescription { get; set; }
        [Required(ErrorMessage = "توضیحات کامل الزامی است")]
        public string? Description { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int CategoryId { get; set; }
    }
}
