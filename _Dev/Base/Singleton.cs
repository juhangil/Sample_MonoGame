using System;

public class Singleton<T> where T : class
{
    private static volatile T _instance = null;
    public static T Instance
    {
        get
        {
            if(_instance == null)
            {
                lock(_threadLock)
                    _instance = Activator.CreateInstance<T>();
            }

            return _instance;
        }
    }

    private static readonly object _threadLock = new object();
}