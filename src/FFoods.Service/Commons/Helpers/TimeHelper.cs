using FFoods.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFoods.Service.Commons.Helpers
{
    public class TimeHelper
    {
        public static DateTime GetCurrentServerTime()
        {
            var date = DateTime.UtcNow;
            return date.AddHours(TimeConstant.UTC);
        }
    }
}
