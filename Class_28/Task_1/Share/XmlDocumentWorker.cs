using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Task_1.Interfaces;
using Task_1.Models;
using Microsoft.Extensions.Logging;
using System.Reflection;
using System.Xml.Linq;

namespace Task_1.Share
{
    public class XmlDocumentWorker:IXmlWorker
    {
        private readonly XmlDocument _document;
        private readonly ILogger _logger;
        private string _xmlFilePath;
        public XmlDocumentWorker(ILogger logger)
        {
            _document = new XmlDocument();
            _logger = logger;
        }
        public void Add(Note note)
        {
            var xRoot = _document.DocumentElement;
            XmlElement noteElement = _document.CreateElement("notes");
            XmlAttribute nameAttribute = _document.CreateAttribute("surname");
            XmlText surnameText = _document.CreateTextNode(note.Surname);
            nameAttribute.AppendChild(surnameText);

            XmlAttribute birthdayElem = _document.CreateAttribute("birthday");
            XmlText birthdayText = _document.CreateTextNode(note.Birthday);
            nameAttribute.AppendChild(birthdayText);

            noteElement.AppendChild(birthdayElem);

            XmlAttribute phoneElem = _document.CreateAttribute("phoneNumber");
            XmlText phoneText = _document.CreateTextNode(note.NumberPhone);
            nameAttribute.AppendChild(phoneText);

            noteElement.AppendChild(phoneElem);

            xRoot.AppendChild(noteElement);
            _document.Save(_xmlFilePath);
        }
        public void Delete(string name)
        {
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot.ChildNodes)
            {
                if (xNode.Attributes.Count > 0)
                {
                    var attributeSurname = xNode.Attributes.GetNamedItem("surname");
                    try
                    {
                        var attributeSurnameText = attributeSurname?.InnerText;
                        if (attributeSurnameText.Equals(name))
                        {
                            xRoot.RemoveChild(xNode);
                        }
                    }
                    catch (Exception ex) when (ex is XmlException || ex is NullReferenceException)
                    {
                        _logger.LogWarning(ex.Message, nameof(attributeSurname));
                    }
                }
            }
        }
        public Note FindBy(string name)
        {
            Note note = null;
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                note = GetNote(xNode);
                if (note.Surname.Equals(name))
                {
                    return note;
                }
            }
            return note;
        }
        public List<Note> GetAll()
        {
            List<Note> notes = new List<Note>();
            var xRoot = _document.DocumentElement;
            foreach (XmlNode node in xRoot.ChildNodes)
            {
                var note = GetNote(node);
                notes.Add(note);
            }
            return notes;
        }
        public void Load(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
            _document.Load(xmlFilePath);
        }

        private Note GetNote(XmlNode node)
        {
            Note note = new Note();
            XmlNode attr = node.Attributes.GetNamedItem("name");
            note.Surname = attr?.Value;
            foreach (XmlNode childNode in node.ChildNodes)
            {
                try
                {
                    if (childNode.Name.Equals("birthday"))
                    {
                        note.Birthday = childNode.InnerText;
                    }
                    if (childNode.Name.Equals("phoneNumber"))
                    {
                        note.NumberPhone = childNode.InnerText;
                    }
                }
                catch (Exception ex) when (ex is FormatException || ex is NullReferenceException)
                {
                    _logger.LogError(ex.Message, ex.StackTrace, nameof(childNode.InnerText));
                }
            }
            return note;
        }
    }
}
