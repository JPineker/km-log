﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KmLog.Server.DTO.Base;
using KmLog.Server.Model.Base;

namespace KmLog.Server.Dal.Base
{
    public interface IBaseRepository<TEntity, TDTO> 
        where TEntity : IdentifiableBase
        where TDTO : IdentifiableBaseDTO
    {
        Task Add(IEnumerable<TDTO> entities);

        Task Add(TDTO entity);

        Task Delete(Guid id);

        Task<TDTO> GetById(Guid id);

        Task<IEnumerable<TDTO>> LoadAll();

        Task Update(TDTO entity);
    }
}
