using System;

public class EventBrocker
{
    public static event Action ProjectileOutOfBounds;

    public static void CallProjectileOutOfBounds()
    {
        if(ProjectileOutOfBounds != null)
            ProjectileOutOfBounds();
    }
}
