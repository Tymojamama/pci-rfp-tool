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
        public bool IsAdmin()
        {
            foreach (SecurityRole _securityRole in this.SecurityRoles)
            {
                if (_securityRole.SecurityRoleId == new Guid("6E2CF60A-B22B-49CE-BBC7-0BD4210B15B4"))
                    return true;
            }

            return false;
        }
    }
}
