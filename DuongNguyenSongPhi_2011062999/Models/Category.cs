using System.ComponentModel.DataAnnotations;
using DuongNguyenSongPhi_2011062999.Models;
namespace DuongNguyenSongPhi_2011062999.Models
{
    public class Category
    {
        private byte iD;
        [Required]
        [StringLength(255)]
        private string name;

        public byte ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}