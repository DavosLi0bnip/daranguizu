﻿using AIStudio.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AIStudio.Wpf.Business
{
    public interface IUserData
    {
        Task<List<SelectOption>> GetAllUser();
        void ClearAllUser();
        Task<List<SelectOption>> GetAllRole();
        void ClearAllRole();
        Task<List<TreeModel>> GetAllDepartment();
        void ClearAllDepartment();
    }
}