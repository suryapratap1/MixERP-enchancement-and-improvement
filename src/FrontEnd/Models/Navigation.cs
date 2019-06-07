using System;
using System.Collections.Generic;
using System.Linq;
using MixERP.Net.Entities.Core;
using PetaPoco;

namespace MixERP.Net.FrontEnd.Models
{
    [Serializable]
    public class Navigation
    {
        private Menu[] _menus;

        public Navigation(string catalog, int userId, int officeId, string culture)
        {
            this.Catalog = catalog;
            this.UserId = userId;
            this.OfficeId = officeId;
            this.Culture = culture;
        }

        public string Catalog { get; private set; }
        public int UserId { get; private set; }
        public int OfficeId { get; private set; }
        public string Culture { get; private set; }

        public List<NavigationMenu> GetMenus()
        {
            this._menus = GetMenuCollection(this.Catalog, this.OfficeId, this.UserId, this.Culture).ToArray();

            List<NavigationMenu> navs = this._menus.Where(x => x.ParentMenuId == null).Select(menu => new NavigationMenu
            {
                Menu = menu
            }).ToList();


            if (navs.Count <= 0)
            {
                return navs;
            }

            foreach (NavigationMenu nav in navs)
            {
                nav.Children = this.GetChildren(nav);
            }

            return navs;
        }

        private List<NavigationMenu> GetChildren(NavigationMenu nav)
        {
            List<NavigationMenu> children = new List<NavigationMenu>();
            int menuId = nav.Menu.MenuId;

            if (menuId.Equals(0))
            {
                return children;
            }

            children.AddRange(this._menus.Where(m => m.ParentMenuId.Equals(menuId)).ToList().Select(menu => new NavigationMenu
                {
                    Menu = menu
                }));

            if (children.Count <= 0)
            {
                return children;
            }

            foreach (NavigationMenu t in children)
            {
                t.Children = this.GetChildren(t);
            }
            return children;
        }

        public static IEnumerable<Menu> GetMenuCollection(string catalog, int officeId, int userId, string culture)
        {
            return Factory.Get<Menu>(catalog, "SELECT * FROM policy.get_menu(@0, @1, @2) ORDER BY menu_id;", userId,
                officeId,
                culture);
        }
    }
}