using Core;
using Core.Repositories;
using Data.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PolymerContext db;

        public IContactTextComponentRepository AddressContent { get; }
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
        public IUserRepository User{ get; set; }
        public IProductContactMessageRepository ProductContactMessage { get; set; }
        public ITranslationRepository Translation { get; set; }

        public UnitOfWork(PolymerContext db,
            IContactTextComponentRepository addressContentRepository,
            IAdminRepository adminRepository,
            ICertificateComponentFileRepository certificateComponentFileRepository,
            ICertificateComponentRepository certificateComponentRepository,
            IContactFormComponentRepository contactFormComponentRepository,
            IContactMessageRepository contactMessageRepository,
            IContactTextComponentRepository contactTextComponentRepository,
            IEventRepository eventRepository,
            IHomeBannerComponentRepository homeBannerComponentRepository,
            IHomeSliderComponentRepository homeSliderComponentRepository,
            ILocationRepository locationRepository,
            IMarketComponentFileRepository marketComponentFileRepository,
            IMarketComponentRepository marketComponentRepository,
            IMarketSubComponentFileRepository marketSubComponentFileRepository,
            IMarketSubComponentRepository marketSubComponentRepository,
            IMarketTitleComponentFileRepository marketTitleComponentFileRepository,
            IMarketTitleComponentRepository marketTitleComponentRepository,
            INavComponentRepository navComponentRepository,
            INavTitleComponentRepository navTitleComponentRepository,
            INewsFileRepository newsFileRepository,
            INewsRepository newsRepository,
            IProductBrochureRepository productBrochureRepository,
            IProductFieldRepository productFieldRepistory,
            IProductRepository productRepository,
            IProductCategoryPropertyRepository productCategoryPropertyRepository,
            IProductCategoryRepository productCategoryRepository,
            IProductTitleCategoryRepository productTitleCategoryRepository,
            IUserRepository userRepository,
            IProductContactMessageRepository productContactMessageRepository,
            ITranslationRepository translationRepository)
        {
            this.db = db;
            AddressContent = addressContentRepository;
            Admin = adminRepository;
            CertificateComponentFile = certificateComponentFileRepository;
            CertificateComponent = certificateComponentRepository;
            ContactFormComponent = contactFormComponentRepository;
            ContactMessage = contactMessageRepository;
            ContactTextComponent = contactTextComponentRepository;
            Event = eventRepository;
            HomeBannerComponent = homeBannerComponentRepository;
            HomeSliderComponent = homeSliderComponentRepository;
            Location = locationRepository;
            MarketComponentFile = marketComponentFileRepository;
            MarketComponent = marketComponentRepository;
            MarketSubComponentFile = marketSubComponentFileRepository;
            MarketSubComponent = marketSubComponentRepository;
            MarketTitleComponentFile = marketTitleComponentFileRepository;
            MarketTitleComponent = marketTitleComponentRepository;
            NavComponent = navComponentRepository;
            NavTitleComponent = navTitleComponentRepository;
            NewsFile = newsFileRepository;
            News = newsRepository;
            ProductBrochure = productBrochureRepository;
            ProductField = productFieldRepistory;
            ProductCategoryProperty = productCategoryPropertyRepository;
            ProductCategory = productCategoryRepository;
            ProductTitleCategory = productTitleCategoryRepository;
            Product = productRepository;
            ProductContactMessage = productContactMessageRepository;
            User = userRepository;
            Translation = translationRepository;
        }

        public async Task CommitAsync()
        {
            await db.SaveChangesAsync();
        }
    }
}
