using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class Signals
{

    public static UnityEvent<int> onHealthChanged = new UnityEvent<int>();

}
