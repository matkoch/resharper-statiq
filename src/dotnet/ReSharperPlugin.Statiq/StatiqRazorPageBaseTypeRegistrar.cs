using JetBrains.Application;
using JetBrains.Application.Settings;
using JetBrains.Application.Settings.Implementation;
using JetBrains.Metadata.Utils;
using JetBrains.ReSharper.Psi.Razor.Settings;
using JetBrains.Util;

namespace ReSharperPlugin.Statiq
{
    // [ShellComponent]
    // public class StatiqRazorBaseTypesSettings : HaveDefaultSettings
    // {
    //     public StatiqRazorBaseTypesSettings(ILogger logger, ISettingsSchema settingsSchema)
    //         : base(settingsSchema, logger)
    //     {
    //     }
    //
    //     public override string Name => "Statiq Razor Base Types Settings";
    //
    //     public override void InitDefaultSettings(ISettingsStorageMountPoint mountPoint)
    //     {
    //         SetIndexedValue(mountPoint,
    //             RazorBaseTypesSettingsAccessor.Assemblies,
    //             AssemblyNameInfo.Parse("Statiq.Razor"),
    //             new RazorBaseTypesSettings.BaseTypeInfo
    //             {
    //                 { "Statiq.Razor.StatiqRazorPage", default }
    //             });
    //     }
    // }
}