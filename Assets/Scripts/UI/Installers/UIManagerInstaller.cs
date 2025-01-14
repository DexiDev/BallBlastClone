using VContainer;
using VContainer.Unity;

namespace DexiDev.Game.UI.Installers
{
    public class UIManagerInstaller : IInstaller
    {
        public void Install(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<UIManager>().AsSelf();
        }
    }
}