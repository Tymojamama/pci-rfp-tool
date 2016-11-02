using DataIntegrationHub.Business.Entities;
using DataIntegrationHub.Business.Components;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RfpTool.Security
{
    public partial class SecurityComponent
    {
        public User User { get; private set; }
        public List<SecurityRole> SecurityRoles { get; private set; }

        public SecurityComponent(User _user)
        {
            User = _user;
            SecurityRoles = UserSecurityRole.GetAssociatedFromUser(_user);
        }
    }
}
