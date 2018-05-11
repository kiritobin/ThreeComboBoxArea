using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.DAL
{
    class AreaDAL
    {
        SQLHelper sqlHelp = new SQLHelper();
        public ArrayList LoadProvinceData()
        {
            ArrayList list = new ArrayList();
            SqlDataReader dr = sqlHelp.ExecuteSqlReader("select AreaId,AreaName from T_Province where AreaPid=0");
            while (dr.Read())
            {
                int id = dr.GetInt32(0);
                string name = dr.GetString(1);
                Area area = new Area(id, name);
                list.Add(area);
            }
            dr.Close();
            return list;
        }

        public ArrayList LoadCityData(int id)
        {
            ArrayList list = new ArrayList();
            SqlDataReader dr = sqlHelp.ExecuteSqlReader("select CityId,CityName from T_City where AreaId=@id",
                new SqlParameter("@id", id));
            while (dr.Read())
            {
                id = dr.GetInt32(0);
                string name = dr.GetString(1);
                Area area = new Area(id, name);
                list.Add(area);
            }
            dr.Close();
            return list;
        }

        public ArrayList LoadCountyData(int id)
        {
            ArrayList list = new ArrayList();
            SqlDataReader dr = sqlHelp.ExecuteSqlReader("select CountyId,CountyName from T_Area where CityId=@id",
                new SqlParameter("@id", id));
            while (dr.Read())
            {
                id = dr.GetInt32(0);
                string name = dr.GetString(1);
                Area area = new Area(id, name);
                list.Add(area);
            }
            dr.Close();
            return list;
        }
    }
}
