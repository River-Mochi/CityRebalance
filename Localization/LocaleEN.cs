// LocaleEN.cs
// English locale strings for City Services Redux.

namespace RealCity
{
    using System.Collections.Generic;
    using Colossal;

    public class LocaleEN : IDictionarySource
    {
        private readonly Setting m_Setting;

        public LocaleEN(Setting setting)
        {
            m_Setting = setting;
        }

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(
            IList<IDictionaryEntryError> errors,
            Dictionary<string, int> indexCounts)
        {
            string title = Mod.ModName;

            // Show "City Services Redux 0.5.0" in the tab header.
            if (!string.IsNullOrEmpty(Mod.ModVersion))
            {
                title = title + " " + Mod.ModVersion;
            }

            return new Dictionary<string, string>
            {
                // Tab titles
                { m_Setting.GetSettingsLocaleID(), title },
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "Actions" },
                { m_Setting.GetOptionTabLocaleID(Setting.kDebugSection), "Debug" },

                // Groups
                { m_Setting.GetOptionGroupLocaleID(Setting.kToggleGroup), "Options" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kButtonGroup), "Actions" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kConfigUsageGroup), "How to use Config.xml" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kInfoGroup), "Info" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kDebugGroup), "DEBUG" },

                // Debug tab: Info group
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.NameDisplay)),
                    "Mod"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.NameDisplay)),
                    "Display name of this mod."
                },
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.VersionDisplay)),
                    "Version"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.VersionDisplay)),
                    "Current version number."
                },

                // -----------------------------
                // Actions tab: Options toggles
                // -----------------------------

                // UseModPresets
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.UseModPresets)),
                    "Use mod presets (recommended)"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.UseModPresets)),
                    "- Uses the **Config.xml** that ships with this mod (mod presets).\n" +
                    "- Ignores any local custom file in ModsData/RealCity.\n" +
                    "- Recommended for most players."
                },

                // UseLocalConfig
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.UseLocalConfig)),
                    "Use local custom Config.xml"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.UseLocalConfig)),
                    "- When enabled, uses your local **ModsData/RealCity/Config.xml** instead of the built-in presets.\n" +
                    "- This is for advanced users who want different service settings per save or per machine.\n\n" +
                    "TIPS\n" +
                    "- Start by copying the shipped Config.xml and then tweak worker counts or other fields.\n" +
                    "- Never set workplaces to **0**; use small positive values if you need very low staffing.\n" +
                    "- Use the buttons below to open the folder, apply changes, or restore a fresh copy."
                },

                // -----------------------------
                // Actions tab: Buttons (local custom only)
                // -----------------------------

                // OpenConfigFile button (now: folder)
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenConfigFile)),
                    "Open Config folder"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenConfigFile)),
                    "- Only use this if you plan on changing the default increases already set by the mod.\n" +
                    "- Opens <ModsData/RealCity/> folder that contains **Config.xml**.\n" +
                    "- Edit this with your preferred text editor (i.e., <Notepad++>).\n\n" +
                    "- Example path (Windows):\n" +
                    "C:/Users/YourName/AppData/LocalLow/Colossal Order/Cities Skylines II/ModsData/RealCity/Config.xml"
                },

                // ApplyConfiguration button
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.ApplyConfiguration)),
                    "Apply/update configuration now"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.ApplyConfiguration)),
                    "Reads your local ModsData/RealCity/Config.xml and applies the new values to city-service prefabs (buildings) " +
                    "(workplaces, processing rates, etc.).\n\n" +
                    "- This applies to **new buildings** and not existing ones.\n" +
                    "- Best to have this set up before making a new city.\n" +
                    "- For existing cities, delete the old building, make a new building, and you will see the changes.\n" +
                    "- If you are happy with the settings, you can just start the game.\n" +
                    "    - Only need to click **Apply/update configuration now** whenever you update Config.xml again."
                },
                {
                    m_Setting.GetOptionWarningLocaleID(nameof(Setting.ApplyConfiguration)),
                    "This will apply a new configuration to many city-service buildings. Are you sure?"
                },

                // ResetLocalConfig (Actions tab)
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetLocalConfig)),
                    "Restore fresh Config.xml"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetLocalConfig)),
                    "Overwrite the local **ModsData/RealCity/Config.xml** with a fresh copy of the original mod presets.\n" +
                    "Use this if your custom file becomes corrupted or you just want to start over."
                },
                {
                    m_Setting.GetOptionWarningLocaleID(nameof(Setting.ResetLocalConfig)),
                    "Overwrite ModsData/RealCity/Config.xml with the original presets from the mod?\n\n" +
                    "Any custom changes will be lost."
                },

                // -----------------------------
                // Actions tab: How to use Config.xml
                // -----------------------------

                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.ConfigUsageSteps)),
                    "1. Choose a mode in **Options**:\n" +
                    "   - [Use mod presets (recommended)] for the built-in Config.xml.\n" +
                    "   - [Use local custom Config.xml] if you want to edit your own copy.\n\n" +
                    "2. If using a local custom file, click <[Open Config folder]>.\n" +
                    "3. Open and edit <Config.xml> in that folder with your preferred text editor.\n" +
                    "4. Save the file, then click <[Apply/update configuration now]>.\n" +
                    "5. <Load a city> (or reload) to see changes applied."
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.ConfigUsageSteps)),
                    " "
                },

                // -----------------------------
                // Debug tab: logging + reset
                // -----------------------------

                // Logging (strong warning about performance)
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.Logging)),
                    "Verbose logging (advanced)"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.Logging)),
                    "Writes a lot of extra diagnostic information to the log file.\n" +
                    "<NOT recommended for normal gameplay.>\n" +
                    "Excessive logging can slow down the game and create very large log files.\n" +
                    "Turn this on only temporarily when you are troubleshooting or collecting a debug log."
                },

                // Debug tab duplicate reset button
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.ResetLocalConfigDebug)),
                    "Restore fresh Config.xml"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.ResetLocalConfigDebug)),
                    "Same as the Actions tab button: overwrite the local ModsData/RealCity/Config.xml with a fresh copy of " +
                    "the original mod presets. Use this if your custom file is broken."
                },
                {
                    m_Setting.GetOptionWarningLocaleID(nameof(Setting.ResetLocalConfigDebug)),
                    "Overwrite ModsData/RealCity/Config.xml with the original presets from the mod?\n\n" +
                    "Any custom changes will be lost."
                },
            };
        }

        public void Unload()
        {
        }
    }
}
