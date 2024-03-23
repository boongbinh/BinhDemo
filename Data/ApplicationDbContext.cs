using Microsoft.EntityFrameworkCore;
using BinhDemo.Models.Admin.Manages;
using BinhDemo.Models.Admin.Manages.Danhmuc;
using BinhDemo.Models.Admin.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BinhDemo.Models.Admin.Systems;
using BinhDemo.Models.Admin.Setting.GoogleForm;

namespace BinhDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //Systems
        public DbSet<Users> Users { get; set; }

		//End Systems



		//Settings
		public DbSet<Form> Form { get; set; }
		public DbSet<Field> Field { get; set; }
		//End Settings



		//Manages

		//DanhMuc
		public DbSet<LoHang> LoHang { get; set; }
        
        //End Manages

    }
}
