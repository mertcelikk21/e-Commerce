﻿using eTicaret.Core.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTicaret.Core.Specification
{
    public class ProductWithFiltersForCountSpecification:BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductSpecParams productSpecParams):base(
                 x => (string.IsNullOrWhiteSpace(productSpecParams.Search) || x.Name.ToLower().Contains(productSpecParams.Search)) &&
                 (!productSpecParams.BrandId.HasValue || x.ProductBrandId == productSpecParams.BrandId)
                 &&
                 (!productSpecParams.TypeId.HasValue || x.ProductTypeId == productSpecParams.TypeId)
                 )
        {

        }
    }
}
