namespace $safeprojectname$
{
    public abstract class Singleton<T> where T : class, new()
    {
        private static T _instance;
        public static T Instance
        {
            get => _instance ?? (_instance = new T());

            set => _instance = value;
        }
    }
}