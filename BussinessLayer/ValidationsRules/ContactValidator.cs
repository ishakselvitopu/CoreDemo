using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationsRules
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactMail).NotEmpty().WithMessage("Iletisim Mail Kismi Bos Birakilamaz.");
            RuleFor(x => x.ContactMessage).NotEmpty().WithMessage("Mesaj Kismi Bos Birakilamaz.");
            RuleFor(x => x.ContactSubject).NotEmpty().WithMessage("Konu Kismi Bos Birakilamaz.");
            RuleFor(x => x.ContactUserName).NotEmpty().WithMessage("Kullanici Adi Kismi Bos Birakilamaz.");
        }
    }
}
