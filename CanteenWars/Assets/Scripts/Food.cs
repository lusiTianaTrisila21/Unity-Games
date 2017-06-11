﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Food : MonoBehaviour
{
    public abstract float Acceleration { get; set; }
    public abstract float Damage { get; set; }
    private Rigidbody2D _rigidbody;


	protected virtual void Awake ()
	{
	    _rigidbody = GetComponent<Rigidbody2D>();
	}
	
    public void Throw(Vector3 transformEulerAngles, Vector3 transformLocalScale)
    {
        var angle = transformEulerAngles.z * Mathf.Deg2Rad;
        var direction = new Vector3(-Mathf.Sin(angle), Mathf.Cos(angle), 0f).normalized;
        
        _rigidbody.AddForce(direction * transformLocalScale.y * Acceleration);
    }

    public void MakeStaticFood()
    {
        _rigidbody.bodyType = RigidbodyType2D.Kinematic;
    }

    public void MakeDynamicFood()
    {
        _rigidbody.bodyType = RigidbodyType2D.Dynamic;
    }

    // Used in FoodController as animation event
    private void DestroyFood()
    {
        Destroy(gameObject);
    }
}