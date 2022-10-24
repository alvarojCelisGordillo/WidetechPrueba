using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WidetechPrueba.Contracts;
using WidetechPrueba.Data.Entities;

namespace WidetechPrueba.Services
{
    public class TestManager : ITest
    {
        public UserData GetUserToken(User userobj)
        {
            // Here the business logic is implemented for the it not to be exposed to the client. 
            UserData userData = new UserData();
            
            // A call to the Data access layer (DAL) can be made here. For sakes of simplicity I'll just hard code it. 
            // The mapping to the UserData class can be done here if the DB returns a complete User model class and not expose all the data to the client. 

            userData.UserId = 1;
            userData.UserToken = "FSfre3243dfvsdafsadfe2#$";
            return userData;
        }
    }
}