using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Common;

/***
*	Title：
*	Description：
*/
namespace XMLPlugin
{
    public class XMLMgr
    {
        #region 单例
        static XMLMgr _Instance;
        public static XMLMgr Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new XMLMgr();
                }
                return _Instance;
            }
        }
        #endregion

        public string FilePath = null;

        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="parentName">父节点名称</param>
        /// <param name="NodeName">子节点名称</param>
        /// <param name="lst">属性集合</param>
        public void AddNode(string parentName,string NodeName,List<NodeProp> lst)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(FilePath);//加载xml文件,路径未指定时默认在当前项目环境下
            XmlNode parentNode = xmlDoc.SelectSingleNode("//"+parentName);//取得父亲节点
            if(parentNode==null)
            {
                //添加ParentNode节点
                XmlElement root = xmlDoc.DocumentElement;
                parentNode = xmlDoc.CreateElement(parentName);
                root.AppendChild(parentNode);
            }

            XmlElement childNode = xmlDoc.CreateElement(NodeName);
            parentNode.AppendChild(childNode);
            if (lst != null && lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i].IsEncrypt)
                    {
                        childNode.SetAttribute(lst[i].NodeName, StringSecurity.DESEncrypt(lst[i].NodeValue));
                    }
                    else
                    {
                        childNode.SetAttribute(lst[i].NodeName, lst[i].NodeValue);
                    }
                }
            }
            xmlDoc.Save(FilePath);
        }

        /// <summary>
        /// 删除节点
        /// </summary>
        /// <param name="parentName">父节点名称</param>
        /// <param name="NodeName">子节点名称</param>
        public string DelNode(string parentName,string NodeName)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(FilePath);//加载xml文件,路径未指定时默认在当前项目环境下
            XmlNode parentNode = xmlDoc.SelectSingleNode("//" + parentName);//取得父亲节点
            if (parentNode == null) return "未在该XML文件中找到父节点";
            XmlNode childNode = parentNode.SelectSingleNode("//" + NodeName);
            if (childNode == null) return "未在该XML文件中找到子节点";
            parentNode.RemoveChild(childNode);
            xmlDoc.Save(FilePath);
            return "删除成功";
        }

        /// <summary>
        /// 更新节点
        /// </summary>
        /// <param name="parentName">父节点名称</param>
        /// <param name="NodeName">子节点名称</param>
        public string UpdateNode(string parentName,string NodeName,List<NodeProp> lst)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(FilePath);//加载xml文件,路径未指定时默认在当前项目环境下
            XmlNode parentNode = xmlDoc.SelectSingleNode("//" + parentName);//取得父亲节点
            if (parentNode == null) return "未在该XML文件中找到父节点";
            XmlElement childNode = (XmlElement)parentNode.SelectSingleNode("//" + NodeName);
            if (childNode == null) return "未在该XML文件中找到子节点";
            childNode.RemoveAllAttributes();
            if (lst != null && lst.Count > 0)
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i].IsEncrypt)
                    {
                        childNode.SetAttribute(lst[i].NodeName,StringSecurity.DESEncrypt(lst[i].NodeValue));
                    }
                    else
                    {
                        childNode.SetAttribute(lst[i].NodeName, lst[i].NodeValue);
                    }
                }
            }
            xmlDoc.Save(FilePath);
            return "更新成功";
        }
    }
}
