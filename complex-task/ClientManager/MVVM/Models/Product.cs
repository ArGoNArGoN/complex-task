using System;

namespace ClientManager.MVVM.Models
{
    internal class Product
        : BaseModelIdentity<Int32>
    {
        private String title;
        private Decimal minPrice;
        private String annotation;
        private String image;
        private Category category;
        private Int32 idCategory;

        public String Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }
        public Decimal MinPrice
        {
            get { return minPrice; }
            set
            {
                minPrice = value;
                OnPropertyChanged(nameof(MinPrice));
            }
        }
        public String Annotation
        {
            get { return annotation; }
            set
            {
                annotation = value;
                OnPropertyChanged(nameof(Annotation));
            }
        }
        public String Image
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged(nameof(Image));
            }
        }
        
        public Category Category
        {
            get { return category; }
            set
            {
                category = value;
                OnPropertyChanged(nameof(Category));
            }
        }

        public Int32 IdCategory
        {
            get { return idCategory; }
            set 
            {
                idCategory = value;
                OnPropertyChanged(nameof(IdCategory));
            }
        }

        public Product()
            : base() { }

        public override Boolean IsValid { get; } = true;
    }
}