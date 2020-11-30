using System;
using System.Collections.Generic;
using System.Text;
using app.domain;
using app.repository;
using Microsoft.EntityFrameworkCore;
using app.service.Admin.Commands.CreateAdmin;
using System.Linq;

namespace app.service.Admin
{
    public class AdminService : IAdminService
    {
        private readonly IRepository<Professor> _profRepo;
        public AdminService(IRepository<Professor> profRepo)
        {
            this._profRepo = profRepo;
        }
        public CreateProfessorResult CreateAdmin(CreateProfessorCommand prof)
        {
            var entity = new Professor
            {
                Person = new Person
                {
                    FirstName = prof.FirstName,
                    LastName = prof.LastName,
                    MiddleInitial = prof.MiddleInitial,
                    Gender = prof.Gender,
                    ContactNumber = prof.ContactNumber

                },
                Department = prof.Department
            };

            _profRepo.Create(entity);
            _profRepo.SaveChanges();

            return new CreateProfessorResult
            {
                ID = entity.ID
            };
        }
    }
}
