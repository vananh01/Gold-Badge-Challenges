using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Claims
{
    public class ClaimsRepository
    {
        private Queue<Claims> _claimsRepository = new Queue<Claims>();

        public bool AddNewClaim(Claims claims)
        {
            if (claims != null)
            {
                _claimsRepository.Enqueue(claims);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Queue<Claims> GetClaims()
        {
            return _claimsRepository;
        }

        public Claims GetClaimsById(int id)
        {
            foreach(Claims claims in _claimsRepository)
            {
                if(claims.ClaimID == id)
                {
                    return claims;
                }
            }
            return null;
        }

        public Claims NextClaim()
        {
            return _claimsRepository.Peek();
        }

    }
}
