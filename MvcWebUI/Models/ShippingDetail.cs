using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Models
{
    public class ShippingDetail
    {
        //[Required(ErrorMessage = "Adı alanı boş bırakılamaz.")]
        public string FirstName { get; set; }

        //[Required(ErrorMessage = "Soyadı alanı boş bırakılamaz.")]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "E-posta alanı boş bırakılamaz.")]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Şehir alanı boş bırakılamaz.")]
        //[MinLength(3, ErrorMessage = "Minimum 10 karakter olmalıdır")]
        public string City { get; set; }

        //[Required(ErrorMessage = "Adres alanı boş bırakılamaz.")]
        public string Address { get; set; }


        //[Required(ErrorMessage = "Yaş alanı boş bırakılamaz.")]
        [Range(18,65, ErrorMessage = "Yaş aralığı 18 ile 65 arasındadır.")] //hangi sayı aralığında sayı girebilir onu söylüyoruz.
        public int Age { get; set; }
    }
}
