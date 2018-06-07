using FinalProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Repositories
{
    public class UnitOfWork
    {
        private FinalProjectDbContext context;

        private ManafacturerRepository manafacturerRepository;
        private ShopRepository shopRepository;
        private UserRepository userRepository;
        private WeaponRepository weaponRepository;
        private CategoryRepository categoryRepository;

        public UnitOfWork(FinalProjectDbContext context)
        {
            this.context = context;
        }

        public WeaponRepository WeaponRepository
        {
            get
            {
                if (weaponRepository == null)
                {
                    return new WeaponRepository();
                }
                return weaponRepository;
            }
        }

        public ManafacturerRepository ManafacturerRepository
        {
            get
            {
                if (manafacturerRepository == null)
                {
                    return new ManafacturerRepository();
                }
                return manafacturerRepository;
            }
        }

        public UserRepository UserRepository
        {
            get
            {
                if (userRepository == null)
                {
                    return new UserRepository();
                }
                return userRepository;
            }
        }

        public ShopRepository ShopRepository
        {
            get
            {
                if (shopRepository == null)
                {
                    return new ShopRepository();
                }
                return shopRepository;
            }
        }

        public CategoryRepository CategoryRepository
        {
            get
            {
                if (categoryRepository == null)
                {
                    return new CategoryRepository();
                }
                return categoryRepository;
            }
        }





    }
}
