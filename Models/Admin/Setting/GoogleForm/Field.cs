using System.ComponentModel.DataAnnotations;
namespace BinhDemo.Models.Admin.Setting.GoogleForm
{
	public class Field
	{
        public int Id { get; set; }
        public string Label { get; set; }
        public string Type { get; set; } // Text, Checkbox, Radio, v.v.
        public int FormId { get; set; }
        public virtual Form Form { get; set; }
    }
}
