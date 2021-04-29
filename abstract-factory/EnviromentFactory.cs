namespace AbstractFactory
{
    public abstract class EnviromentFactory
    {
        public abstract ILogger GetLogger();
        public abstract IGui GetGui();

        public static EnviromentFactory GetFactory(string env)
        {
            if (env == "desktop")
                return new DesktopEnviromentFactory();
            else if (env == "android")
                return new AndroidEnviromentFactory();

            throw new System.Exception();
        }
    }

    public class DesktopEnviromentFactory : EnviromentFactory
    {
        public override IGui GetGui()
        {
            return new DesktopGui();
        }

        public override ILogger GetLogger()
        {
            return new ConsoleLogger();
        }
    }

    public class AndroidEnviromentFactory : EnviromentFactory
    {
        public override IGui GetGui()
        {
            return new AndroidGui();
        }

        public override ILogger GetLogger()
        {
            return new CloudLogger();
        }
    }
}