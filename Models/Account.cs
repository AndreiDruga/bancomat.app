using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace bancomat.app.Models
{ 
     class Account
    {
               [Key]
            public int Id { get; set; }

            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }

             [ForeignKey("UserBalance")]
             public int UserId { get; set; }
        public virtual UserBalance UserBalance { get; set; }
    }
}
