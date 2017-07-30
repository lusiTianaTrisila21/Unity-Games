﻿using UnityEngine;

namespace _Weapons
{
    [CreateAssetMenu(menuName = "RPG/Weapon")]
    public class Weapon : ScriptableObject
    {
        [SerializeField] private GameObject _weaponPrefab;
        [SerializeField] private AnimationClip _attackAnimationClip;

        public Transform gripTransform;

        public GameObject GetWeaponPrefab()
        {
            return _weaponPrefab;
        }

        public AnimationClip GetAttackAnimationClip()
        {
            return _attackAnimationClip;
        }
    }
}
