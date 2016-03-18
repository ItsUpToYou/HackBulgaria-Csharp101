using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlMarkupBuilderLib
{
    public class XMLMarkupBuilder
    {
        private Stack<string> tagHolder = new Stack<string>();
        private StringBuilder xmlBuilder = new StringBuilder();
        private bool tagOpen;
        private bool startOpenTag;


        public XMLMarkupBuilder()
        {
            this.tagHolder = new Stack<string>();
            this.xmlBuilder = new StringBuilder();
            this.tagOpen = false;
            this.startOpenTag = false;
        }

        /// <summary>
        /// Open tag.
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public XMLMarkupBuilder openTag(string tag)
        {
            if (!startOpenTag)
            {
                xmlBuilder.Append($"<{tag}>");
                startOpenTag = true;
                tagHolder.Push(tag);
            }
            else
            {
                if (tagOpen)
                {
                    CloseTag();
                    xmlBuilder.Append("\n");
                }

                xmlBuilder.Append($"\t<{tag}>");
                tagHolder.Push(tag);
                tagOpen = true;
            }
            return this;
        }

        /// <summary>
        /// Put the closed tag.
        /// </summary>
        /// <returns></returns>
        private XMLMarkupBuilder CloseTag()
        {
            if (tagHolder.Count == 0)
            {
                throw new ArgumentException("You have to open a tag before to close.");
            }
            else if (tagHolder.Count == 1)
            {
                startOpenTag = false;
                xmlBuilder.Append($"\n</{tagHolder.Pop()}>");
            }
            else
            {
                xmlBuilder.Append($"</{tagHolder.Pop()}>");
            }
            return this;
        }

        /// <summary>
        /// Adding attribute with his value in the open-tag.
        /// </summary>
        /// <param name="attr"></param>
        /// <param name="attrValue"></param>
        /// <returns></returns>
        public XMLMarkupBuilder AddAttr(string attr, string attrValue)
        {
            if (!startOpenTag)
            {
                throw new ArgumentException("First you have to open a tag");
            }
            
            if(tagOpen)
            {
                string tag = tagHolder.Peek();
                xmlBuilder.Replace($"<{tagHolder}>", $"<{tagHolder} {attr} = \"<{attrValue}>\">");
                tagOpen = true;
            }
            else
            {
                string takeTag = tagHolder.Peek();
                xmlBuilder.Append($"\n\t<{takeTag} {attr} = \"{attrValue}\">");
                tagHolder.Push(takeTag);
                tagOpen = true;
            }
            return this;
        }

        /// <summary>
        /// Addin text between the tags.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public XMLMarkupBuilder addText(string text)
        {
            if (!startOpenTag)
            {
                throw new ArgumentException("First you have to open a tag");
            }
            xmlBuilder.Append(text);
            return this;
        }

        /// <summary>
        /// Check for if there is open tag and proceed to close it.
        /// </summary>
        /// <returns></returns>
        public XMLMarkupBuilder Finalize()
        {
            if (!startOpenTag)
            {
                throw new ArgumentException("First you have to open a tag");
            }
            while (tagHolder.Count > 0)
            {
                CloseTag();
            }
            return this;
        }

        /// <summary>
        /// Give you xml output
        /// </summary>
        /// <returns></returns>
        public String GetResult()
        {
            return xmlBuilder.ToString();
        }
    }
}
