using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            // This method will fill the _pies List with Pie objects...from where?
        }

        public IEnumerable<Pie> GetAllPies()
        {
            throw new NotImplementedException();
        }

        public Pie GetPieById(int pieId)
        {
            throw new NotImplementedException();
        }
    }
}
