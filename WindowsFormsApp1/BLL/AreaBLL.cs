using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    class AreaBLL
    {
        AreaDAL areaDAL = new AreaDAL();
        public ArrayList LoadProvinceData()
        {
            return areaDAL.LoadProvinceData();
        }

        public ArrayList LoadCityData(int id)
        {
            return areaDAL.LoadCityData(id);
        }

        public ArrayList LoadCountyData(int id)
        {
            return areaDAL.LoadCountyData(id);
        }
    }
}
