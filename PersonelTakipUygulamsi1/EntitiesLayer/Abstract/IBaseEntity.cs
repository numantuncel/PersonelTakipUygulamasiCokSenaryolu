using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipUygulamsi1.EntitiesLayer.Abstract
{
    public interface IBaseEntity
    {
        int Id { get; set; }
    }
}
/*interface içindeki proplar da erişim belirteci olmaz*/
