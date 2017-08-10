using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZenLeapApi.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZenLeapApi.Controllers
{

    public class BaseController : Controller
    {
        protected UnitOfWork _unitOfWork;
        protected DataContext _context;

        protected BaseController()
            : base()
        {
            _context = new DataContext();
            _unitOfWork = new UnitOfWork(_context);
        }
    }
}
