using Gecko;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace TestWebBrowserApp
{
    public partial class Form1 : Form
    {
        GeckoWebBrowser geckoWebBrowser;
        HtmlNode startNode;
        HtmlNode EndNode;
        HtmlAgilityPack.HtmlDocument htmlDoc;

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //webBrowser1.Navigate();
            geckoWebBrowser.Navigate(textBox1.Text);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            geckoWebBrowser = new GeckoWebBrowser {  Dock = DockStyle.Fill };
            //Form f = new Form();
            //f.Controls.Add(geckoWebBrowser);
            panel1.Controls.Add(geckoWebBrowser);
          
            //geckoWebBrowser.DomMouseOver += GeckoWebBrowser_DomMouseOver;
            geckoWebBrowser.DomClick += click;
            geckoWebBrowser.DomMouseOver += GeckoWebBrowser_DomMouseOver;
            geckoWebBrowser.DomMouseUp += GeckoWebBrowser_DomMouseUp;
            geckoWebBrowser.Click += GeckoWebBrowser_Click;
            geckoWebBrowser.DocumentCompleted += GeckoWebBrowser_DocumentCompleted;
            geckoWebBrowser.DomContextMenu += GeckoWebBrowser_DomContextMenu;
            //geckoWebBrowser.lo





        }

        private void GeckoWebBrowser_DomContextMenu(object sender, DomMouseEventArgs e)
        {
            if (sender == null) return;
            if (e == null) return;
            if (e.Target == null) return;

            var element = e.Target.CastToGeckoElement();

            GeckoHtmlElement clicked = element as GeckoHtmlElement;
            if (clicked == null) return;
            //MessageBox.Show(clicked.TagName);
            e.Handled = true;
            e.PreventDefault();

            
            //clicked.SetAttribute("style", "border: medium solid blue");

           var ele  = clicked.ParentElement;
            var hele = ele as GeckoHtmlElement;
            textBox2.Text = hele.OuterHtml;
            textBox4.Text =  hele.TabIndex.ToString();
            //ele = ele.ParentElement;
            //hele = ele as GeckoHtmlElement;
            //textBox2.Text = textBox2.Text + " P> "  + hele.OuterHtml;
            //textBox4.Text = textBox4.Text + " P> " + hele.TabIndex.ToString();
            //ele = ele.ParentElement;
            //hele = ele as GeckoHtmlElement;
            //textBox2.Text = textBox2.Text + " p> " + hele.OuterHtml;
            //textBox4.Text = textBox4.Text + " P> " + hele.TabIndex.ToString();
            //ele = ele.ParentElement;
            //hele = ele as GeckoHtmlElement;
            //textBox2.Text = textBox2.Text + " p> " + hele.OuterHtml;
            //textBox4.Text = textBox4.Text + " P> " + hele.TagName;
            //ele = ele.ParentElement;
            //hele = ele as GeckoHtmlElement;
            //textBox2.Text = textBox2.Text + " p> " + hele.OuterHtml;
            //textBox4.Text = textBox4.Text + " P> " + hele.TagName;
            //ele = ele.ParentElement;
            //hele = ele as GeckoHtmlElement;
            //textBox2.Text = textBox2.Text + " p> " + hele.OuterHtml;
            //textBox4.Text = textBox4.Text + " P> " + hele.TagName;
            //ele = ele.ParentElement;
            //hele = ele as GeckoHtmlElement;
            //textBox2.Text = textBox2.Text + " p> " + hele.OuterHtml;
            //textBox4.Text = textBox4.Text + " P> " + hele.TagName;
            //ele = ele.ParentElement;
            //hele = ele as GeckoHtmlElement;
            //textBox2.Text = textBox2.Text + " p> " + hele.OuterHtml;
            //textBox4.Text = textBox4.Text + " P> " + hele.TagName;
            //ele = ele.ParentElement;
            //hele = ele as GeckoHtmlElement;
            //textBox2.Text = textBox2.Text + " p> " + hele.OuterHtml;
            //textBox4.Text = textBox4.Text + " P> " + hele.TagName;
            //ele = ele.ParentElement;

            while (ele.ParentElement != null)
            {
                ele = ele.ParentElement;
                hele = ele as GeckoHtmlElement;
                textBox2.Text = textBox2.Text + " p> " + hele.OuterHtml;
                textBox4.Text = textBox4.Text + " P> " + hele.TagName;
            }
            //if (ele != null)
            //{
            //    hele = ele as GeckoHtmlElement;
            //    textBox2.Text = textBox2.Text + " p> " + hele.OuterHtml;
            //    textBox4.Text = textBox4.Text + " P> " + hele.TagName;
            //}
            //ele = ele.ParentElement;
            //if (ele != null)
            //{
            //    hele = ele as GeckoHtmlElement;
            //    textBox2.Text = textBox2.Text + " p> " + hele.OuterHtml;
            //    textBox4.Text = textBox4.Text + " P> " + hele.TagName;
            //}
            //ele = ele.ParentElement;
            //if (ele != null)
            //{
            //    hele = ele as GeckoHtmlElement;
            //    textBox2.Text = textBox2.Text + " p> " + hele.OuterHtml;
            //}

            contextMenuStrip1.Tag = clicked;
            contextMenuStrip1.Show(Cursor.Position);
            //MessageBox.Show("right clicked");
        }

        private void GeckoWebBrowser_DomMouseUp(object sender, DomMouseEventArgs e)
        {
            //textBox2.Text = ((GeckoWebBrowser)sender).Document.ActiveElement.OuterHtml;
            //textBox4.Text = ((GeckoWebBrowser)sender).Document.ActiveElement.OwnerDocument.Body.InnerHtml;
            //textBox5.Text = ((GeckoWebBrowser)sender).Document.ActiveElement.ParentElement.TagName;
            //textBox6.Text = ((GeckoWebBrowser)sender).Document.ActiveElement.TagName;

            //GeckoRange range = geckoWebBrowser.Window.Selection.GetRangeAt(0);
            //string SelectedText = range.CloneContents().TextContent.Trim();
            //textBox3.Text = SelectedText;
            
        }

        private void click(object sender, DomEventArgs e)
        {

            //if (sender == null) return;
            //if (e == null) return;
            //if (e.Target == null) return;

            //var element = e.Target.CastToGeckoElement();

            //GeckoHtmlElement clicked = element as GeckoHtmlElement;
            //if (clicked == null) return;
            ////MessageBox.Show(clicked.TagName);
            //e.Handled = true;
            //e.PreventDefault();
            
            //clicked.SetAttribute("style", "border: medium solid blue");


            //string className = clicked.GetAttribute("class");
            //GeckoNodeCollection nodes = geckoWebBrowser.DomDocument.GetElementsByClassName(className);
            //foreach (var item in nodes)
            //{
            //    if (NodeType.Element == item.NodeType)
            //    {
            //        GeckoElement el = (GeckoElement)item;
            //        el.SetAttribute("style", "border: medium solid orange");
            //    }
            //}

           
        }
            private void GeckoWebBrowser_DomMouseOver(object sender, DomMouseEventArgs e)
        {
            if (e == null) return;
            if (e.Target == null) return;

            var element = e.Target.CastToGeckoElement();

            GeckoHtmlElement clicked = element as GeckoHtmlElement;
            if (clicked == null) return;
            //MessageBox.Show(clicked.TagName);
            e.Handled = true;
            e.PreventDefault();
            textBox5.Text = clicked.InnerHtml;
            textBox6.Text = clicked.OuterHtml;
            //clicked.SetAttribute("style", "border: medium solid blue");
        }

        private void GeckoWebBrowser_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {

            string html = string.Empty;
            GeckoHtmlElement element = null;
            var geckoDomElement = geckoWebBrowser.Document.DocumentElement;
            if (geckoDomElement is GeckoHtmlElement)
            {
                element = (GeckoHtmlElement)geckoDomElement;
                //var innerHtml = element.InnerHtml;
                htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(element.OuterHtml);
            }
            //var links = geckoWebBrowser.Document.GetElementsByTagName("a");
            //foreach (GeckoHtmlElement link in links)
            //{

            //    if (link.GetAttribute("className") == "btn btn-success")
            //    {
            //        //do something
            //    }
            //}
        }

        private void GeckoWebBrowser_DomClick(object sender, DomMouseEventArgs e)
        {
           
            //return;
            //MessageBox.Show(((GeckoWebBrowser)sender).Document.ActiveElement.InnerHtml);
        }

        private void GeckoWebBrowser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hi");
        }

        private void GeckoWebBrowser_MouseHover(object sender, EventArgs e)
        {
           
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    TestModifyingDom(geckoWebBrowser);
        //}


        //protected void TestHighlight(GeckoWebBrowser browser)
        //{
        //    GeckoElement g = browser.Document.DocumentElement;
        //    ModifyElements(g, "BODY", e =>
        //    {
        //        for (int i = 1; i < 4; ++i)
        //        {
        //            var newElement = g.OwnerDocument.CreateElement(String.Format("h{0}", i));
        //            newElement.TextContent = "Geckofx added this text.";
        //            g.InsertBefore(newElement, e);
        //        }
        //    });
        //}

        //protected void ModifyElements(GeckoElement element, string tagName, Action<GeckoElement> mod)
        //{
        //    while (element != null)
        //    {
        //        if (element.TagName == tagName)
        //        {
        //            mod(element);
        //        }
        //        ModifyElements(element.FirstChild as GeckoElement, tagName, mod);
        //        element = (element.NextSibling as GeckoElement);
        //    }
        //}

        //protected void TestModifyingDom(GeckoWebBrowser browser)
        //{
        //    GeckoElement g = browser.Document.DocumentElement;
        //    ModifyElements(g, "BODY", e =>
        //    {
        //        for (int i = 1; i < 4; ++i)
        //        {
        //            var newElement = g.OwnerDocument.CreateElement(String.Format("h{0}", i));
        //            newElement.TextContent = "Geckofx added this text.";
        //            g.InsertBefore(newElement, e);
        //        }
        //    });
        //}

        private void markToolStripMenuItem_Click(object sender, EventArgs e)
        {

            GeckoHtmlElement startNode = (GeckoHtmlElement)contextMenuStrip1.Tag;

            string name; bool haschild;
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(startNode.OuterHtml);
            if (doc.DocumentNode.HasChildNodes)
            {
                 this.startNode = doc.DocumentNode.FirstChild;

                if (this.startNode.NodeType == HtmlNodeType.Element)
                {
                    //HtmlElement ele = node;
                    name = this.startNode.Name;
                    haschild = this.startNode.HasChildNodes;

                }
            }


            //MessageBox.Show("Click");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //   GeckoDocument doc =  geckoWebBrowser.Document;
            //    string str = doc.TextContent;
            //    GeckoDomDocument  gdom = geckoWebBrowser.DomDocument;
            //    string txt = gdom.TextContent;
            //    //geckoWebBrowser.LoadHtml();
            //    string txtt = geckoWebBrowser.DomDocument.ToString();
            string html;
            GeckoHtmlElement element = null;
            var geckoDomElement = geckoWebBrowser.Document.DocumentElement;
            if (geckoDomElement is GeckoHtmlElement)
            {
                element = (GeckoHtmlElement)geckoDomElement;
                //var innerHtml = element.InnerHtml;
                html = element.OuterHtml;
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string name;bool haschild;
            //HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            //doc.LoadHtml(startNode.OuterHtml);
            //if (doc.DocumentNode.HasChildNodes)
            //{
            //    HtmlNode node = doc.DocumentNode.FirstChild;

            //    if (node.NodeType == HtmlNodeType.Element)
            //    {
            //        //HtmlElement ele = node;
            //        name = node.Name;
            //        haschild = node.HasChildNodes;

            //    }
            //}

            //HtmlNode hn = startNode.Clone();
            //bool isit = hn.Equals(startNode);
            //HtmlNode stNode;

            //replace start node
            foreach (var item in htmlDoc.DocumentNode.DescendantsAndSelf())
            {
                if (item.OuterHtml == startNode.OuterHtml)
                {
                    startNode = item;
                    break;
                }
            }

            //replace end node
            foreach (var item in htmlDoc.DocumentNode.DescendantsAndSelf())
            {
                if (item.OuterHtml == EndNode.OuterHtml)
                {
                    EndNode = item;
                    break;
                }
            }


            List<string> ChildrenResult = SearchChildTree(startNode);
            List<string> siblingsResult = new List<string>();
            if (ChildrenResult.Count == 0)
            {
                siblingsResult = SearchSiblings(startNode);
            }



        }

        private void unMarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeckoHtmlElement EndElement = (GeckoHtmlElement)contextMenuStrip1.Tag;


            string name; bool haschild;
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(EndElement.OuterHtml);
            if (doc.DocumentNode.HasChildNodes)
            {
                this.EndNode = doc.DocumentNode.FirstChild;

                if (this.EndNode.NodeType == HtmlNodeType.Element)
                {
                    //HtmlElement ele = node;
                    name = this.EndNode.Name;
                    haschild = this.EndNode.HasChildNodes;

                }
            }
            //Travarse tree start from here..
            //Call recursive func
            //
        }


        private List<string> SearchSiblings(HtmlNode startingNode)
        {
            List<string> directions = new List<string>();
            var parent = startingNode.ParentNode;
            var siblings = parent.ChildNodes;
            
            if (parent == null)
                return directions;
            if (parent.ChildNodes.Count > 1)
            {
                for (int i = 0; i < siblings.Count; i++)
                {
                    //skips startingNode
                    if (siblings[i].OuterHtml == startingNode.OuterHtml)
                        continue;
                    var d =  SearchChildTree(siblings[i]);
                    if (searchList(d, "|Found|"))
                    {
                        directions.AddRange(d);
                        directions.Add(siblings[i].Name + "|ID:" + siblings[i].Id + "|SIBOF:" + startingNode.Name+"|I:"+i);
                        return directions;
                    }
                }
            }
            //else
            //{
                var dr = SearchSiblings(startingNode.ParentNode);
                if (searchList(dr, "|Found|"))
                {
                    directions.AddRange(dr);
                    directions.Add(startingNode.Name + "|ID:" + startingNode.Id + "|CHILDOF:" + startingNode.ParentNode.Name);
                    return directions;
                }
            //}
                   
                
            //}
            return directions;
        }

            //dictionary contains, srcNode + direction
            private List<string> SearchChildTree(HtmlNode startingNode)
        {
           List<string> directions = new List<string>();
            if (startingNode.OuterHtml == EndNode.OuterHtml)
            {
                directions.Add("|Found|");
                return directions;
            }
           
            if (startingNode.HasChildNodes)
            {
                for (int i = 0; i < startingNode.ChildNodes.Count; i++)
                {
                    var child = startingNode.ChildNodes[i];
                    if (child.NodeType != HtmlNodeType.Element)
                        continue;
                    if (startingNode.OuterHtml == EndNode.OuterHtml)
                    {
                        directions.Add("|Found|");
                        return directions;
                    }

                    List<string> d = SearchChildTree(child);
                    if (searchList(d, "|Found|"))
                    {
                        directions.AddRange(d);
                        directions.Add(child.Name + "|ID:" + child.Id + "|CHILDOF:" + startingNode.Name + "|I:|" + i.ToString());
                    }
                }
            }
            //else
            //{
            //    if (startingNode.OuterHtml == EndNode.OuterHtml)
            //    {
            //        directions.Add("|Found|");
            //        return directions;
            //    }
            //}

            return directions;
        }

        private bool searchList(List<string> list, string search)
        {
            foreach (var item in list)
            {
                if (item.ToUpper().Contains(search.ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }


    }
}
