﻿using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IBusinessServices
{
    public interface IUserProfileService
    {
        UserProfile GetUserProfile(long id);
    }
}
