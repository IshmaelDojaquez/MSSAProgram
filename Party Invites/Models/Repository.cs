using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3_PartyInvites_.Models
{
    public class Repository
    {
        //Fields and Properties

        private static List<GuestResponse> Responses = new List<GuestResponse>();


        //Constructors


        //Methods
        
        public static void AddResponse(GuestResponse Response)
        {
            Responses.Add(Response);
        }

        public static List<GuestResponse> GetResponses()
        {
            return Responses;
        }
    }
}
