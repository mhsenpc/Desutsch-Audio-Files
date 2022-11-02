using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desutsch_Audio_Files.Data
{
    public class StageService
    {
        public int Count {
            get
            {
                return Preferences.Get("stages", 3);

            }
            set {
                Preferences.Set("stages", value);
            } 
        }
    }
}
