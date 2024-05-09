using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SQS_Operator_list_getter
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(SynatecLbMessage));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (SynatecLbMessage)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "parameter")]
    public class Parameter
    {

        [XmlAttribute(AttributeName = "name")]
        public double Name { get; set; }

        [XmlAttribute(AttributeName = "encoded")]
        public bool Encoded { get; set; }

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlAttribute(AttributeName = "level")]
        public string Level { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "group")]
    public class Group
    {

        [XmlElement(ElementName = "parameter")]
        public List<Parameter> Parameter { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlText]
        public string Text { get; set; }

        [XmlElement(ElementName = "group")]
        public List<Group> group { get; set; }
    }

    [XmlRoot(ElementName = "data")]
    public class Data
    {

        [XmlElement(ElementName = "group")]
        public Group Group { get; set; }
    }

    [XmlRoot(ElementName = "message")]
    public class Message
    {

        [XmlElement(ElementName = "sender")]
        public object Sender { get; set; }

        [XmlElement(ElementName = "destination")]
        public object Destination { get; set; }

        [XmlElement(ElementName = "owner")]
        public object Owner { get; set; }

        [XmlElement(ElementName = "data")]
        public Data Data { get; set; }
    }

    [XmlRoot(ElementName = "synatec.lb.message")]
    public class SynatecLbMessage
    {

        [XmlElement(ElementName = "message")]
        public Message Message { get; set; }

        [XmlAttribute(AttributeName = "xmlversion")]
        public string Xmlversion { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

}
