using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem
{
    class DataModel
    {
        public string username;


        public void setUsername(String username)
        {
            this.username = username;
        }
        public String getUsername()
        {
            return username;
        }
    }
}
