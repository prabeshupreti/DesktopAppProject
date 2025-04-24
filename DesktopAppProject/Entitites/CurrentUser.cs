

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TurboMart.Entitites
{
    public class CurrentUser
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(ApplicationUserId))]
        public int ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
