using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IUnitOfWork
    {
        public IAdminRepository Admin { get; }
        public ICertificateComponentFileRepository CertificateComponentFile { get; }
        public ICertificateComponentRepository CertificateComponent { get; }
        public IContactFormComponentRepository ContactFormComponent { get; }
        public IContactMessageRepository ContactMessage { get; }
        public IContactTextComponentRepository ContactTextComponent { get; }
        public IEventRepository Event { get; set; }
        public IHomeBannerComponentRepository HomeBannerComponent { get; }
        public IHomeSliderComponentRepository HomeSliderComponent { get; }
        public ILocationRepository Location { get; }
        public IMarketComponentFileRepository MarketComponentFile { get; }
        public IMarketComponentRepository MarketComponent { get; }
        public IMarketSubComponentFileRepository MarketSubComponentFile { get; }
        public IMarketSubComponentRepository MarketSubComponent { get; }
        public IMarketTitleComponentFileRepository MarketTitleComponentFile { get; }
        public IMarketTitleComponentRepository MarketTitleComponent { get; }
        public INavComponentRepository NavComponent { get; }
        public INavTitleComponentRepository NavTitleComponent { get; }
        public INewsFileRepository NewsFile { get; }
        public INewsRepository News { get; }
        public IProductBrochureRepository ProductBrochure { get; }
        public IProductFieldRepository ProductField { get; }
        public IProductRepository Product { get; }
        public IProductCategoryPropertyRepository ProductCategoryProperty { get; }
        public IProductCategoryRepository ProductCategory { get; }
        public IProductTitleCategoryRepository ProductTitleCategory { get; }
        public IUserRepository User { get; set; }
        public IProductContactMessageRepository ProductContactMessage { get; set; }
        public ITranslationRepository Translation { get; set; }

        Task CommitAsync();
    }
}
