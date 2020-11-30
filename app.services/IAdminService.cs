using System;
using app.domain;
using app.service.Admin.Commands.CreateAdmin;

namespace app.service
{
    public interface IAdminService
    {
        CreateProfessorResult CreateAdmin(CreateProfessorCommand prof);
    }
}
