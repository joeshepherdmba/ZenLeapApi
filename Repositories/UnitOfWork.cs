using System;

using Microsoft.EntityFrameworkCore;
using ZenLeapApi.Models;
using EF_Core_Generics.Repos;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

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


#region Implementing IDiosposable...

#region private dispose variable declaration...
		private bool disposed = false;
#endregion

		/// <summary>
		/// Protected Virtual Dispose method
		/// </summary>
		/// <param name="disposing"></param>
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					Debug.WriteLine("UnitOfWork is being disposed");
					_context.Dispose();
				}
			}
			this.disposed = true;
		}

		/// <summary>
		/// Dispose method
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
#endregion

		/// <summary>
		/// Save method.
		/// </summary>
		public async Task<int> CommitChangesAsync()
		{
            return await _context.SaveChangesAsync();
			//try
			//{
			//	_context.SaveChanges();
			//}
			//catch (DbEntityValidationException e)
			//{

			//	var outputLines = new List<string>();
			//	foreach (var eve in e.EntityValidationErrors)
			//	{
			//		outputLines.Add(string.Format(
			//			"{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now,
			//			eve.Entry.Entity.GetType().Name, eve.Entry.State));
			//		foreach (var ve in eve.ValidationErrors)
			//		{
			//			outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
			//		}
			//	}
			//	System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);

			//	throw e;
			//}

		}

	}
}
