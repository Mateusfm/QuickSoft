using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;
using Formularios.Models;

namespace Formularios
{
    public partial class UserDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<User> GetUser([QueryString("userID")] int? UserId)
        {
            var _db = new Formularios.Models.UserContext();
            IQueryable<User> query = _db.Users;
            if (UserId.HasValue && UserId > 0)
            {
                query = query.Where(p => p.UserID == UserId);
            }
            else
            {
                query = null;
            }
            return query;
        }
    }
}