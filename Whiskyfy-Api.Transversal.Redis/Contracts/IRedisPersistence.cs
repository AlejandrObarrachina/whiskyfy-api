using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whiskyfy_Api.Transversal.Redis.Contracts
{
    public interface IRedisPersistence
    {
        string GetData(string typeOfData);
        void SaveData(string typeOfData, string jsonToSave);
    }
}
