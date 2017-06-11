﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaghetti : Food
{
    public override float Acceleration { get; set; }
    public override float Damage { get; set; }


    protected override void Awake()
    {
        base.Awake();
        Acceleration = 800;
        Damage = 80;
    }

}