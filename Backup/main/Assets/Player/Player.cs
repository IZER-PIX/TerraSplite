using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : Entity
{
    #region singleton
    private static Player instance = null;
    public static Player singleton {
        get {
            if(instance == null) instance = new Player();
            return instance;
        }
    }
    #endregion
}