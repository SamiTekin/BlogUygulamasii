using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogUygulamasi.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category() { KategoriAdi="C#" },
                 new Category() { KategoriAdi="MVC" },
                   new Category() { KategoriAdi="Web Form" },
                    new Category() { KategoriAdi="Windows Form" }

            };
            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);

            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>()
            {


                new Blog() { Baslik = "C# Nedir  " , Aciklama = "HAKKINDA", EklenmeTarihi = DateTime.Now.AddDays(-10), Anasayfa = true, Onay = true, İcerik = "hakkında kısmı ", Resim = "cSharp.jpg",  Id= 1 ,CategoryId=2 },
                new Blog() { Baslik = "MVC", Aciklama = "HAKKINDA C# Delegates hakkında C# Delegates hakkında C# Delegates hakkında", EklenmeTarihi = DateTime.Now.AddDays(-20), Anasayfa = true, Onay = true, İcerik = "hakkında kısmı ", Resim = "Mvc.jpg", Id = 1, CategoryId = 1 },
                new Blog() { Baslik = "C#", Aciklama = "HAKKINDA", EklenmeTarihi = DateTime.Now.AddDays(-10), Anasayfa = true, Onay = false, İcerik = "hakkında kısmı ", Resim = "cSharp.jpg", Id = 2, CategoryId = 2 },
                new Blog() { Baslik = "Web Form", Aciklama = "HAKKINDA", EklenmeTarihi = DateTime.Now.AddDays(-20), Anasayfa = true, Onay = true, İcerik = "hakkında kısmı ", Resim = "WobForm.jpg", Id = 1, CategoryId = 1 },
                new Blog() { Baslik = "Windows Form", Aciklama = "HAKKINDA", EklenmeTarihi = DateTime.Now.AddDays(-10), Anasayfa = true, Onay = true, İcerik = "hakkında kısmı ", Resim = "windowsForms.jpg", Id = 1, CategoryId = 3 },
                new Blog() { Baslik = "MVC", Aciklama = "HAKKINDA", EklenmeTarihi = DateTime.Now.AddDays(-10), Anasayfa = true, Onay = false, İcerik = "hakkında kısmı ", Resim = "1.jpg", Id = 4, CategoryId = 4 },
                new Blog() { Baslik = "Web Form", Aciklama = "HAKKINDA", EklenmeTarihi = DateTime.Now.AddDays(-10), Anasayfa = true, Onay = true, İcerik = "hakkında kısmı ", Resim = "WebForm.jpg", Id = 1, CategoryId = 2 },
                new Blog() { Baslik = "MVC", Aciklama = "HAKKINDA", EklenmeTarihi = DateTime.Now.AddDays(-20), Anasayfa = true, Onay = false, İcerik = "hakkında kısmı ", Resim = "Mvc.jpg", Id = 3, CategoryId = 4 },
                new Blog() { Baslik = "Windows Form", Aciklama = "HAKKINDA", EklenmeTarihi = DateTime.Now.AddDays(-10), Anasayfa = true, Onay = true, İcerik = "hakkında kısmı ", Resim = "windowsForms.jpg", Id = 1, CategoryId = 2 },
                new Blog() { Baslik = "C#", Aciklama = "HAKKINDA", EklenmeTarihi = DateTime.Now.AddDays(-10), Anasayfa = true, Onay = true, İcerik = "hakkında kısmı ", Resim = "cSharp.jpg", Id = 2, CategoryId = 4 },
                new Blog() { Baslik = "MVC", Aciklama = "HAKKINDA", EklenmeTarihi = DateTime.Now.AddDays(-10), Anasayfa = true, Onay = false, İcerik = "hakkında kısmı ", Resim = "Mvc.jpg", Id = 1, CategoryId = 3 },
            };


            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);

        }
    }
}
