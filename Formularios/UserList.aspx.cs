using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Formularios.Models;
using System.Web.ModelBinding;

namespace Formularios
{
    public partial class UserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public IQueryable<User> GetUsers([QueryString("id")] int? cityId)
        {
            var _db = new Formularios.Models.UserContext();
            IQueryable<User> query = _db.Users;
            return query;
        }
    }
}