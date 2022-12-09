 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

 public class BattleInfo : MonoBehaviour
 {
     public Text name; //name of player or insectosaur
     public Slider health; //health bar 

     public void setHUD(Units unit) 
     {
          name.text = unit.unitsName; //unit name in text box
          health.maxValue = unit.maxHealth; //max health for player
          health.value = unit.currHealth; //current health for player
     }

     //sets health
     public void setHealth(int hp)
     {
         health.value = hp;
     }
 }
