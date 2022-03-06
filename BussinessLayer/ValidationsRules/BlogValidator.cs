using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationsRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTittle).NotEmpty().WithMessage("Blog basligini bos gecemezsiniz.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog icerigini bos gecemezsiniz.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog gorselini bos gecemezsiniz.");
            RuleFor(x => x.BlogTittle).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az veri girişi yapın");
            RuleFor(x => x.BlogTittle).MinimumLength(5).WithMessage("Lütfen 5 karakterden daha az veri girişi yapın");
            RuleFor(x => x.Category).NotEmpty().WithMessage("Kategori kismini bos gecemezsiniz.");
        }
    }
}
