using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SpryStore.EntityLayer.Concrete;

namespace SpryStore.BusinessLayer.ValidationRules.ContactValidationRules
{
    public class ContactAddValidator : AbstractValidator<Contact>
    {
        public ContactAddValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj alanı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(x => x.NameSurname).MinimumLength(5).WithMessage("Lütfen en az 5 karakter girişi yapınız");
            RuleFor(x => x.Mail).MinimumLength(12).WithMessage("Lütfen en az 12 karakter girişi yapınız");
            RuleFor(x => x.NameSurname).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter girişi yapınız");
            RuleFor(x => x.Mail).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter girişi yapınız");
            RuleFor(x => x.MessageContent).MaximumLength(100).WithMessage("Lütfen mesaj karakterini azaltınız");
            //RuleFor(x => x.NameSurname).Equal("a").WithMessage("Lütfen için a harfi geçen bir isim giriniz");
        }
    }
}
