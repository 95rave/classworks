using System;
using System.Collections.Generic;
using System.Text;

namespace Classwork06
{
    public class Gun
    {
        public string TypeGun;
        public byte TotalBulletSize;
        public byte Magazinesize;
        public byte BulletLeft;

        

        public Gun(string typeGun, byte bulletSize, byte magazinSize)
        {
            TypeGun = typeGun;
            TotalBulletSize = bulletSize;
            Magazinesize = magazinSize;
            BulletLeft = magazinSize;
        }
        
        public string GetInfo()
        {
            return $"Type Gun: {TypeGun}\nTotal Bullet Size: {TotalBulletSize}\nMagazine Size:{Magazinesize}\nBullet Left:{BulletLeft} ";
        }

        public void Reload()
        {
            int reloaded = Magazinesize - BulletLeft;
            BulletLeft = Magazinesize;
            TotalBulletSize -= (byte)reloaded;
            Console.WriteLine(BulletLeft);

        }

        public void Shoot()
        {
            BulletLeft--;
            TotalBulletSize--;
            Console.WriteLine(BulletLeft);
        }
        
    }
}
