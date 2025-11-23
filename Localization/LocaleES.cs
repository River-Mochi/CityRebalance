// LocaleES.cs
// Spanish es-ES City Services Rebalance.

namespace RealCity
{
    using System.Collections.Generic;
    using Colossal;

    public class LocaleES : IDictionarySource
    {
        private readonly Setting m_Setting;

        public LocaleES(Setting setting)
        {
            m_Setting = setting;
        }

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(
            IList<IDictionaryEntryError> errors,
            Dictionary<string, int> indexCounts)
        {
            var title = "City Services Rebalance";

            // Use assembly version, do not depend on modAsset being non-null.
            if (!string.IsNullOrEmpty(Mod.ModVersion))
            {
                title = title + " " + Mod.ModVersion;
            }

            return new Dictionary<string, string>
            {
                // Tab title
                { m_Setting.GetSettingsLocaleID(), title },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "Principal" },

                // Groups
                { m_Setting.GetOptionGroupLocaleID(Setting.kToggleGroup), "Opciones" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kButtonGroup), "Acciones" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kConfigUsageGroup), "Cómo usar Config.xml" },

                // Logging (strong warning about performance)
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.Logging)),
                    "Registro detallado (avanzado)"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.Logging)),
                    "Escribe mucha información de diagnóstico adicional en el archivo de registro.\n" +
                    "<NO se recomienda para el juego normal.>\n" +
                    "Un registro excesivo puede ralentizar el juego y crear archivos de registro muy grandes.\n" +
                    "Actívalo solo de forma temporal cuando estés solucionando problemas o recopilando un registro de depuración."
                },

                // UseLocalConfig
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.UseLocalConfig)),
                    "Usar configuración local"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.UseLocalConfig)),
                    "Usa un Config.xml local en lugar de la configuración predeterminada incluida con el mod. " +
                    "Pensado para usuarios avanzados que quieren distintos ajustes de servicios por partida o por equipo."
                },

                // OpenConfigFile button (folder)
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenConfigFile)),
                    "Abrir carpeta de Config"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenConfigFile)),
                    "- Abre la carpeta <ModsData/RealCity/> que contiene Config.xml.\n " +
                    "- Edítalo con tu editor de texto preferido (por ejemplo, <Notepad++>)\n\n " +
                    "- Ruta de ejemplo (Windows):\n" +
                    "C:/Users/YourName/AppData/LocalLow/Colossal Order/Cities Skylines II/ModsData/RealCity/Config.xml"
                },

                // ApplyConfiguration button
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.ApplyConfiguration)),
                    "Aplicar configuración ahora"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.ApplyConfiguration)),
                    "Lee Config.xml y aplica los nuevos valores a los prefabs de servicios de la ciudad " +
                    "(puestos de trabajo, tasas de procesamiento, etc.)."
                },
                {
                    m_Setting.GetOptionWarningLocaleID(nameof(Setting.ApplyConfiguration)),
                    "Esto aplicará una nueva configuración a muchos edificios de servicios de la ciudad. ¿Estás seguro?"
                },

                // ConfigUsageSteps: multi-line usage instructions
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.ConfigUsageSteps)),
                    "1. Haz clic en <[Open Config folder]>.\n" +
                    "2. Abre y edita <Config.xml> en esa carpeta con tu editor de texto preferido.\n" +
                    "3. Guarda el archivo y luego haz clic en <[Apply configuration now]>.\n" +
                    "4. <Carga una ciudad> (o recárgala) para ver los cambios aplicados."
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.ConfigUsageSteps)),
                    " "
                },
            };
        }

        public void Unload()
        {
        }
    }
}
