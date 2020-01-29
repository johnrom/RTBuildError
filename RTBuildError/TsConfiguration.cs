using Reinforced.Typings.Fluent;

namespace RTBuildError
{
    public static class TsConfiguration
    {
        public static void ConfigureReinforcedTypings(ConfigurationBuilder builder)
        {
            builder.Global(config => {
                config.UseModules();
                config.CamelCaseForProperties();
                config.AutoOptionalProperties();
            });
        }
    }
}
