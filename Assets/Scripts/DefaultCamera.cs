using System.Runtime.InteropServices;
using UnityEngine;

public class DefaultCamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   void transformCam()
    {
        
        float defaultX = (float)-1.871147;
        float defaultY = (float) 3.048481;
        float defaultZ = (float)-3.629064;

        float posX = (float)1.925;
        float posY = (float)-179.04;
        float posZ = 0;

        transform.position = new Vector3(defaultX,defaultY,defaultZ);
        transform.eulerAngles = new Vector3(posX, posY, posZ);

    }

}
