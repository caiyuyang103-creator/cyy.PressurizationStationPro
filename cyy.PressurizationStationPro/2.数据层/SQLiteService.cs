using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cyy.PressurizationStationPro
{
    public class SQLiteService
    {


        /// <summary>
        /// 设置连接字符串
        /// </summary>
        /// <param name="connectStr"></param>
        public void SetConnectStr(string connectStr)
        { 

            SQLiteHelper.ConnString=connectStr;

        }

    }
}
