//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjA.Models
{
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography;

    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.itemNumber = new HashSet<itemNumber>();
            this.Items = new HashSet<Items>();
            this.PaymentMethod = new HashSet<PaymentMethod>();
            this.Sales = new HashSet<Sales>();
            this.Sales1 = new HashSet<Sales>();
        }

        public string userName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string mail { get; set; }
        public string area { get; set; }
        public int phoneNumber { get; set; }
        public string isAdmin { get; set; }
        public string password { get; set; }
        public string salt { get; set; }

        public virtual area area1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itemNumber> itemNumber { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Items> Items { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaymentMethod> PaymentMethod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales> Sales1 { get; set; }


        public static string GenerateRandomSalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            var bytes = new Byte[16];
            rng.GetBytes(bytes);
            return Convert.ToBase64String(bytes);
        }

        public static string doHash(string passwordPlain, string salt)
        {
            System.Security.Cryptography.SHA1 sha = System.Security.Cryptography.SHA1.Create();
            byte[] preHash = System.Text.Encoding.UTF32.GetBytes(passwordPlain + salt);
            byte[] hash = sha.ComputeHash(preHash);
            string password = System.Convert.ToBase64String(hash, 0, hash.Length);
            return password;
        }

    }
}
