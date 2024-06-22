using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    public void PlayInteractableAnim();
    public void ExecuteInteractableAction(Interactor interactor);
}
