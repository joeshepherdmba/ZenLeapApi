using System;
using Microsoft.EntityFrameworkCore;
using ZenLeapApi.Models;
using EF_Core_Generics.Repos;

namespace ZenLeapApi.Repositories
{
    public class UnitOfWork :IDisposable
    {
        private DbContext _context = null;
        private UserRepository _userRepository;
        private GenericRepository<Project> _projectRepository;
        private GenericRepository<ProjectTask> _projectTaskRepository;
        private GenericRepository<Company> _companyRepository;

        public UnitOfWork(DbContext context)
        {
            this._context = context;
        }

		/// <summary>
		/// Get/Set Property for user repository.
		/// </summary>
		public UserRepository UserRepository
		{
			get
			{
				if (this._userRepository == null)
					this._userRepository = new UserRepository(_context);
				return _userRepository;
			}
		}

		/// <summary>
		/// Get/Set Property for Project repository.
		/// </summary>
		public GenericRepository<Project> ProjectRepository
		{
			get
			{
				if (this._projectRepository == null)
					this._projectRepository = new GenericRepository<Project>(_context);
				return _projectRepository;
			}
		}

		/// <summary>
		/// Get/Set Property for ProjectTask repository.
		/// </summary>
		public GenericRepository<ProjectTask> ProjectTaskRepository
		{
			get
			{
				if (this._projectTaskRepository == null)
					this._projectTaskRepository = new GenericRepository<ProjectTask>(_context);
				return _projectTaskRepository;
			}
		}

		/// <summary>
		/// Get/Set Property for Company repository.
		/// </summary>
		public GenericRepository<Company> CompanyRepository
		{
			get
			{
				if (this._companyRepository == null)
					this._companyRepository = new GenericRepository<Company>(_context);
				return _companyRepository;
			}
		}


		public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
