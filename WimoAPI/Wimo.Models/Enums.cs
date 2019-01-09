using System;
using System.Collections.Generic;
using System.Text;

namespace Wimo.Models
{
    public static class Enums
    {
        public enum SortingType
        {
            None = 0,
            ByStatus,
            ByDate
        }

        public enum Status
        {
            pending = 1,
            started,
            completed,
            failed
        }
    }
}
