using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace WebMES.Utils.Cache
{
    public class ExpireTimeConfigClass
    {

        private static ExpireTimeConfigClass instance = null;
        private static object _lock = new object();
        static FileSystemWatcher watcher = new FileSystemWatcher();
        XmlDocument doc = null;
        public static ExpireTimeConfigClass Instance
        {

            get
            {
                if (instance != null) return instance;
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new ExpireTimeConfigClass();
                        WatcherStrat(Environment.CurrentDirectory);
                    }

                }
                return instance;
            }

        }

        private  void ClearAll()
        {
            lock (_lock)
            {
                exclueQueryNos = null;
                doc = null;
            }

        }

        private static void WatcherStrat(string StrWarcherPath)
        {
            //初始化监听
            watcher.BeginInit();
            //设置监听文件类型
            watcher.Filter = "CacheExpireTimeConfig.xml";
            //设置是否监听子目录
            watcher.IncludeSubdirectories = false;
            //设置是否启用监听?
            watcher.EnableRaisingEvents = true;
            //设置需要监听的更改类型(如:文件或者文件夹的属性,文件或者文件夹的创建时间;NotifyFilters枚举的内容)
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime  | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Security | NotifyFilters.Size;
            //设置监听的路径
            watcher.Path = StrWarcherPath;
            //注册创建文件或目录时的监听事件
            //watcher.Created += new FileSystemEventHandler(watch_created);
            //注册当指定目录的文件或者目录发生改变的时候的监听事件
            watcher.Changed += watcher_Changed;
            //结束初始化
            watcher.EndInit();
        }

        static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            instance.ClearAll();
        }

        List<ExpireConfig> exclueQueryNos = null;
        public List<ExpireConfig> GetExpConfigQueryNos
        {

            get
            {
                if (exclueQueryNos != null) return exclueQueryNos;
                lock (_lock)
                {
                    if (exclueQueryNos != null) return exclueQueryNos;
                    XmlNode nd = GetNode("//ExpireTime[@name='queryNo']");
                    if (nd == null)
                    {
                        exclueQueryNos = new List<ExpireConfig>();
                        return exclueQueryNos;
                    }
                    List<ExpireConfig> lst = new List<ExpireConfig>();
                    XmlNodeList serverNodes = ((XmlElement)nd).GetElementsByTagName("Item");
                    foreach (XmlNode node in serverNodes)
                    {
                        int expTime=0;
                        int.TryParse(node.InnerText, out expTime);
                        lst.Add(new ExpireConfig { ConName = ((XmlElement)node).GetAttribute("no"), ExpireTime = expTime });
                    }
                    exclueQueryNos = lst;
                }
                return exclueQueryNos;
            }
        }

        private XmlNode GetNode(string nodeName)
        {
            try
            {
                if (doc == null)
                {
                    doc = new XmlDocument();
                    var mappedPath = Environment.CurrentDirectory;
                    doc.Load(Path.Combine(mappedPath, "CacheExpireTimeConfig.xml"));
                }
                XmlElement rootElem = doc.DocumentElement;
                if (rootElem == null) return null;
                return rootElem.SelectSingleNode(nodeName);
            }
            catch (Exception ex)
            {
                LogHelper.Error(ex);
            }
            return null;
        }
    }
}
