using System;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    private Player @Player;

    private void Awake() {
        @Player = GetComponent<Player>();
        PlayerEventManager.OnHeal.AddListener(Heal); 
    }
    private void Heal(int healBoost) => @Player.Health += healBoost;

}