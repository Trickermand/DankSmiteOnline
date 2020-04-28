using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GodsAndItems
{
    public static class SmiteGamepediaApi
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
        const string uri = "https://smite.gamepedia.com/List_of_gods";

        public static List<God> GetAllGods()
        {
            List<God> gods = new List<God>();

            //A singular godNode is a row of information in HTML format
            List<HtmlNode> godNodes = GetGodNodes();

            foreach (var godNode in godNodes)
            {
                God god = new God()
                {
                    Name = GetGodName(godNode),
                    Pantheon = GetGodPantheon(godNode),
                    Difficulty = GetGodDifficulty(godNode),
                    FavorCost = GetGodFavorCost(godNode),
                    GemsCost = GetGodGemsCost(godNode),
                    ReleaseDate = GetGodReleaseDate(godNode)
                };
                god.SetAttackType(GetGodAttackType(godNode));
                god.SetPowerType(GetGodPowerType(godNode));
                god.SetGodClass(GetGodClass(godNode));

                gods.Add(god);
            }

            return gods;
        }

        private static List<HtmlNode> GetGodNodes()
        {
            //Magic needed to do SSH/TLS calls
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            WebClient client = new WebClient();
            string fullContent = client.DownloadString(uri);

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(fullContent);

            HtmlNode tableNode = GetInnerTableBody(document);
            List<HtmlNode> godNodes = GetReleasedGods(tableNode);
            return godNodes;
        }


        //:'(

        private static string GetGodName(HtmlNode godNode)
        {
            return godNode.ChildNodes[3].InnerText.Trim();
        }

        private static string GetGodPantheon(HtmlNode godNode)
        {
            return godNode.ChildNodes[5].InnerText.Trim();
        }

        private static string GetGodAttackType(HtmlNode godNode)
        {
            return godNode.ChildNodes[7].InnerText.Trim();
        }

        private static string GetGodPowerType(HtmlNode godNode)
        {
            return godNode.ChildNodes[9].InnerText.Trim();
        }

        private static string GetGodClass(HtmlNode godNode)
        {
            return godNode.ChildNodes[11].InnerText.Trim();
        }

        private static string GetGodDifficulty(HtmlNode godNode)
        {
            return godNode.ChildNodes[13].InnerText.Trim();
        }

        private static string GetGodFavorCost(HtmlNode godNode)
        {
            return godNode.ChildNodes[15].InnerText.Trim();
        }

        private static string GetGodGemsCost(HtmlNode godNode)
        {
            return godNode.ChildNodes[17].InnerText.Trim();
        }

        private static string GetGodReleaseDate(HtmlNode godNode)
        {
            return godNode.ChildNodes[19].InnerText.Trim();
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
                throw;
            }

            return false;
        }

        private static HtmlNode GetInnerTableBody(HtmlDocument document)
        {
            try
            {
                //TODO: This line has a class tag in HTML, refactor so it uses the method GetInnerHtmlNodeBy... 
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
            catch (Exception)
            {
                throw;
            }
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
            try
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
            catch (Exception ex)
            {
                throw new Exception($"Could not get inner HTML node by {nameof(idName)} '{idName}'.", ex);
            }
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
