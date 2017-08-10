using System;
using Microsoft.EntityFrameworkCore;
using ZenLeapApi.Data;

namespace ZenLeapApi.Services
{
    /// <summary>
    /// Uses Unit of Work to call appropriate Repos.
    /// Uses data transfer opbjects and handles the transformation of data models to view models. 
    /// </summary>
    public class BaseService
    {
        protected UnitOfWork _unitOfWork;

        public BaseService(DbContext context)
        {
            _unitOfWork = new UnitOfWork(context);
        }
    }
}
