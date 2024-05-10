using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Admin.Entities.Configs
{
    public class SiteSettings
    {
        public SqlConfiguration SqlConfiguration { get; set; }
        public LogConfiguration LogConfiguration { get; set; }
    }
}
