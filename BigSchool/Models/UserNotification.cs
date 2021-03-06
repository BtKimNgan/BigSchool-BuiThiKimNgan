using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace BigSchool.Models
{
    public class UserNotification
    {
        [Key]
        [Column(Order = 1)]
        public string UserId { get; set; }
        [Key]
        [Column(Order = 1)]
        public int NotificationId { get; set; }
        public ApplicationUser User { get; set; }
        public Notification Notification { get; set; }
        public bool IsRead { get; set; }

    }
}