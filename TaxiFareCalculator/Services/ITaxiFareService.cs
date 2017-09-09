using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiFareCalculator.ViewModel;

namespace TaxiFareCalculator.Services
{
    public interface ITaxiFareService
    {
        decimal CalculateFare(TaxiFareViewModel txVM);
               
    }
}
