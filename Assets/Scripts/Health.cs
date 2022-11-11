using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehavior
{
	public float StartingHealth = 100f;

	public float HealthPoints
    {
		get { return newHealthPoints; }
        set
        {
            newHealthPoints = Mathf.Clamp(value, 0f, 100f);

            if(newHealthPoints <= 0f)
            {

            }
        }
    }

	private float newHealthPoints = 100f;
}