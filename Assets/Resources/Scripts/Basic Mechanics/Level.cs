using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public int currentLvl = 0;
    protected int lvlCap;
    public void lvlUp()
    {
        if (currentLvl < lvlCap)
        {
            currentLvl++;
            lvlUpEffect();
        }
    }

    virtual public void lvlUpEffect() {   }
}
