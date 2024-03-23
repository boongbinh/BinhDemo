using System.ComponentModel.DataAnnotations;

namespace BinhDemo.Models.Admin.Setting.GoogleForm
{
	public class Form
	{
		public int Id { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<Field> Fields { get; set; }
    }
}
