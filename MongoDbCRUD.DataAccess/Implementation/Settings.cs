using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDbCRUD.DataAccess.Implementation
{
   public class Settings
    {
        public string CollectionName;
        public string ConnectionString;
        public string DatabaseName;
        public IConfigurationRoot configurationRoot;
    }
}
