﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessManagementApplication.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
    }
}
