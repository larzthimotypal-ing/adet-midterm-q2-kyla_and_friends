using System;
using System.Collections.Generic;
using System.Text;

namespace app.service.Admin.Commands.CreateAdmin
{
    public class CreateProfessorCommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public string Gender { get; set; }
        public string ContactNumber { get; set; }
        public string Department { get; set; }

    }
}
