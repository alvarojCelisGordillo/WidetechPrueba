using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WidetechPrueba.Data.Entities;

namespace WidetechPrueba.Contracts
{
    [ServiceContract]
    public interface ITest
    {
        // Whatever services are going to be implemented are defined here for the client to call. 

        [OperationContract]
        UserData GetUserToken(User userobj);
    }
}
