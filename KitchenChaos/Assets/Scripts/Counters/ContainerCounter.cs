using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ContainerCounter : BaseCounter
{
    //firing Event
    public event EventHandler OnPlayerGrabbedObject; 

    [SerializeField] private KitchenObjectSO kitchenObjectSO;

    public override void Interact(Player player)
    {
        if (!player.HasKitchenObject())
        {
            //player is not carrying anything
            KitchenObject.SpawnKitchenObject(kitchenObjectSO, player);
            //Firing Event
            OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
        }
    }
    

}
