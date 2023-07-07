using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Interface
{
    public string prompt { get; }

    public bool Interact(Interaction interactor, out bool succesful);
}
