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
                if (WeaponRepository == null)
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
                if (ManafacturerRepository == null)
                {
                    return new ManafacturerRepository();
                }
                return ManafacturerRepository;
            }
        }

        public UserRepository UserRepository
        {
            get
            {
                if (UserRepository == null)
                {
                    return new UserRepository();
                }
                return UserRepository;
            }
        }

        public ShopRepository ShopRepository
        {
            get
            {
                if (ShopRepository == null)
                {
                    return new ShopRepository();
                }
                return ShopRepository;
            }
        }

        public CategoryRepository CategoryRepository
        {
            get
            {
                if (CategoryRepository == null)
                {
                    return new CategoryRepository();
                }
                return CategoryRepository;
            }
        }





    }
}
