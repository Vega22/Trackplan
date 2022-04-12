using System;
using System.ComponentModel.DataAnnotations;

namespace Trackplan.Models
{
    public class MessageModel
    {
        [Required]
        public string Message { get; set; }

    }
}
