using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class TranslationRepository : ITranslationRepository
    {
        public string GetAsync(object obj, string property, string lang)
        {
            try
            {
                return obj.GetType().GetProperty(property + "_" + lang.ToUpper()).GetValue(obj, null).ToString();
            }
            catch (NullReferenceException e)
            {
                return string.Empty;
            }
        }
    }
}
