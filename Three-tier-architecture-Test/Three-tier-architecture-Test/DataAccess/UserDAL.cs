using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Three_tier_architecture_Test.DataAccess
{
    public class UserDAL
    {
        public void Insert(MyEntity myEntity) {
            using (Model1 model = new Model1())
            {
                model.MyEntities.Add(myEntity);
                model.SaveChanges();
                MessageBox.Show("保存成功！！！" );
            }
        }
        public void CreateDB()
        {
            using (Model1 model = new Model1())
            {
                model.MyEntities.Add(new MyEntity { Id = 1, Name = "zhangsan" });
                model.MyEntities.Add(new MyEntity { Id = 2, Name = "lisi" });
                model.MyEntities.Add(new MyEntity { Id = 3, Name = "wangwu" });
                model.MyEntities.Add(new MyEntity { Id = 4, Name = "zhaoliu" });
                model.SaveChanges();
            }
        }
    }
}
