using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Three_tier_architecture_Test.DataAccess;

namespace Three_tier_architecture_Test.BussiRule
{
    public  class UserBll
    {
        public void panduan(object id, Object name) {
            try {
                MyEntity myEntity = new MyEntity
                {
                    Id = Convert.ToInt32(id),
                    Name = Convert.ToString(name)
                };
                new UserDAL().Insert(myEntity);
            }
            catch
            {
                MessageBox.Show("格式不正确！！！");
                return ;
            }            
        }
    }
}
