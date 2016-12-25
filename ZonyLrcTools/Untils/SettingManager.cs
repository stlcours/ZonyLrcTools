﻿using System;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using System.Collections.Generic;
using ZonyLrcTools.Plugin;

namespace ZonyLrcTools.Untils
{
    /// <summary>
    /// 设置管理器
    /// </summary>
    public static class SettingManager
    {
        public static SetValue SetValue { get; set; }

        private static FileStream m_confFile;
        private static string m_confFilePath = Environment.CurrentDirectory + @"\set.conf";

        /// <summary>
        /// 保存设置
        /// </summary>
        public static bool Save()
        {
            try
            {
                string _ser = JsonConvert.SerializeObject(SetValue);
                byte[] _data = Encoding.UTF8.GetBytes(_ser);

                using (m_confFile = new FileStream(m_confFilePath, FileMode.OpenOrCreate))
                {
                    m_confFile.SetLength(0);
                    m_confFile.Write(_data, 0, _data.Length);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 从文件当中加载设置
        /// </summary>
        public static bool Load()
        {
            try
            {
            	if(!File.Exists(m_confFilePath))
                {
                    defaultSetting();
                    return true;
                }

                using (m_confFile = new FileStream(m_confFilePath, FileMode.OpenOrCreate))
                {
                    using (StreamReader _sr = new StreamReader(m_confFile))
                    {
                        string _json = _sr.ReadToEnd();
                        SetValue = JsonConvert.DeserializeObject<SetValue>(_json);
                        return true;
                    }
                }
            }catch
            {
                return false;
            }
        }

        /// <summary>
        /// 加载默认设定
        /// </summary>
        private static void defaultSetting()
        {
            if (SetValue == null) SetValue = new SetValue();
            SetValue.DownloadThreadNum = 4;
            SetValue.FileSuffixs = "*.acc;*.mp3;*.ape;*.flac";
            SetValue.IsIgnoreExitsFile = true;
            SetValue.EncodingName = "utf-8";
            SetValue.UserDirectory = string.Empty;
            SetValue.IsCheckUpdate = true;
            SetValue.IsAgree = false;
            SetValue.PluginsStatus = new List<PluginStatusModel>();
            SetValue.IsDownTranslate = true;
            // 加载所有默认开启的插件
            loadPluginStatus(GlobalMember.LrcPluginsManager);
            loadPluginStatus(GlobalMember.MusicTagPluginsManager);
        }

        /// <summary>
        /// 加载默认插件设置
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="pluginsMgr"></param>
        private static void loadPluginStatus<T>(BasePlugins<T> pluginsMgr)
        {
            foreach (var item in pluginsMgr.PluginInfos)
            {
                SetValue.PluginsStatus.Add(new PluginStatusModel()
                {
                    IsOpen = true,
                    PluginName = item.PlugName
                });
            }
        }
    }

    #region > 设置存储模型 <
    /// <summary>
    /// 设置存储模型
    /// </summary>
    public class SetValue
    {
        /// <summary>
        /// 编码方式
        /// </summary>
        public string EncodingName { get; set; }
        /// <summary>
        /// 下载线程数目
        /// </summary>
        public int DownloadThreadNum { get; set; }
        /// <summary>
        /// 是否忽略已存在的文件
        /// </summary>
        public bool IsIgnoreExitsFile { get; set; }
        /// <summary>
        /// 用户自定义目录
        /// </summary>
        public string UserDirectory { get; set; }
        /// <summary>
        /// 要扫描的文件后缀名
        /// </summary>
        public string FileSuffixs { get; set; }
        /// <summary>
        /// 是否自动检测更新
        /// </summary>
        public bool IsCheckUpdate { get; set; }
        /// <summary>
        /// 是否同意用户协议
        /// </summary>
        public bool IsAgree { get; set; }
        /// <summary>
        /// 插件状态模型
        /// </summary>
        public List<PluginStatusModel> PluginsStatus { get; set; }
        /// <summary>
        /// 是否下载翻译歌词
        /// </summary>
        public bool IsDownTranslate { get; set; }
    }
    
    /// <summary>
    /// 插件状态模型
    /// </summary>
    public class PluginStatusModel
    {
        public bool IsOpen { get; set; }
        public string PluginName { get; set; }
    }
    #endregion
}
