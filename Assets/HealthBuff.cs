using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PoweupEffect/HealthBuff")]
public class HealthBuff : PoweupEffect
{
    public float amount;
    public override void Apply(GameObject target)
    {
        target.GetComponent<Health>().health.value += amount;
    }
}
