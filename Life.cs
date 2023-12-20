using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    /// <summary>
    /// 生き物
    /// </summary>
    class Life:Thing//命
    {
        
        readonly private string _name;
        readonly private DateTime _birthDay = new DateTime();
        public int lifespan;

        public DateTime birthday
        {
            get { return _birthDay; }
        }
        new public string name
        {
            get { return _name; }
        }
        public Life(DateTime bd, string n, float w = 0, float h = 0, float d = 0, float we = 0, int l = 0 )
            :base(n,w,h,d,we)
        {
            _name = n;
            this._birthDay = bd;
            lifespan = l;
        }
        public int Age()
        {
            int age =DateTime.Now.Year-_birthDay.Year;
            return age;
        }
        public bool Birthday()
        {
            if (_birthDay.Date == DateTime.Today)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
