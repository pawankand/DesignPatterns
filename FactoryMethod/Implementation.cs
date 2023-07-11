using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class DiscountServices
    {
        public abstract int DiscountPercentage { get; }
        public override string ToString()
        {
            return GetType().Name; 
        }
    }

    public class CountryDiscountService : DiscountServices
    {
        private readonly string _countryIdentifyer;

        public CountryDiscountService(string countryIdentifyer)
        {
                _countryIdentifyer = countryIdentifyer;
        }

        public override int DiscountPercentage
        {
            get
            {
                switch(_countryIdentifyer)
                {
                    case "BE":
                        return 20;
                    default: return 10;
                }
            }
        }
    }

    public class CodeDiscountService: DiscountServices
    {
        private readonly Guid _code;

        public CodeDiscountService(Guid code) => _code = code;

        public override int DiscountPercentage
        {
            get => 15;
        }
    }

    public abstract class DiscountFactory
    {
        public abstract DiscountServices CreateDiscountServie();
    }

    public class CountryDiscountFactory:DiscountFactory 
    {
        private readonly string _countryIdentifier;

        public CountryDiscountFactory(string countryIdentifier)
        {
                _countryIdentifier = countryIdentifier;
        }

        public override DiscountServices CreateDiscountServie()
        {
            return new CountryDiscountService(_countryIdentifier);
        }
    }

    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _code;

        public CodeDiscountFactory(Guid code) => _code = code;

        public override DiscountServices CreateDiscountServie()
        {
            return new CodeDiscountService(_code);
        }
    }
}
