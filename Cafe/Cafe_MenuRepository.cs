using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class MenuRepository
    {
        private List<Menu> _menuDirectory = new List<Menu>();
        
        //create

        public bool AddMenuItem(Menu item)
        {
            int initial = _menuDirectory.Count;

            _menuDirectory.Add(item);

            bool added = _menuDirectory.Count > initial;
            return added;
             
        }

        // read
        public List<Menu> GetMenu()
        {
            return _menuDirectory;
        }

        public Menu GetMenuByItem(int mealId)
        {
            foreach(Menu item in _menuDirectory)
            {
                if (item.MealNumber == mealId)
                {
                    return item;
                }
            }
            return null;

        }
        public bool IfItemInMenu(int mealId)
        {
            foreach (Menu item in _menuDirectory)
            {
                if (item.MealNumber == mealId)
                {
                    return true;
                }
            }
            return false;
        }

        // We don't need to be able to update items right now.

        // delete
        public bool DeleteItem(int itemToDelete)
        {
            return _menuDirectory.Remove(GetMenuByItem(itemToDelete));
        }

    }
}
