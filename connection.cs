﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;

namespace Student_Management
{
    class connection
    {
        public OracleConnection thisConnection = new OracleConnection("Data Source = localhost; User ID = studentmanagement; Password = stdm;");
    }
}
