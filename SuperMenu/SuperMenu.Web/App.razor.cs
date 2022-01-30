using Avalonia.ReactiveUI;
using Avalonia.Web.Blazor;

namespace SuperMenu.Web;

public partial class App
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        WebAppBuilder.Configure<SuperMenu.App>()
            .UseReactiveUI()
            .SetupWithSingleViewLifetime();
    }
}