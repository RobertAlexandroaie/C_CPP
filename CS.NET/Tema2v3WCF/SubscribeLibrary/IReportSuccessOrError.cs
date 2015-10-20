﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

/**
 * BLAGA Alexandru, Grupa 1A, Anul 3
 * DANILA Ionut, Grupa 1A, Anul 3
 */

namespace SubscribeLibrary
{
    public interface IReportSuccessOrError
    {
        [OperationContract(IsOneWay = true)]
        void OnInsertUpdateDelete(string message); 
    }
}
