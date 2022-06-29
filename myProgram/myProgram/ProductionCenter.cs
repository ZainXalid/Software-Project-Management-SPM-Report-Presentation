using System;
using System.Collections.Generic;
using System.Text;

namespace myProgram
   
{
    enum productCatergory { Computer, smartPhone, smartWatch, TV, Camera, Speaker };
    class ProductionCenter
    {
        productCatergory? category;
        private int numberOfVariants;
        private string[,] VariantNamePrice;

        public ProductionCenter()
            {
            category = null;
            numberOfVariants = 0;
            VariantNamePrice = new string[numberOfVariants,numberOfVariants];
            }

        public ProductionCenter(productCatergory category, int numberOfVariants, string VariantNamEPrice)
        {
            this.category = category;
            this.numberOfVariants = numberOfVariants;
            this.VariantNamePrice = VariantNamePrice;
        }


    }
}
