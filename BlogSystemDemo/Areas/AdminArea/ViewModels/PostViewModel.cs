using BlogSystemDemo.Common.Mapping;
using BlogSystemDemo.Models;
using BlogSystemDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSystemDemo.Areas.AdminArea.ViewModels
{
    public class PostViewModel : IMapFrom<Post>, IMapTo<Post>
    {
        public int Id { get; set; }

        [Display(Name = "Blog Başlığı")]
        [Required(ErrorMessage = "Litfen bir başlık yazınız")]
        [MaxLength(40,ErrorMessage ="Başlık alanı 40 karakterden fazla olamaz")]
        public string Title { get; set; }

        [Display(Name ="Blog İçerigi")]
        [Required(ErrorMessage ="Litfen bir içerik yazınız")]
        public string Content { get; set; }

        [Display(Name = "Blogu Ekleyen Admin")]
        public string AuthorId { get; set; }

        public ApplicationUserViewModel Author { get; set; }

        [Display(Name = "Blog Ekleme Tarihi")]
        public DateTime? CreatedDate { get; set; }

        public SelectList Users { get; set; }
    }
}
