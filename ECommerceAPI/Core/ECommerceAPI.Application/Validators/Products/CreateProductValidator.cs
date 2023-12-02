using ECommerceAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<ProductCreate>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please fill in the product name")
                .MaximumLength(150)
                .MinimumLength(3)
                    .WithMessage("Please enter the product name from 5 to 100");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please fill in the product stock")
                .Must(s => s >= 0)
                    .WithMessage("Product stock can not be negative!");

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please fill in the product price")
                .Must(s => s >= 0)
                    .WithMessage("Product price can not be negative!");

        }
    }
}
