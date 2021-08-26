using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_outing
{
    public class KomodOuting_Repository
    {
        private List<Komodo_outings> _outingRepo = new List<Komodo_outings>();

        public bool AddOutingToList(Komodo_outings item)
        {
            int initial = _outingRepo.Count;
            _outingRepo.Add(item);
            bool added = _outingRepo.Count > initial;
            return added;
        }

        public List<Komodo_outings> GetList()
        {
            return _outingRepo;
        }

        

        
    }
}
