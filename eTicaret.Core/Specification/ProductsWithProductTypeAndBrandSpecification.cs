﻿using eTicaret.Core.DbModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTicaret.Core.Specification
{
    public class ProductsWithProductTypeAndBrandSpecification:BaseSpecification<Product>
    {
        public ProductsWithProductTypeAndBrandSpecification(ProductSpecParams productSpecParams)
            :base(
                 x=>(string.IsNullOrWhiteSpace(productSpecParams.Search)||x.Name.ToLower().Contains(productSpecParams.Search))&&
                 (!productSpecParams.BrandId.HasValue || x.ProductBrandId== productSpecParams.BrandId)
                 &&
                 (!productSpecParams.TypeId.HasValue||x.ProductTypeId== productSpecParams.TypeId)
                 )
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
            //AddOrderBy(x => x.Name);

            ApplyPaging(productSpecParams.PageSize * (productSpecParams.PageIndex - 1), productSpecParams.PageSize);

            if (!string.IsNullOrWhiteSpace(productSpecParams.Sort))
            {
                switch (productSpecParams.Sort)
                {
                    case"priceAsc":
                        AddOrderBy(p => p.Price);
                        break;

                    case "priceDesc":
                        AddOrderByDescending(p => p.Price);
                        break;

                    default:
                        AddOrderBy(x => x.Name);
                        break;
                }
            }
        }
        public ProductsWithProductTypeAndBrandSpecification(int id):base(x=>x.Id==id)
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
        }
    }
}
