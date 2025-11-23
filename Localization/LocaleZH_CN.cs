// LocaleZH_CN.cs
// Simplified Chinese zh-HANS City Services Rebalance.

namespace RealCity
{
    using System.Collections.Generic;
    using Colossal;

    public class LocaleZH_CN : IDictionarySource
    {
        private readonly Setting m_Setting;

        public LocaleZH_CN(Setting setting)
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
                { m_Setting.GetOptionTabLocaleID(Setting.kSection), "主选项" },

                // Groups
                { m_Setting.GetOptionGroupLocaleID(Setting.kToggleGroup), "选项" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kButtonGroup), "操作" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kConfigUsageGroup), "如何使用 Config.xml" },

                // Logging (strong warning about performance)
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.Logging)),
                    "详细日志（高级）"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.Logging)),
                    "向日志文件写入大量额外的诊断信息。\n" +
                    "<不推荐在正常游玩时开启。>\n" +
                    "过多的日志会降低游戏性能，并生成非常大的日志文件。\n" +
                    "只在排查问题或收集调试日志时暂时开启。"
                },

                // UseLocalConfig
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.UseLocalConfig)),
                    "使用本地配置"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.UseLocalConfig)),
                    "使用本地的 Config.xml 覆盖，而不是模组自带的默认配置。" +
                    "适用于希望为不同存档或不同电脑使用不同服务设置的高级玩家。"
                },

                // OpenConfigFile button (folder)
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.OpenConfigFile)),
                    "打开配置文件夹"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.OpenConfigFile)),
                    "- 打开包含 Config.xml 的 <ModsData/RealCity/> 文件夹。\n " +
                    "- 使用你喜欢的文本编辑器编辑它（例如：<Notepad++>）\n\n " +
                    "- 示例路径（Windows）：\n" +
                    "C:/Users/YourName/AppData/LocalLow/Colossal Order/Cities Skylines II/ModsData/RealCity/Config.xml"
                },

                // ApplyConfiguration button
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.ApplyConfiguration)),
                    "立即应用配置"
                },
                {
                    m_Setting.GetOptionDescLocaleID(nameof(Setting.ApplyConfiguration)),
                    "读取 Config.xml，并将新数值应用到城市服务预制体（工作岗位、处理率等）。"
                },
                {
                    m_Setting.GetOptionWarningLocaleID(nameof(Setting.ApplyConfiguration)),
                    "这会将新的配置应用到许多城市服务建筑。确定要继续吗？"
                },

                // ConfigUsageSteps: multi-line usage instructions
                {
                    m_Setting.GetOptionLabelLocaleID(nameof(Setting.ConfigUsageSteps)),
                    "1. 点击 <[Open Config folder]>。\n" +
                    "2. 在该文件夹中用你喜欢的文本编辑器打开并编辑 <Config.xml>。\n" +
                    "3. 保存文件，然后点击 <[Apply configuration now]>。\n" +
                    "4. <加载城市>（或重新加载）以查看生效的更改。"
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
