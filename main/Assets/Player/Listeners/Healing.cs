using System;
using System.Collections.Generic;
using UnityEngine;

public class Healing : MonoBehaviour
{
    [SerializeField] private Player @Player;

    private void Awake() {
        PlayerEventManager.OnHeal.AddListener(Heal); 
    }
    private void Heal(int healBoost) => @Player.Health += healBoost;

}