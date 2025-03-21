﻿using ProjectMono.Common.PagedResultCommon;
using ProjectMono.Common.ParametersCommon;
using ProjectMono.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMono.Repository.Common
{
    public interface IVehicleModelRepositroy
    {
        //Create
        Task AddVehicleModelAsync(IVehicleModel entity);
        //Read
        Task<IVehicleModel> GetVehicleModelAsync(int id);
        Task<IPagedResult<IVehicleModel>> GetVehicleModelsAsync(ISortParameters sortParameters, IFilterParameters filterParameters, IPageParameters pageParameters);
        //Update
        Task UpdateVehicleModelAsync(IVehicleModel entity);
        //Delete
        Task DeleteVehicleModelAsync(IVehicleModel entity);
    }
}
