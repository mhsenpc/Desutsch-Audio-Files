using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desutsch_Audio_Files.Data
{
    public class DeviceId
    {
        public string ID { 
            get {
                string id = Preferences.Get("device_id","");
                if(id == "")
                {
                    string newId = RandomString(20);
                    this.ID = newId;
                    return newId;
                }
                return id;
            }

            set {
                Preferences.Set("device_id", value);
            } 
        }

        protected void GenerateDeviceId()
        {

        }

        protected string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
