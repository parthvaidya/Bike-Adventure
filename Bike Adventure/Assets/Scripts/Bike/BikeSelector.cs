using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeSelector : MonoBehaviour
{
    public BikeData bikeData;

    public void SelectBike()
    {
        //ServiceLocator.Get<BikeManager>().SetSelectedBike(bikeData);
    }
}
