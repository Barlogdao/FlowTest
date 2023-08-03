using System;


public static class SignalBus
{
    public static event Action CylinderClicked;
    public static event Action SphereDestroyed;



    public static void InvokeClickCylinder()
    {
        CylinderClicked?.Invoke();
    }
    public static void InvokeDestroySphere()
    {
        SphereDestroyed?.Invoke();
    }


}
