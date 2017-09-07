﻿using Assets.Weapons.Guns;
using UnityEngine;

namespace Weapons.Guns.MachineGun
{
    public class MachineGun : Firearm
    {
        protected override void Shoot()
        {
            timer = 0f;
            var machineGunData = weaponData as MachineGunData;
            if (machineGunData && !ammunition.IsMagazineEmpty())
            {
                var newBullet = Instantiate(ammunition.AmmunitionData.BulletData.BulletPrefab, transform.position, Quaternion.identity);
                var bulletRigidboy = newBullet.GetComponent<Rigidbody>();
                var bulletComponent = newBullet.GetComponent<Bullet>();

                if (autoTarget.SpottedEnemy)
                {
                    var tmp = autoTarget.SpottedEnemy.transform.position - transform.position;
                    bulletRigidboy.velocity = tmp.normalized * bulletComponent.BulletData.Velocity;
                }
                else
                {
                    bulletRigidboy.velocity = transform.forward * bulletComponent.BulletData.Velocity;
                }
                ammunition.RemoveBulletFromMagazine();
            }
        }
    }
}