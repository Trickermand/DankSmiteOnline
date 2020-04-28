using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TempProject
{
    class Program
    {
        const string html_globalWrapper_Id = "global-wrapper";
        const string html_pageWrapper_Id = "pageWrapper";
        const string html_content_Id = "content";
        const string html_bodyContent_Id = "bodyContent";
        const string html_mwContentText_Id = "mw-content-text";
        const string html_mwParserOutput_Class = "mw-parser-output";
        const string html_blueWindowSortable_Class = "blue-window sortable";
        const string html_tBody_TypeName = "tbody";
        const string dateFormat = "yyyy-MM-dd";

        public static void Main(string[] args)
        {
            //Magic needed to do SSH/TLS calls
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            const string uri = "https://smite.gamepedia.com/List_of_gods";

            WebClient client = new WebClient();
            string fullContent = client.DownloadString(uri);

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(fullContent);

            HtmlNode tableNode = GetInnerTableBody(document);
            List<HtmlNode> godNodes = GetReleasedGods(tableNode);


            //HtmlNode achilles = tableNodes.ChildNodes[2].ChildNodes[3];
            //string achillesName = achilles.InnerText;
            //Console.WriteLine(achillesName);



            Console.ReadLine();

        }

        private static void PrintAllGodNames(List<HtmlNode> godNodes)
        {
            foreach (var godNode in godNodes)
            {
                var temppart = godNode.ChildNodes[3];
                System.Console.WriteLine(temppart.InnerText);
            }
        }

        private static List<HtmlNode> GetReleasedGods(HtmlNode tableNode)
        {
            List<HtmlNode> godNodes = new List<HtmlNode>();
            bool isFirstNode = true;

            foreach (HtmlNode node in tableNode.ChildNodes)
            {
                if (isFirstNode && node.Name == "tr")
                {
                    isFirstNode = false;
                    continue;
                }

                if (node.Name == "tr" && GodIsReleased(node))
                {
                    godNodes.Add(node);
                }
            }

            return godNodes;
        }

        private static bool GodIsReleased(HtmlNode node)
        {
            try
            {
                if (DateTime.ParseExact(node.LastChild.InnerText.Replace("\n", ""), dateFormat, null) <= DateTime.Now)
                    return true;
            }
            catch (Exception)
            {
            }
            return false;
        }

        private static HtmlNode GetGodsFromTable(HtmlNode table)
        {
            HtmlNode innerNode = null;
            foreach (var childNodes in table.ChildNodes)
            {
                if (childNodes.Name == "tr")
                {
                    innerNode = childNodes;
                    break;
                }
            }
            return innerNode;
        }

        private static string GetGodName()
        {
            return "";
        }

        private static HtmlNode GetInnerTableBody(HtmlDocument document)
        {
            HtmlNode body = document.DocumentNode.ChildNodes[2].ChildNodes[3];
            HtmlNode globalWrapper = GetInnerHtmlNodeById(body, html_globalWrapper_Id);
            HtmlNode pageWrapper = GetInnerHtmlNodeById(globalWrapper, html_pageWrapper_Id);
            HtmlNode content = GetInnerHtmlNodeById(pageWrapper, html_content_Id);
            HtmlNode bodyContent = GetInnerHtmlNodeById(content, html_bodyContent_Id);
            HtmlNode mwContentText = GetInnerHtmlNodeById(bodyContent, html_mwContentText_Id);
            HtmlNode mwParserOutput = GetInnerHtmlNodeByClass(mwContentText, html_mwParserOutput_Class);
            HtmlNode blueWindowSortable = GetInnerHtmlNodeByClass(mwParserOutput, html_blueWindowSortable_Class);
            return GetInnerHtmlNodeByHtmlType(blueWindowSortable, html_tBody_TypeName);
        }

        private static HtmlNode GetInnerHtmlNodeByHtmlType(HtmlNode node, string typeName)
        {
            HtmlNode innerNode = null;
            foreach (var childNodes in node.ChildNodes)
            {
                if (childNodes.Name == typeName)
                {
                    innerNode = childNodes;
                    break;
                }
            }
            return innerNode;
        }

        private static HtmlNode GetInnerHtmlNodeById(HtmlNode node, string idName)
        {
            HtmlNode innerNode = null;
            foreach (var childNodes in node.ChildNodes)
            {
                if (childNodes.Id == idName)
                {
                    innerNode = childNodes;
                    break;
                }
            }
            return innerNode;
        }

        private static HtmlNode GetInnerHtmlNodeByClass(HtmlNode node, string className)
        {
            HtmlNode innerNode = null;
            foreach (var childNodes in node.ChildNodes)
            {
                foreach (var childNodeAttributes in childNodes.Attributes)
                {
                    if (childNodeAttributes.Name == "class" && childNodeAttributes.Value == className)
                    {
                        innerNode = childNodes;
                        break;
                    }
                }
            }
            return innerNode;
        }
    }
}
