using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface ITranslationRepository
    {
        string GetAsync(object obj, string property, string lang);
    }
}
