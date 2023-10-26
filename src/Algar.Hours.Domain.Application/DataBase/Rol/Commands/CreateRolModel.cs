using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algar.Hours.Application.DataBase.Rol.Commands
{
    public class CreateRolModel
    {
        public Guid IdRole { get; set; }
        public string NameRole { get; set; }
    }
}
